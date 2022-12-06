// <copyright file = "CommandBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SqlServerCe;
    using System.Data.SQLite;
    using System.Diagnostics.CodeAnalysis;

    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    public class CommandBase
    {
        /// <summary>
        /// The command
        /// </summary>
        public DbCommand Command { get; set; }

        /// <summary>
        /// The connection builder
        /// </summary>
        public IConnectionBuilder ConnectionBuilder { get; set; }

        /// <summary>
        /// The provider
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the type of the command.
        /// </summary>
        /// <value>
        /// The type of the command.
        /// </value>
        public SQL CommandType { get; set; }

        /// <summary>
        /// The SQL statement
        /// </summary>
        public ISqlStatement SqlStatement { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBase"/> class.
        /// </summary>
        public CommandBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        /// <param name="commandType">Type of the command.</param>
        public CommandBase( Source source, Provider provider, string sqlText,
            SQL commandType )
        {
            Source = source;
            Provider = provider;
            CommandType = commandType;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            SqlStatement = new SqlStatement( source, provider, sqlText, commandType );
            Command = GetCommand( SqlStatement );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        public CommandBase( Source source, Provider provider, IDictionary<string, object> where,
            SQL commandType = SQL.SELECTALL )
        {
            Source = source;
            Provider = provider;
            CommandType = commandType;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            SqlStatement = new SqlStatement( source, provider, where, commandType );
            Command = GetCommand( SqlStatement );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="updates">The updates.</param>
        /// <param name="where">The criteria.</param>
        /// <param name="commandType">Type of the command.</param>
        public CommandBase( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
        {
            Source = source;
            Provider = provider;
            CommandType = commandType;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            SqlStatement = new SqlStatement( source, provider, updates, where, commandType );
            Command = GetCommand( SqlStatement );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The criteria.</param>
        /// <param name="commandType">Type of the command.</param>
        public CommandBase( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
        {
            Source = source;
            Provider = provider;
            CommandType = commandType;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            SqlStatement = new SqlStatement( source, provider, columns, where, commandType );
            Command = GetCommand( SqlStatement );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBase"/> class.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        public CommandBase( ISqlStatement sqlStatement )
        {
            SqlStatement = sqlStatement;
            Source = sqlStatement.Source;
            Provider = sqlStatement.Provider;
            CommandType = sqlStatement.CommandType;
            ConnectionBuilder = new ConnectionBuilder( sqlStatement.Source, sqlStatement.Provider );
            Command = GetCommand( SqlStatement );
        }

        /// <summary>
        /// Sets the command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetCommand( ISqlStatement sqlStatement )
        {
            if( Enum.IsDefined( typeof( Provider ), sqlStatement.Provider ) )
            {
                try
                {
                    switch( sqlStatement.Provider )
                    {
                        case Provider.SQLite:
                        {
                            return GetSQLiteCommand( sqlStatement );
                        }
                        case Provider.SqlCe:
                        {
                            return GetSQLiteCommand( sqlStatement );
                        }
                        case Provider.SqlServer:
                        {
                            return GetSQLiteCommand( sqlStatement );
                        }
                        case Provider.Excel:
                        case Provider.CSV:
                        case Provider.Access:
                        case Provider.OleDb:
                        {
                            return GetOleDbCommand( sqlStatement );
                        }
                        default:
                        {
                            return default( DbCommand );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Gets the sq lite command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetSQLiteCommand( ISqlStatement sqlStatement )
        {
            if( sqlStatement != null
               && Enum.IsDefined( typeof( SQL ), sqlStatement.CommandType )
               && ConnectionBuilder?.Connection != null )
            {
                try
                {
                    var _connection = ConnectionBuilder?.Connection as SQLiteConnection;
                    switch( sqlStatement?.CommandType )
                    {
                        case SQL.SELECTALL:
                        case SQL.SELECT:
                        {
                            var _sql = sqlStatement?.GetSelectStatement( );
                            return !string.IsNullOrEmpty( _sql )
                                ? new SQLiteCommand( _sql, _connection )
                                : default( SQLiteCommand );
                        }
                        case SQL.INSERT:
                        {
                            var _sql = sqlStatement?.GetInsertQueryText( );
                            return new SQLiteCommand( _sql, _connection );
                        }
                        case SQL.UPDATE:
                        {
                            var _sql = sqlStatement?.GetUpdateQueryText( );
                            return new SQLiteCommand( _sql, _connection );
                        }
                        case SQL.DELETE:
                        {
                            var _sql = sqlStatement?.GetDeleteQueryText( );
                            return new SQLiteCommand( _sql, _connection );
                        }
                        default:
                        {
                            var _sql = sqlStatement?.GetSelectStatement( );
                            return new SQLiteCommand( _sql, _connection );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Gets the SQL ce command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetSqlCeCommand( ISqlStatement sqlStatement )
        {
            if( sqlStatement != null
               && Enum.IsDefined( typeof( SQL ), sqlStatement.CommandType )
               && ConnectionBuilder?.Connection != null )
            {
                try
                {
                    if( ConnectionBuilder.Connection is SqlCeConnection _connection
                       && !string.IsNullOrEmpty( _connection?.ConnectionString ) )
                    {
                        switch( sqlStatement?.CommandType )
                        {
                            case SQL.SELECTALL:
                            case SQL.SELECT:
                            {
                                var _sql = sqlStatement?.GetSelectStatement( );
                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCeCommand( _sql, _connection )
                                    : default( DbCommand );
                            }
                            case SQL.INSERT:
                            {
                                var _sql = sqlStatement?.GetInsertQueryText( );
                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCeCommand( _sql, _connection )
                                    : default( DbCommand );
                            }
                            case SQL.UPDATE:
                            {
                                var _sql = sqlStatement?.GetUpdateQueryText( );
                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCeCommand( _sql, _connection )
                                    : default( DbCommand );
                            }
                            case SQL.DELETE:
                            {
                                var _sql = sqlStatement?.GetDeleteQueryText( );
                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCeCommand( _sql, _connection )
                                    : default( DbCommand );
                            }
                            default:
                            {
                                var _sql = sqlStatement?.GetSelectStatement( );
                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCeCommand( _sql, _connection )
                                    : default( DbCommand );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Gets the SQL command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetSqlCommand( ISqlStatement sqlStatement )
        {
            if( sqlStatement != null
               && Enum.IsDefined( typeof( SQL ), sqlStatement.CommandType )
               && ConnectionBuilder?.Connection != null )
            {
                try
                {
                    var _connection = ConnectionBuilder?.Connection as SqlConnection;
                    using( _connection )
                    {
                        switch( sqlStatement?.CommandType )
                        {
                            case SQL.SELECTALL:
                            case SQL.SELECT:
                            {
                                var _sql = sqlStatement?.GetSelectStatement( );
                                return new SqlCommand( _sql, _connection );
                            }
                            case SQL.INSERT:
                            {
                                var _sql = sqlStatement?.GetInsertQueryText( );
                                return new SqlCommand( _sql, _connection );
                            }
                            case SQL.UPDATE:
                            {
                                var _sql = sqlStatement?.GetUpdateQueryText( );
                                return new SqlCommand( _sql, _connection );
                            }
                            case SQL.DELETE:
                            {
                                var _sql = sqlStatement?.GetDeleteQueryText( );
                                return new SqlCommand( _sql, _connection );
                            }
                            default:
                            {
                                var _sql = sqlStatement?.GetSelectStatement( );
                                return new SqlCommand( _sql, _connection );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Gets the OLE database command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetOleDbCommand( ISqlStatement sqlStatement )
        {
            if( sqlStatement != null
               && Enum.IsDefined( typeof( SQL ), sqlStatement.CommandType )
               && ConnectionBuilder?.Connection != null )
            {
                try
                {
                    var _connection = ConnectionBuilder?.Connection as OleDbConnection;
                    switch( sqlStatement?.CommandType )
                    {
                        case SQL.SELECTALL:
                        case SQL.SELECT:
                        {
                            var _sql = sqlStatement?.GetSelectStatement( );
                            return new OleDbCommand( _sql, _connection );
                        }

                        case SQL.INSERT:
                        {
                            var _sql = sqlStatement?.GetInsertQueryText( );
                            return new OleDbCommand( _sql, _connection );
                        }

                        case SQL.UPDATE:
                        {
                            var _sql = sqlStatement.GetUpdateQueryText( );
                            return new OleDbCommand( _sql, _connection );
                        }

                        case SQL.DELETE:
                        {
                            var _sql = sqlStatement?.GetDeleteQueryText( );
                            return new OleDbCommand( _sql, _connection );
                        }

                        default:
                        {
                            var _sql = sqlStatement?.GetSelectStatement( );
                            return new OleDbCommand( _sql, _connection );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}