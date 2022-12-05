// <copyright file = "SqlServerConverter.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExcess
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using BudgetExecution;
    using log4net;
    using System.IO;

    /// <summary>
    /// This class is responsible to take a single SQL Server database and convert it to
    /// an SQLite database file.
    /// </summary>
    /// <remarks>
    /// The class knows how to convert table and index structures only.
    /// </remarks>
    public class SqlServerConverter
    {
        /// <summary>
        /// The cancelled
        /// </summary>
        private bool _cancelled;

        /// <summary>
        /// The key
        /// </summary>
        private readonly Regex _keys = new Regex( @"(([a-zA-ZäöüÄÖÜß0-9\.]|(\s+))+)(\(\-\))?" );

        /// <summary>
        /// The default value
        /// </summary>
        private readonly Regex _value = new Regex( @"\(N(\'.*\')\)" );

        /// <summary>
        /// The log
        /// </summary>
        private readonly ILog _log = LogManager.GetLogger( typeof( SqlServerConverter ) );

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SqlServerConverter" />
        /// class.
        /// </summary>
        public SqlServerConverter( )
        {
        }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is active.
        /// </summary>
        /// <value>
        /// <c> true </c>
        /// if this instance is active; otherwise,
        /// <c> false </c>
        /// .
        /// </value>
        private bool IsActive { get; set; }

        /// <summary>
        /// Writes the trigger schema.
        /// </summary>
        /// <param name="schema">The ts.</param>
        /// <returns></returns>
        private string WriteTriggerSchema( TriggerSchema schema )
        {
            return @"CREATE TRIGGER [" + schema.Name + "] " + schema.Type + " " + schema.Event
                + " ON [" + schema.Table + "] " + "BEGIN " + schema.Body + " END;";
        }

        /// <summary>
        /// Cancels the conversion.
        /// </summary>
        public void CancelConversion( )
        {
            _cancelled = true;
        }

        /// <summary>
        /// Converts the SQL server to sq lite database.
        /// </summary>
        /// <param name="connectionString">The sqlserverconnstring.</param>
        /// <param name="path">The path.</param>
        /// <param name="passWord">The password.</param>
        /// <param name="handler">The handler.</param>
        /// <param name="selectionHandler">The selectionhandler.</param>
        /// <param name="failureHandler">The viewfailurehandler.</param>
        /// <param name="createTriggers">if set to
        /// <c> true </c>
        /// [createtriggers].</param>
        /// <param name="createViews">if set to
        /// <c> true </c>
        /// [createviews].</param>
        public void ConvertSqlServerToSQLiteDatabase( string connectionString, string path,
            string passWord, SqlConversionHandler handler,
            SqlTableSelectionHandler selectionHandler, FailedViewDefinitionHandler failureHandler,
            bool createTriggers, bool createViews )
        {
            _cancelled = false;
            ThreadPool.QueueUserWorkItem( delegate
            {
                try
                {
                    IsActive = true;
                    ConvertToSQLite( connectionString, path, passWord, handler, selectionHandler,
                        failureHandler, createTriggers, createViews );

                    IsActive = false;
                    handler( true, true, 100, "Finished converting database" );
                }
                catch( Exception ex )
                {
                    _log.Error( "Failed to convert SQL Server database to SQLite database", ex );
                    IsActive = false;
                    handler( true, false, 100, ex.Message );
                }
            } );
        }

        /// <summary>
        /// Converts to sq lite.
        /// </summary>
        /// <param name="sqlconnstring">The sqlconnstring.</param>
        /// <param name="path">The path.</param>
        /// <param name="password">The password.</param>
        /// <param name="handler">The handler.</param>
        /// <param name="selectionhandler">The selectionhandler.</param>
        /// <param name="viewfailurehandler">The viewfailurehandler.</param>
        /// <param name="createtriggers">if set to
        /// <c> true </c>
        /// [createtriggers].</param>
        /// <param name="createviews">if set to
        /// <c> true </c>
        /// [createviews].</param>
        private void ConvertToSQLite( string sqlconnstring, string path, string password,
            SqlConversionHandler handler, SqlTableSelectionHandler selectionhandler,
            FailedViewDefinitionHandler viewfailurehandler, bool createtriggers, bool createviews )
        {
            if( File.Exists( path ) )
            {
                File.Delete( path );
            }

            var ds = ReadSqlServerSchema( sqlconnstring, handler, selectionhandler );
            CreateSQLiteDatabase( path, ds, password, handler, viewfailurehandler,
                createviews );

            CopyDataRows( sqlconnstring, path, ds.Tables, password, handler );
            if( createtriggers )
            {
                AddTriggersForForeignKeys( path, ds.Tables, password );
            }
        }

        /// <summary>
        /// Copies the Data rows.
        /// </summary>
        /// <param name="sqlconnstring">The sqlconnstring.</param>
        /// <param name="path">The path.</param>
        /// <param name="schema">The schema.</param>
        /// <param name="password">The password.</param>
        /// <param name="handler">The handler.</param>
        private void CopyDataRows( string sqlconnstring, string path, IList<TableSchema> schema,
            string password, SqlConversionHandler handler )
        {
            CheckCancelled( );
            handler( false, true, 0, "Preparing to insert tables..." );
            _log.Debug( "preparing to insert tables ..." );
            var ssconn = new SqlConnection( sqlconnstring );
            ssconn.Open( );
            var sqliteconnstring = CreateSQLiteConnectionString( path, password );
            var sqconn = new SQLiteConnection( sqliteconnstring );
            sqconn.Open( );
            for( var i = 0; i < schema.Count; i++ )
            {
                var tx = sqconn.BeginTransaction( );
                try
                {
                    var tablequery = BuildSqlServerTableQuery( schema[ i ] );
                    using( var query = new SqlCommand( tablequery, ssconn ) )
                    {
                        var reader = query.ExecuteReader( );
                        var insert = BuildSQLiteInsert( schema[ i ] );
                        var counter = 0;
                        while( reader.Read( ) )
                        {
                            insert.Connection = sqconn;
                            insert.Transaction = tx;
                            var pnames = new List<string>( );
                            for( var j = 0; j < schema[ i ].Columns.Count; j++ )
                            {
                                var pname = "@"
                                    + GetNormalizedName( schema[ i ].Columns[ j ].ColumnName,
                                        pnames );

                                insert.Parameters[ pname ].Value =
                                    CastValueForColumn( reader[ j ], schema[ i ].Columns[ j ] );

                                pnames.Add( pname );
                            }

                            insert.ExecuteNonQuery( );
                            counter++;
                            if( counter % 1000 == 0 )
                            {
                                CheckCancelled( );
                                tx.Commit( );
                                handler( false, true, (int)( 100.0 * i / schema.Count ),
                                    "Added " + counter + " rows to table " + schema[ i ].TableName
                                    + " so far" );

                                tx = sqconn.BeginTransaction( );
                            }
                        }
                    }

                    CheckCancelled( );
                    tx.Commit( );
                    handler( false, true, (int)( 100.0 * i / schema.Count ),
                        "Finished inserting rows for table " + schema[ i ].TableName );

                    _log.Debug( "finished inserting all rows for table [" + schema[ i ].TableName
                        + "]" );
                }
                catch( Exception ex )
                {
                    _log.Error( "unexpected exception", ex );
                    tx.Rollback( );
                    throw;
                }
            }
        }

        /// <summary>
        /// Casts the value for column.
        /// </summary>
        /// <param name="val">The value.</param>
        /// <param name="columnschema">The columnschema.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException">Illegal database type [" +
        /// Enum.GetName(typeof(DbType), dt) + "]</exception>
        private object CastValueForColumn( object val, ColumnSchema columnschema )
        {
            if( val is DBNull )
            {
                return null;
            }

            var dt = GetDbTypeOfColumn( columnschema );
            switch( dt )
            {
                case DbType.Int32:
                {
                    switch( val )
                    {
                        case short s:
                        {
                            return (int)s;
                        }

                        case byte b:
                        {
                            return (int)b;
                        }

                        case long l:
                        {
                            return (int)l;
                        }

                        case decimal val1:
                        {
                            return (int)val1;
                        }
                    }

                    break;
                }

                case DbType.Int16:
                {
                    switch( val )
                    {
                        case int i:
                        {
                            return (short)i;
                        }

                        case byte b:
                        {
                            return (short)b;
                        }

                        case long l:
                        {
                            return (short)l;
                        }

                        case decimal val1:
                        {
                            return (short)val1;
                        }
                    }

                    break;
                }

                case DbType.Int64:
                {
                    switch( val )
                    {
                        case int i:
                            return (long)i;

                        case short s:
                            return (long)s;

                        case byte b:
                            return (long)b;

                        case decimal val1:
                            return (long)val1;
                    }

                    break;
                }

                case DbType.Single:
                {
                    switch( val )
                    {
                        case double d:
                            return (float)d;

                        case decimal val1:
                            return (float)val1;
                    }

                    break;
                }

                case DbType.Double:
                {
                    switch( val )
                    {
                        case float f:
                            return (double)f;

                        case double d:
                            return d;

                        case decimal val1:
                            return (double)val1;
                    }

                    break;
                }

                case DbType.String:
                {
                    if( val is Guid guid )
                    {
                        return guid.ToString( );
                    }

                    break;
                }

                case DbType.Guid:
                {
                    switch( val )
                    {
                        case string s:
                            return ParseStringAsGuid( s );

                        case byte[ ] bytes:
                            return ParseBlobAsGuid( bytes );
                    }

                    break;
                }

                case DbType.Binary:
                case DbType.Boolean:
                case DbType.DateTime:
                    break;

                default:
                {
                    _log.Error( "argument exception - illegal database type" );
                    throw new ArgumentException( "Illegal database type ["
                        + Enum.GetName( typeof( DbType ), dt ) + "]" );
                }
            }

            return val;
        }

        /// <summary>
        /// Parses the BLOB as unique identifier.
        /// </summary>
        /// <param name="blob">The BLOB.</param>
        /// <returns></returns>
        private Guid ParseBlobAsGuid( IEnumerable<byte> blob )
        {
            var data = blob.ToArray( );
            switch( blob.Count( ) )
            {
                case 16:
                {
                    data = new byte[ 16 ];
                    for( var i = 0; i < 16; i++ )
                    {
                        data[ i ] = blob.ToArray( )[ i ];
                    }

                    break;
                }

                case 17:
                {
                    data = new byte[ 16 ];
                    for( var i = 0; i < blob.Count( ); i++ )
                    {
                        data[ i ] = blob.ToArray( )[ i ];
                    }

                    break;
                }
            }

            return new Guid( data );
        }

        /// <summary>
        /// Parses the string as unique identifier.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        private Guid ParseStringAsGuid( string str )
        {
            try
            {
                return new Guid( str );
            }
            catch( Exception )
            {
                return Guid.Empty;
            }
        }

        /// <summary>
        /// Builds the sq lite insert.
        /// </summary>
        /// <param name="ts">The ts.</param>
        /// <returns></returns>
        private SQLiteCommand BuildSQLiteInsert( TableSchema ts )
        {
            var _command = new SQLiteCommand( );
            var _stringBuilder = new StringBuilder( );
            _stringBuilder.Append( $"INSERT INTO {ts.TableName}" );
            for( var i = 0; i < ts.Columns.Count; i++ )
            {
                _stringBuilder.Append( "[" + ts.Columns[ i ].ColumnName + "]" );
                if( i < ts.Columns.Count - 1 )
                {
                    _stringBuilder.Append( ", " );
                }
            }

            _stringBuilder.Append( ") VALUES (" );
            var _names = new List<string>( );
            for( var i = 0; i < ts.Columns.Count; i++ )
            {
                var _name = "@" + GetNormalizedName( ts.Columns[ i ].ColumnName, _names );
                _stringBuilder.Append( _name );
                if( i < ts.Columns.Count - 1 )
                {
                    _stringBuilder.Append( ", " );
                }

                var _dbType = GetDbTypeOfColumn( ts.Columns[ i ] );
                var _parameter = new SQLiteParameter( _name, _dbType, ts.Columns[ i ].ColumnName );
                _command.Parameters.Add( _parameter );
                _names.Add( _name );
            }

            _stringBuilder.Append( ')' );
            _command.CommandText = _stringBuilder.ToString( );
            _command.CommandType = CommandType.Text;
            return _command;
        }

        /// <summary>
        /// Gets the name of the normalized.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="names">The names.</param>
        /// <returns></returns>
        private string GetNormalizedName( string str, ICollection<string> names )
        {
            var _stringBuilder = new StringBuilder( );
            for( var i = 0; i < str.Length; i++ )
            {
                if( char.IsLetterOrDigit( str[ i ] ) )
                {
                    _stringBuilder.Append( str[ i ] );
                }
                else
                {
                    _stringBuilder.Append( "" );
                }
            }

            return names.Contains( _stringBuilder.ToString( ) )
                ? GetNormalizedName( _stringBuilder + "", names )
                : _stringBuilder.ToString( );
        }

        /// <summary>
        /// Gets the database type of column.
        /// </summary>
        /// <param name="columnSchema">The cs.</param>
        /// <returns></returns>
        /// <exception cref="ApplicationException">Illegal DB type found (" +
        /// cs.ColumnType + ")</exception>
        private DbType GetDbTypeOfColumn( ColumnSchema columnSchema )
        {
            switch( columnSchema.ColumnType )
            {
                case "tinyint":
                    return DbType.Byte;

                case "int":
                    return DbType.Int32;

                case "smallint":
                    return DbType.Int16;

                case "bigint":
                    return DbType.Int64;

                case "bit":
                    return DbType.Boolean;

                case "nvarchar":
                case "varchar":
                case "text":
                case "ntext":
                    return DbType.String;

                case "float":
                    return DbType.Double;

                case "real":
                    return DbType.Single;

                case "blob":
                    return DbType.Binary;

                case "numeric":
                    return DbType.Double;

                case "timestamp":
                case "datetime":
                case "datetime2":
                case "date":
                case "time":
                    return DbType.DateTime;

                case "nchar":
                case "char":
                    return DbType.String;

                case "uniqueidentifier":
                case "guid":
                    return DbType.Guid;

                case "xml":
                    return DbType.String;

                case "sqlvariant":
                    return DbType.Object;

                case "integer":
                    return DbType.Int64;

                default:
                    _log.Error( "illegal db type found" );
                    var _message = "Illegal type (" + columnSchema.ColumnType + ")";
                    throw new ApplicationException( _message );
            }
        }

        /// <summary>
        /// Builds the SQL server table query.
        /// </summary>
        /// <param name="ts">The ts.</param>
        /// <returns></returns>
        private string BuildSqlServerTableQuery( TableSchema ts )
        {
            var _stringBuilder = new StringBuilder( );
            _stringBuilder.Append( "SELECT " );
            for( var i = 0; i < ts.Columns.Count; i++ )
            {
                _stringBuilder.Append( "[" + ts.Columns[ i ].ColumnName + "]" );
                if( i < ts.Columns.Count - 1 )
                {
                    _stringBuilder.Append( ", " );
                }
            }

            _stringBuilder.Append( " FROM " + ts.TableSchemaName + "." + "[" + ts.TableName + "]" );
            return _stringBuilder.ToString( );
        }

        /// <summary>
        /// Creates the sq lite database.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="schema">The schema.</param>
        /// <param name="passWord">The password.</param>
        /// <param name="handler">The handler.</param>
        /// <param name="viewFailureHandler">The viewfailurehandler.</param>
        /// <param name="createViews">if set to
        /// <c> true </c>
        /// [createviews].</param>
        private void CreateSQLiteDatabase( string path, DatabaseSchema schema, string passWord,
            SqlConversionHandler handler, FailedViewDefinitionHandler viewFailureHandler,
            bool createViews )
        {
            _log.Debug( "Creating SQLite database..." );
            SQLiteConnection.CreateFile( path );
            _log.Debug( "SQLite file was created successfully at [" + path + "]" );
            var sqliteconnstring = CreateSQLiteConnectionString( path, passWord );
            using( var conn = new SQLiteConnection( sqliteconnstring ) )
            {
                conn.Open( );
                var count = 0;
                foreach( var dt in schema.Tables )
                {
                    try
                    {
                        AddSQLiteTable( conn, dt );
                    }
                    catch( Exception ex )
                    {
                        _log.Error( "AddSQLiteTable failed", ex );
                        throw;
                    }

                    count++;
                    CheckCancelled( );
                    handler( false, true, (int)( count * 50.0 / schema.Tables.Count ),
                        "Added table " + dt.TableName + " to the SQLite database" );

                    _log.Debug( "added schema for SQLite table [" + dt.TableName + "]" );
                }

                count = 0;
                if( createViews )
                {
                    foreach( var vs in schema.Views )
                    {
                        try
                        {
                            AddSQLiteView( conn, vs, viewFailureHandler );
                        }
                        catch( Exception ex )
                        {
                            _log.Error( "AddSQLiteView failed", ex );
                            throw;
                        }

                        count++;
                        CheckCancelled( );
                        handler( false, true, 50 + (int)( count * 50.0 / schema.Views.Count ),
                            "Added view " + vs.ViewName + " to the SQLite database" );

                        _log.Debug( "added schema for SQLite view [" + vs.ViewName + "]" );
                    }
                }
            }

            _log.Debug( "finished adding all table/view schemas for SQLite database" );
        }

        /// <summary>
        /// Adds the sq lite view.
        /// </summary>
        /// <param name="conn">The connection.</param>
        /// <param name="vs">The vs.</param>
        /// <param name="handler">The handler.</param>
        private void AddSQLiteView( SQLiteConnection conn, ViewSchema vs,
            FailedViewDefinitionHandler handler )
        {
            var stmt = vs.ViewSql;
            _log.Info( "\n\n" + stmt + "\n\n" );
            var tx = conn.BeginTransaction( );
            try
            {
                using( var cmd = new SQLiteCommand( stmt, conn, tx ) )
                {
                    cmd.ExecuteNonQuery( );
                }

                tx.Commit( );
            }
            catch( SQLiteException )
            {
                tx.Rollback( );
                if( handler != null )
                {
                    var updated = new ViewSchema
                    {
                        ViewName = vs.ViewName,
                        ViewSql = vs.ViewSql
                    };

                    var sql = handler( updated );
                    if( sql == null )
                    {
                    }
                    else
                    {
                        updated.ViewSql = sql;
                        AddSQLiteView( conn, updated, handler );
                    }
                }
                else
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Adds the sq lite table.
        /// </summary>
        /// <param name="conn">The connection.</param>
        /// <param name="dt">The dt.</param>
        private void AddSQLiteTable( SQLiteConnection conn, TableSchema dt )
        {
            var _commandText = BuildCreateTableQuery( dt );
            _log.Info( "\n\n" + _commandText + "\n\n" );
            var _command = new SQLiteCommand( _commandText, conn );
            _command.ExecuteNonQuery( );
        }

        /// <summary>
        /// Builds the create table query.
        /// </summary>
        /// <param name="schema">The ts.</param>
        /// <returns></returns>
        private string BuildCreateTableQuery( TableSchema schema )
        {
            var _stringBuilder = new StringBuilder( );
            _stringBuilder.Append( $"CREATE TABLE {schema.TableName}" );
            var _key = false;
            for( var i = 0; i < schema.Columns.Count; i++ )
            {
                var _column = schema.Columns[ i ];
                var _statement = BuildColumnStatement( _column, schema, ref _key );
                _stringBuilder.Append( _statement );
                if( i < schema.Columns.Count - 1 )
                {
                    _stringBuilder.Append( ",\n" );
                }
            }

            if( schema.PrimaryKey != null
               && schema.PrimaryKey.Count > 0 & !_key )
            {
                _stringBuilder.Append( ",\n" );
                _stringBuilder.Append( "    PRIMARY KEY (" );
                for( var i = 0; i < schema.PrimaryKey.Count; i++ )
                {
                    _stringBuilder.Append( "[" + schema.PrimaryKey[ i ] + "]" );
                    if( i < schema.PrimaryKey.Count - 1 )
                    {
                        _stringBuilder.Append( ", " );
                    }
                }

                _stringBuilder.Append( ")\n" );
            }
            else
            {
                _stringBuilder.Append( '\n' );
            }

            if( schema.ForeignKeys.Count > 0 )
            {
                _stringBuilder.Append( ",\n" );
                for( var i = 0; i < schema.ForeignKeys.Count; i++ )
                {
                    var foreignkey = schema.ForeignKeys[ i ];
                    var stmt = $"    FOREIGN KEY ([{foreignkey.ColumnName}])\n "
                        + "REFERENCES [{foreignkey.ForeignTableName}]"
                        + "([{foreignkey.ForeignColumnName}])";

                    _stringBuilder.Append( stmt );
                    if( i < schema.ForeignKeys.Count - 1 )
                    {
                        _stringBuilder.Append( ",\n" );
                    }
                }
            }

            _stringBuilder.Append( '\n' );
            _stringBuilder.Append( ");\n" );
            if( schema.Indexes != null )
            {
                for( var i = 0; i < schema.Indexes.Count; i++ )
                {
                    var stmt = BuildCreateIndex( schema.TableName, schema.Indexes[ i ] );
                    _stringBuilder.Append( stmt + ";\n" );
                }
            }

            var query = _stringBuilder.ToString( );
            return query;
        }

        /// <summary>
        /// Builds the index of the create.
        /// </summary>
        /// <param name="tablename">The tablename.</param>
        /// <param name="schema">The schema.</param>
        /// <returns></returns>
        private string BuildCreateIndex( string tablename, IndexSchema schema )
        {
            var _stringBuilder = new StringBuilder( );
            _stringBuilder.Append( "CREATE " );
            if( schema.IsUnique )
            {
                _stringBuilder.Append( "UNIQUE " );
            }

            _stringBuilder.Append( "INDEX [" + tablename + "" + schema.IndexName + "]\n" );
            _stringBuilder.Append( "ON [" + tablename + "]\n" );
            _stringBuilder.Append( '(' );
            for( var i = 0; i < schema.Columns.Count; i++ )
            {
                _stringBuilder.Append( "[" + schema.Columns[ i ] + "]" );
                if( schema.Columns[ i ] != null )
                {
                    _stringBuilder.Append( " DESC" );
                }

                if( i < schema.Columns.Count - 1 )
                {
                    _stringBuilder.Append( ", " );
                }
            }

            _stringBuilder.Append( ')' );
            return _stringBuilder.ToString( );
        }

        /// <summary>
        /// Builds the column statement.
        /// </summary>
        /// <param name="column">The col.</param>
        /// <param name="schema">The ts.</param>
        /// <param name="primaryKey">if set to
        /// <c> true </c>
        /// [pkey].</param>
        /// <returns></returns>
        private string BuildColumnStatement( ColumnSchema column, TableSchema schema,
            ref bool primaryKey )
        {
            var _stringBuilder = new StringBuilder( );
            _stringBuilder.Append( "\t[" + column.ColumnName + "]\t" );
            if( column.IsIdentity )
            {
                if( schema.PrimaryKey.Count == 1
                   && ( column.ColumnType == "tinyint" || column.ColumnType == "int"
                       || column.ColumnType == "smallint" || column.ColumnType == "bigint"
                       || column.ColumnType == "integer" ) )
                {
                    _stringBuilder.Append( "integer PRIMARY KEY AUTOINCREMENT" );
                    primaryKey = true;
                }
                else
                {
                    _stringBuilder.Append( "integer" );
                }
            }
            else
            {
                switch( column.ColumnType )
                {
                    case "int":
                        _stringBuilder.Append( "integer" );
                        break;

                    default:
                        _stringBuilder.Append( column.ColumnType );
                        break;
                }

                if( column.Length > 0 )
                {
                    _stringBuilder.Append( "(" + column.Length + ")" );
                }
            }

            if( !column.IsNullable )
            {
                _stringBuilder.Append( " NOT NULL" );
            }

            if( column.IsCaseSensitive == false )
            {
                _stringBuilder.Append( " COLLATE NOCASE" );
            }

            var _default = StripParens( column.DefaultValue );
            _default = DiscardNational( _default );
            _log.Debug( "DEFAULT VALUE BEFORE [" + column.DefaultValue + "] AFTER [" + _default
                + "]" );

            switch( string.IsNullOrEmpty( _default ) )
            {
                case false when _default.ToUpper( ).Contains( "GETDATE" ):
                    _log.Debug( "converted SQL Server GETDATE() to CURRENTTIMESTAMP for column ["
                        + column.ColumnName + "]" );

                    _stringBuilder.Append( " DEFAULT (CURRENTTIMESTAMP)" );
                    break;

                case false when IsValidDefaultValue( _default ):
                    _stringBuilder.Append( " DEFAULT " + _default );
                    break;
            }

            return _stringBuilder.ToString( );
        }

        /// <summary>
        /// Discards the national.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        private string DiscardNational( string value )
        {
            var rx = new Regex( @"N\'([^\']*)\'" );
            var m = rx.Match( value );
            return m.Success
                ? m.Groups[ 1 ].Value
                : value;
        }

        /// <summary>
        /// Determines whether [is valid default value] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// <c> true </c>
        /// if [is valid default value] [the specified value]; otherwise,
        /// <c> false </c>
        /// .
        /// </returns>
        private bool IsValidDefaultValue( string value )
        {
            return IsSingleQuoted( value ) || double.TryParse( value, out _ );
        }

        /// <summary>
        /// Determines whether [is single quoted] [the specified value].
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        /// <c> true </c>
        /// if [is single quoted] [the specified value]; otherwise,
        /// <c> false </c>
        /// .
        /// </returns>
        private bool IsSingleQuoted( string value )
        {
            value = value.Trim( );
            return value.StartsWith( "'" ) && value.EndsWith( "'" );
        }

        /// <summary>
        /// Strips the parens.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        private string StripParens( string value )
        {
            var rx = new Regex( @"\(([^\)]*)\)" );
            var m = rx.Match( value );
            return !m.Success
                ? value
                : StripParens( m.Groups[ 1 ].Value );
        }

        /// <summary>
        /// Reads the SQL server schema.
        /// </summary>
        /// <param name="connectionString">The connstring.</param>
        /// <param name="handler">The handler.</param>
        /// <param name="selectionHandler">The selectionhandler.</param>
        /// <returns></returns>
        private DatabaseSchema ReadSqlServerSchema( string connectionString,
            SqlConversionHandler handler, SqlTableSelectionHandler selectionHandler )
        {
            var _tables = new List<TableSchema>( );
            using var _connection = new SqlConnection( connectionString );
            {
                _connection.Open( );
                var _tableNames = new List<string>( );
                var _tableSchema = new List<string>( );
                const string _sql =
                    @"select * from INFORMATIONSCHEMA.TABLES  where TABLETYPE = 'BASE TABLE'";

                using( var cmd = new SqlCommand( _sql, _connection ) )
                {
                    var reader = cmd.ExecuteReader( );
                    while( reader.Read( ) )
                    {
                        if( reader[ "TABLENAME" ] == DBNull.Value )
                        {
                            continue;
                        }

                        if( reader[ "TABLESCHEMA" ] == DBNull.Value )
                        {
                            continue;
                        }

                        _tableNames.Add( (string)reader[ "TABLENAME" ] );
                        _tableSchema.Add( (string)reader[ "TABLESCHEMA" ] );
                    }
                }

                var count = 0;
                for( var i = 0; i < _tableNames.Count; i++ )
                {
                    var _name = _tableNames[ i ];
                    var _schema = _tableSchema[ i ];
                    var ts = CreateTableSchema( _connection, _name, _schema );
                    CreateForeignKeySchema( _connection, ts );
                    _tables.Add( ts );
                    count++;
                    CheckCancelled( );
                    handler( false, true, (int)( count * 50.0 / _tableNames.Count ),
                        "Parsed table " + _name );

                    _log.Debug( "parsed table schema for [" + _name + "]" );
                }
            }

            _log.Debug( "finished parsing all tables in SQL Server schema" );
            var _updated = selectionHandler?.Invoke( _tables );
            if( _updated != null )
            {
                _tables = _updated;
            }

            var _regex = new Regex( @"dbo\.", RegexOptions.Compiled | RegexOptions.IgnoreCase );
            var views = new List<ViewSchema>( );
            using( var conn = new SqlConnection( connectionString ) )
            {
                conn.Open( );
                const string _sql =
                    @"SELECT TABLENAME, VIEWDEFINITION  from INFORMATIONSCHEMA.VIEWS";

                var _command = new SqlCommand( _sql, conn );
                var _reader = _command.ExecuteReader( );
                var _count = 0;
                while( _reader.Read( ) )
                {
                    var _schema = new ViewSchema( );
                    if( _reader[ "TABLENAME" ] == DBNull.Value )
                    {
                        continue;
                    }

                    if( _reader[ "VIEWDEFINITION" ] == DBNull.Value )
                    {
                        continue;
                    }

                    _schema.ViewName = (string)_reader[ "TABLENAME" ];
                    _schema.ViewSql = (string)_reader[ "VIEWDEFINITION" ];
                    _schema.ViewSql = _regex.Replace( _schema.ViewSql, string.Empty );
                    views.Add( _schema );
                    _count++;
                    CheckCancelled( );
                    handler( false, true, 50 + (int)( _count * 50.0 / views.Count ),
                        "Parsed view " + _schema.ViewName );

                    _log.Debug( "parsed view schema for [" + _schema.ViewName + "]" );
                }
            }

            var _databaseSchema = new DatabaseSchema
            {
                Tables = _tables,
                Views = views
            };

            return _databaseSchema;
        }

        /// <summary>
        /// Checks the cancelled.
        /// </summary>
        /// <exception cref="ApplicationException">User cancelled the conversion</exception>
        private void CheckCancelled( )
        {
            if( _cancelled )
            {
                throw new ApplicationException( "User cancelled the conversion" );
            }
        }

        /// <summary>
        /// Creates the table schema.
        /// </summary>
        /// <param name="conn">The connection.</param>
        /// <param name="tablename">The tablename.</param>
        /// <param name="tschma">The tschma.</param>
        /// <returns></returns>
        private TableSchema CreateTableSchema( SqlConnection conn, string tablename, string tschma )
        {
            var res = new TableSchema
            {
                TableName = tablename,
                TableSchemaName = tschma,
                Columns = new List<ColumnSchema>( )
            };

            using( var _command = new SqlCommand(
                      @"SELECT COLUMNNAME, COLUMNDEFAULT, ISNULLABLE,DATATYPE,  (columnproperty(objectid(TABLENAME), COLUMNNAME, 'IsIdentity')) A[IDENT], "
                      + @"CHARACTERMAXIMUMLENGTH AS CSIZE FROM INFORMATIONSCHEMA.COLUMNS WHERE TABLENAME = '{tablename}' ORDER BY ORDINALPOSITION ASC",
                      conn ) )
            {
                var _reader = _command.ExecuteReader( );
                while( _reader.Read( ) )
                {
                    var _tmp = _reader[ "COLUMNNAME" ];
                    if( _tmp is DBNull )
                    {
                        continue;
                    }

                    var _columnName = (string)_reader[ "COLUMNNAME" ];
                    _tmp = _reader[ "COLUMNDEFAULT" ];
                    var _columnDefault = true & _tmp is DBNull
                        ? string.Empty
                        : (string)_tmp;

                    _tmp = _reader[ "ISNULLABLE" ];
                    var _isNullable = (string)_tmp == "YES";
                    var _dataType = (string)_reader[ "DATATYPE" ];
                    var _isIdentity = false;
                    if( _reader[ "IDENT" ] != DBNull.Value )
                    {
                        if( (int)_reader[ "IDENT" ] == 1 )
                        {
                            _isIdentity = true;
                        }
                    }

                    var _length = _reader[ "CSIZE" ] != DBNull.Value
                        ? Convert.ToInt32( _reader[ "CSIZE" ] )
                        : 0;

                    ValidateDataType( _dataType );
                    switch( _dataType )
                    {
                        case "timestamp":
                        {
                            _dataType = "blob";
                            break;
                        }

                        case "datetime":
                        case "smalldatetime":
                        case "date":
                        case "datetime2":
                        case "time":
                        {
                            _dataType = "datetime";
                            break;
                        }

                        case "decimal":
                        case "money":
                        case "smallmoney":
                        {
                            _dataType = "numeric";
                            break;
                        }

                        case "binary":
                        case "varbinary":
                        case "image":
                        {
                            _dataType = "blob";
                            break;
                        }

                        case "tinyint":
                        {
                            _dataType = "smallint";
                            break;
                        }

                        case "bigint":
                        {
                            _dataType = "integer";
                            break;
                        }

                        case "sqlvariant":
                        {
                            _dataType = "blob";
                            break;
                        }

                        case "xml":
                        {
                            _dataType = "varchar";
                            break;
                        }

                        case "uniqueidentifier":
                        {
                            _dataType = "guid";
                            break;
                        }

                        case "ntext":
                        {
                            _dataType = "text";
                            break;
                        }

                        case "nchar":
                        {
                            _dataType = "char";
                            break;
                        }
                    }

                    if( _dataType == "bit"
                       || _dataType == "int" )
                    {
                    }

                    _columnDefault = FixDefaultValueString( _columnDefault );
                    var _schema = new ColumnSchema
                    {
                        ColumnName = _columnName,
                        ColumnType = _dataType,
                        Length = _length,
                        IsNullable = _isNullable,
                        IsIdentity = _isIdentity,
                        DefaultValue = AdjustDefaultValue( _columnDefault )
                    };

                    res.Columns.Add( _schema );
                }
            }

            using( var cmd2 = new SqlCommand( $"EXEC sppkeys '{tablename}'", conn ) )
            {
                var reader = cmd2.ExecuteReader( );
                res.PrimaryKey = new List<string>( );
                while( reader.Read( ) )
                {
                    var _item = (string)reader[ "COLUMNNAME" ];
                    res.PrimaryKey.Add( _item );
                }
            }

            using( var cmd4 =
                  new SqlCommand( @"EXEC sptablecollations '" + tschma + "." + tablename + "'",
                      conn ) )
            {
                var reader = cmd4.ExecuteReader( );
                while( reader.Read( ) )
                {
                    bool? _isCaseSensitive = null;
                    var _columnName = (string)reader[ "name" ];
                    if( reader[ "tdscollation" ] != DBNull.Value )
                    {
                        var mask = (byte[ ])reader[ "tdscollation" ];
                        _isCaseSensitive = ( mask[ 2 ] & 0x10 ) == 0;
                    }

                    if( _isCaseSensitive.HasValue )
                    {
                        foreach( var csc in res.Columns )
                        {
                            if( csc.ColumnName == _columnName )
                            {
                                csc.IsCaseSensitive = _isCaseSensitive;
                                break;
                            }
                        }
                    }
                }
            }

            try
            {
                var _command =
                    new SqlCommand( @"exec sphelpindex '" + tschma + "." + tablename + "'", conn );

                var _reader = _command.ExecuteReader( );
                res.Indexes = new List<IndexSchema>( );
                while( _reader.Read( ) )
                {
                    var _indexName = (string)_reader[ "indexname" ];
                    var _desc = (string)_reader[ "indexdescription" ];
                    var _indexes = (string)_reader[ "indexkeys" ];
                    if( _desc.Contains( "primary key" ) )
                    {
                        continue;
                    }

                    var index = BuildIndexSchema( _indexName, _desc, _indexes );
                    res.Indexes.Add( index );
                }
            }
            catch( Exception )
            {
                _log.Warn( "failed to read index information for table [" + tablename + "]" );
            }

            return res;
        }

        /// <summary>
        /// Validates the type of the Data.
        /// </summary>
        /// <param name="dataType">The datatype.</param>
        /// <exception cref="ApplicationException">Validation failed for Data type [" +
        /// datatype + "]</exception>
        private void ValidateDataType( string dataType )
        {
            if( dataType == "int"
               || dataType == "smallint"
               || dataType == "bit"
               || dataType == "float"
               || dataType == "real"
               || dataType == "nvarchar"
               || dataType == "varchar"
               || dataType == "timestamp"
               || dataType == "varbinary"
               || dataType == "image"
               || dataType == "text"
               || dataType == "ntext"
               || dataType == "bigint"
               || dataType == "char"
               || dataType == "numeric"
               || dataType == "binary"
               || dataType == "smalldatetime"
               || dataType == "smallmoney"
               || dataType == "money"
               || dataType == "tinyint"
               || dataType == "uniqueidentifier"
               || dataType == "xml"
               || dataType == "sqlvariant"
               || dataType == "datetime2"
               || dataType == "date"
               || dataType == "time"
               || dataType == "decimal"
               || dataType == "nchar"
               || dataType == "datetime" )
            {
                return;
            }

            throw new ApplicationException( "Validation failed for Data type [" + dataType + "]" );
        }

        /// <summary>
        /// Fixes the default value string.
        /// </summary>
        /// <param name="columnDefault">The coldefault.</param>
        /// <returns></returns>
        private string FixDefaultValueString( string columnDefault )
        {
            var _replaced = false;
            var _res = columnDefault.Trim( );
            var _first = -1;
            var _last = -1;
            for( var i = 0; i < _res.Length; i++ )
            {
                if( _res[ i ] == '\''
                   && _first == -1 )
                {
                    _first = i;
                }

                if( _res[ i ] == '\''
                   && _first != -1
                   && i > _last )
                {
                    _last = i;
                }
            }

            if( _first != -1
               && _last > _first )
            {
                return _res.Substring( _first, _last - _first + 1 );
            }

            var sb = new StringBuilder( );
            for( var i = 0; i < _res.Length; i++ )
            {
                if( _res[ i ] != '('
                   && _res[ i ] != ')' )
                {
                    sb.Append( _res[ i ] );
                    _replaced = true;
                }
            }

            return _replaced
                ? "(" + sb + ")"
                : sb.ToString( );
        }

        /// <summary>
        /// Creates the foreign key schema.
        /// </summary>
        /// <param name="conn">The connection.</param>
        /// <param name="ts">The ts.</param>
        private void CreateForeignKeySchema( SqlConnection conn, TableSchema ts )
        {
            ts.ForeignKeys = new List<ForeignKeySchema>( );
            var cmd = new SqlCommand(
                $@"SELECT   ColumnName = CU.COLUMNNAME,   ForeignTableName  = PK.TABLENAME,   ForeignColumnName = PT.COLUMNNAME,   DeleteRule = C.DELETERULE,   IsNullable = COL.ISNULLABLE FROM INFORMATIONSCHEMA.REFERENTIALCONSTRAINTS C INNER JOIN INFORMATIONSCHEMA.TABLECONSTRAINTS FK ON C.CONSTRAINTNAME = FK.CONSTRAINTNAME INNER JOIN INFORMATIONSCHEMA.TABLECONSTRAINTS PK ON C.UNIQUECONSTRAINTNAME = PK.CONSTRAINTNAME INNER JOIN INFORMATIONSCHEMA.KEYCOLUMNUSAGE CU ON C.CONSTRAINTNAME = CU.CONSTRAINTNAME INNER JOIN   (     SELECT i1.TABLENAME, i2.COLUMNNAME     FROM  INFORMATIONSCHEMA.TABLECONSTRAINTS i1     INNER JOIN INFORMATIONSCHEMA.KEYCOLUMNUSAGE i2 ON i1.CONSTRAINTNAME = i2.CONSTRAINTNAME     WHERE i1.CONSTRAINTTYPE = 'PRIMARY KEY'   ) PT ON PT.TABLENAME = PK.TABLENAME INNER JOIN INFORMATIONSCHEMA.COLUMNS AS COL ON CU.COLUMNNAME = COL.COLUMNNAME AND FK.TABLENAME = COL.TABLENAME WHERE FK.TableNAME='{
                    ts.TableName
                }'", conn );

            var reader = cmd.ExecuteReader( );
            while( reader.Read( ) )
            {
                var fkc = new ForeignKeySchema
                {
                    ColumnName = (string)reader[ "ColumnName" ],
                    ForeignTableName = (string)reader[ "ForeignTableName" ],
                    ForeignColumnName = (string)reader[ "ForeignColumnName" ],
                    CascadeOnDelete = (string)reader[ "DeleteRule" ] == "CASCADE",
                    IsNullable = (string)reader[ "IsNullable" ] == "YES",
                    TableName = ts.TableName
                };

                ts.ForeignKeys.Add( fkc );
            }
        }

        /// <summary>
        /// Builds the index schema.
        /// </summary>
        /// <param name="indexname">The indexname.</param>
        /// <param name="desc">The desc.</param>
        /// <param name="keys">The keys.</param>
        /// <returns></returns>
        /// <exception cref="ApplicationException">Illegal key name [" + p + "] in
        /// index [" + indexname + "]</exception>
        private IndexSchema BuildIndexSchema( string indexname, string desc, string keys )
        {
            var res = new IndexSchema
            {
                IndexName = indexname
            };

            var descparts = desc.Split( ',' );
            for( var i = 0; i < descparts.Length; i++ )
            {
                var p = descparts[ i ];
                if( p.Trim( ).Contains( "unique" ) )
                {
                    res.IsUnique = true;
                    break;
                }
            }

            res.Columns = new List<IndexColumn>( );
            var keysparts = keys.Split( ',' );
            foreach( var p in keysparts )
            {
                var m = _keys.Match( p.Trim( ) );
                if( !m.Success )
                {
                    throw new ApplicationException( "Illegal key name [" + p + "] in index ["
                        + indexname + "]" );
                }

                var ic = new IndexColumn( );
                res.Columns.Add( ic );
            }

            return res;
        }

        /// <summary>
        /// Adjusts the default value.
        /// </summary>
        /// <param name="val">The value.</param>
        /// <returns></returns>
        private string AdjustDefaultValue( string val )
        {
            if( string.IsNullOrEmpty( val ) )
            {
                return val;
            }

            var m = _value.Match( val );
            return m.Success
                ? m.Groups[ 1 ].Value
                : val;
        }

        /// <summary>
        /// Creates the sq lite connection string.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        private string CreateSQLiteConnectionString( string path, string password )
        {
            var _builder = new SQLiteConnectionStringBuilder
            {
                DataSource = path
            };

            if( password != null )
            {
                _builder.Password = password;
            }

            _builder.PageSize = 4096;
            _builder.UseUTF16Encoding = true;
            var _connectionString = _builder.ConnectionString;
            return _connectionString;
        }

        /// <summary>
        /// Adds the triggers for foreign keys.
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="schema">The schema.</param>
        /// <param name="passWord">The password.</param>
        private void AddTriggersForForeignKeys( string path, IEnumerable<TableSchema> schema,
            string passWord )
        {
            var _connectionString = CreateSQLiteConnectionString( path, passWord );
            using( var _connection = new SQLiteConnection( _connectionString ) )
            {
                _connection.Open( );
                foreach( var _item in schema )
                {
                    try
                    {
                        AddTableTriggers( _connection, _item );
                    }
                    catch( Exception ex )
                    {
                        _log.Error( "AddTableTriggers failed", ex );
                        throw;
                    }
                }
            }

            _log.Debug( "finished adding triggers to schema" );
        }

        /// <summary>
        /// Adds the table triggers.
        /// </summary>
        /// <param name="conn">The connection.</param>
        /// <param name="dt">The dt.</param>
        private void AddTableTriggers( SQLiteConnection conn, TableSchema dt )
        {
            var _triggers = TriggerBuilder.GetForeignKeyTriggers( dt );
            for( var i = 0; i < _triggers.Count; i++ )
            {
                var _trigger = _triggers[ i ];
                var _command = new SQLiteCommand( WriteTriggerSchema( _trigger ), conn );
                _command.ExecuteNonQuery( );
            }
        }
    }
}