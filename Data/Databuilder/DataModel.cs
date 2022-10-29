//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Data.OleDb;
    using System.IO;
    using BudgetExecution;
    using OfficeOpenXml;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ModelBase" />
    public class DataModel : ModelBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataModel"/> class.
        /// </summary>
        public DataModel( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public DataModel( Source source, Provider provider = Provider.Access )
        {
            Source = source;
            Provider = provider;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            SqlStatement = new SqlStatement( source, provider, SQL.SELECTALL );
            Query = new Query( SqlStatement );
            DataTable = GetDataTable( );
            DataColumns = GetDataColumns( );
            DataElements = CreateSeries( DataTable );
            Record = GetData( )?.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where">The dictionary.</param>
        public DataModel( Source source, Provider provider, IDictionary<string, object> where )
        {
            Source = source;
            Provider = provider;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            SqlStatement = new SqlStatement( source, provider, where );
            Query = new Query( SqlStatement );
            DataTable = GetDataTable( );
            DataColumns = GetDataColumns( );
            DataElements = CreateSeries( DataTable );
            Record = GetData( )?.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="updates">The updates.</param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public DataModel( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
        {
            Source = source;
            Provider = provider;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            SqlStatement = new SqlStatement( source, provider, updates, where, commandType );
            Query = new Query( SqlStatement );
            DataTable = GetDataTable( );
            DataColumns = GetDataColumns( );
            DataElements = CreateSeries( DataTable );
            Record = GetData( )?.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The criteria.</param>
        /// <param name="commandType">Type of the command.</param>
        public DataModel( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
        {
            Source = source;
            Provider = provider;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            SqlStatement = new SqlStatement( source, provider, columns, where, commandType );
            Query = new Query( SqlStatement );
            DataTable = GetDataTable( );
            DataColumns = GetDataColumns( );
            DataElements = CreateSeries( DataTable );
            Record = GetData( )?.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="where">The dictionary.</param>
        public DataModel( Source source, IDictionary<string, object> where )
        {
            Source = source;
            Provider = Provider.Access;
            ConnectionBuilder = new ConnectionBuilder( source, Provider.Access );
            SqlStatement = new SqlStatement( source, Provider.Access, where );
            Query = new Query( SqlStatement );
            DataTable = GetDataTable( );
            DataColumns = GetDataColumns( );
            DataElements = CreateSeries( DataTable );
            Record = GetData( )?.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataModel"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        public DataModel( Source source, Provider provider, string sqlText )
        {
            Source = source;
            Provider = provider;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            SqlStatement = new SqlStatement( source, provider, sqlText );
            Query = new Query( SqlStatement );
            DataTable = GetDataTable( );
            DataColumns = GetDataColumns( );
            DataElements = CreateSeries( DataTable );
            Record = GetData( )?.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataModel"/> class.
        /// </summary>
        /// <param name="fullPath">The full path.</param>
        /// <param name="sqlText">The SQL text.</param>
        /// <param name="commandType">Type of the command.</param>
        public DataModel( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
        {
            ConnectionBuilder = new ConnectionBuilder( fullPath );
            Source = ConnectionBuilder.Source;
            Provider = ConnectionBuilder.Provider;
            SqlStatement = new SqlStatement( Source, Provider, sqlText, commandType );
            Query = new Query( SqlStatement );
            DataTable = GetDataTable( );
            DataColumns = GetDataColumns( );
            DataElements = CreateSeries( DataTable );
            Record = GetData( )?.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataModel"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public DataModel( IQuery query )
        {
            Query = query;
            Source = query.Source;
            Provider = query.Provider;
            ConnectionBuilder = query.ConnectionBuilder;
            SqlStatement = query.SqlStatement;
            DataTable = GetDataTable( );
            DataColumns = GetDataColumns( );
            DataElements = CreateSeries( DataTable );
            Record = GetData( )?.FirstOrDefault( );
            Map = Record?.ToDictionary( );
        }

        /// <summary>
        /// The program elements
        /// </summary>
        public IDictionary<string, IEnumerable<string>> DataElements { get; }

        /// <summary>
        /// Gets the values.
        /// </summary>
        /// <param name="dataRows">The dataRows.</param>
        /// <param name="column">The column.</param>
        /// <returns></returns>
        public static IEnumerable<string> GetValues( IEnumerable<DataRow> dataRows, string column )
        {
            if( dataRows?.Any( ) == true
               && !string.IsNullOrEmpty( column ) )
            {
                try
                {
                    var _query = dataRows?.Select( p => p.Field<string>( column ) )?.Distinct( );

                    return _query?.Any( ) == true
                        ? _query
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Gets the values.
        /// </summary>
        /// <param name="dataRows">The dataRows.</param>
        /// <param name="name">The field.</param>
        /// <param name="value">The filter.</param>
        /// <returns></returns>
        public static IEnumerable<string> GetValues( IEnumerable<DataRow> dataRows, string name,
            string value )
        {
            if( dataRows?.Any( ) == true
               && !string.IsNullOrEmpty( name )
               && Enum.IsDefined( typeof( Field ), name )
               && !string.IsNullOrEmpty( value ) )
            {
                try
                {
                    var _query = dataRows
                        ?.Where( p => p.Field<string>( $"{ name }" ).Equals( value ) )
                        ?.Select( p => p.Field<string>( $"{ name }" ) )?.Distinct( );

                    return _query?.Any( ) == true
                        ? _query
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Gets the schema table.
        /// </summary>
        /// <param name="dataTable">The dataRows table.</param>
        /// <returns></returns>
        public static DataTable CreateSchemaTable( DataTable dataTable )
        {
            if( dataTable?.Rows?.Count > 0 )
            {
                try
                {
                    using var _reader = new DataTableReader( dataTable );
                    var _schema = _reader?.GetSchemaTable( );

                    return _schema?.Rows?.Count > 0
                        ? _schema
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Creates the table from excel.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public static DataTable CreateTableFromExcel( string filePath )
        {
            if( !string.IsNullOrEmpty( filePath )
               && File.Exists( filePath ) )
            {
                try
                {
                    var _connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
                        + filePath + ";Extended Properties='Excel 12.0;HDR=YES;IMEX=1;';";

                    using var _connection = new OleDbConnection( _connectionString );
                    _connection?.Open( );
                    using var _dataSet = new DataSet( );
                    using var _schema = _connection?.GetSchema( );
                    var _sheetName = string.Empty;

                    if( _schema != null )
                    {
                        var _dataTable = _schema?.AsEnumerable( )
                            ?.Where( r =>
                                r.Field<string>( "TABLE_NAME" ).Contains( "FilterDatabase" ) )
                            ?.Select( r => r )?.CopyToDataTable( );

                        _sheetName = _dataTable.Rows[ 0 ][ "TABLE_NAME" ].ToString( );
                    }

                    using var _command = new OleDbCommand( );
                    _command.Connection = _connection;
                    _command.CommandText = $"SELECT * FROM [ { _sheetName } ]";
                    using var _dataAdapter = new OleDbDataAdapter( _command );
                    _dataAdapter.Fill( _dataSet, "excelData" );
                    using var _table = _dataSet.Tables[ "ExcelData" ];
                    _connection.Close( );
                    return _table;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Creates the table from excel.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="header">if set to <c>true</c> [header].</param>
        /// <returns></returns>
        public static DataTable CreateTableFromExcel( string filePath, bool header = true )
        {
            if( !string.IsNullOrEmpty( filePath )
               && File.Exists( filePath ) )
            {
                try
                {
                    using var _package = new ExcelPackage( );
                    using var _stream = File.OpenRead( filePath );
                    _package.Load( _stream );
                    var _worksheet = _package?.Workbook?.Worksheets?.First( );
                    var _table = new DataTable( _worksheet?.Name );

                    if( _worksheet?.Cells != null )
                    {
                        foreach( var _firstRowCell in _worksheet?.Cells[ 1, 1, 1,
                                    _worksheet.Dimension.End.Column ] )
                        {
                            _table?.Columns?.Add( header
                                ? _firstRowCell.Text
                                : $"Column {_firstRowCell.Start.Column}" );
                        }

                        var _start = header
                            ? 2
                            : 1;

                        for( var _row = _start; _row <= _worksheet.Dimension.End.Row; _row++ )
                        {
                            var _excelRange = _worksheet.Cells[ _row, 1, _row,
                                _worksheet.Dimension.End.Column ];

                            var _dataRow = _table.Rows?.Add( );

                            foreach( var cell in _excelRange )
                            {
                                _dataRow[ cell.Start.Column - 1 ] = cell?.Text;
                            }
                        }

                        return _table?.Rows?.Count > 0
                            ? _table
                            : default;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Gets the series.
        /// </summary>
        /// <param name="dataTable">The dataRows.</param>
        /// <returns></returns>
        private static IDictionary<string, IEnumerable<string>> CreateSeries( DataTable dataTable )
        {
            if( dataTable?.Rows?.Count > 0 )
            {
                try
                {
                    var _dict = new Dictionary<string, IEnumerable<string>>( );
                    var _columns = dataTable?.Columns;
                    var _rows = dataTable?.AsEnumerable( );

                    for( var i = 0; i < _columns?.Count; i++ )
                    {
                        if( !string.IsNullOrEmpty( _columns[ i ]?.ColumnName )
                           && _columns[ i ]?.DataType == typeof( string ) )
                        {
                            _dict?.Add( _columns[ i ]?.ColumnName,
                                GetValues( _rows, _columns[ i ]?.ColumnName ) );
                        }
                    }

                    return _dict?.Any( ) == true
                        ? _dict
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }
    }
}