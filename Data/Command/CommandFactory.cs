// <copyright file = "CommandFactory.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Data.SqlServerCe;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ICommandFactory" />
    public class CommandFactory : CommandBuilder
    {
        /// <summary>
        /// Gets or sets the connection.
        /// </summary>
        /// <value>
        /// The connection.
        /// </value>
        public DbConnection Connection { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandFactory"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where">The dictionary.</param>
        public CommandFactory( Source source, Provider provider, IDictionary<string, object> where )
            : base( source, provider, where )
        {
            Source = source;
            Provider = provider;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            Connection = ConnectionBuilder.Connection;
            SqlStatement = new SqlStatement( source, provider, where );
            Command = GetCommand( SqlStatement );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandFactory"/> class.
        /// </summary>
        /// <param name="commandBuilder">The command builder.</param>
        public CommandFactory( ICommandBuilder commandBuilder )
        {
            Source = commandBuilder.Source;
            Provider = commandBuilder.Provider;
            ConnectionBuilder = commandBuilder.ConnectionBuilder;
            Connection = ConnectionBuilder.Connection;
            SqlStatement = commandBuilder.SqlStatement;
            Command = commandBuilder.Command;
        }

        /// <summary>
        /// Gets the create table command.
        /// </summary>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="dataColumns">The Data columns.</param>
        /// <returns></returns>
        public DbCommand GetCreateTableCommand( string tableName,
            IEnumerable<DataColumn> dataColumns )
        {
            if( !string.IsNullOrEmpty( tableName )
               && dataColumns?.Any( ) == true )
            {
                try
                {
                    var _sql = $"CREATE TABLE {tableName}";
                    if( Enum.IsDefined( typeof( Provider ), Provider )
                       && !string.IsNullOrEmpty( _sql ) )
                    {
                        switch( Provider )
                        {
                            case Provider.SQLite:
                            {
                                return !string.IsNullOrEmpty( _sql )
                                    ? new SQLiteCommand( _sql )
                                    : default( SQLiteCommand );
                            }

                            case Provider.SqlCe:
                            {
                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCeCommand( _sql )
                                    : default( SqlCeCommand );
                            }

                            case Provider.SqlServer:
                            {
                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCommand( _sql )
                                    : default( SqlCommand );
                            }

                            case Provider.Excel:
                            case Provider.CSV:
                            case Provider.Access:
                            case Provider.OleDb:
                            {
                                return !string.IsNullOrEmpty( _sql )
                                    ? new OleDbCommand( _sql )
                                    : default( OleDbCommand );
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
        /// Gets the create view command.
        /// </summary>
        /// <param name="viewName">Name of the view.</param>
        /// <param name="dataColumns">The Data columns.</param>
        /// <returns></returns>
        public DbCommand GetCreateViewCommand( string viewName,
            IEnumerable<DataColumn> dataColumns )
        {
            if( !string.IsNullOrEmpty( viewName )
               && dataColumns?.Any( ) == true
               && ConnectionBuilder != null
               && ConnectionBuilder.Provider != Provider.SqlCe )
            {
                try
                {
                    var _sql = $"CREATE VIEW {viewName};";
                    switch( Provider )
                    {
                        case Provider.SQLite:
                        {
                            return !string.IsNullOrEmpty( _sql )
                                ? new SQLiteCommand( _sql )
                                : default( SQLiteCommand );
                        }

                        case Provider.SqlServer:
                        {
                            return !string.IsNullOrEmpty( _sql )
                                ? new SqlCommand( _sql )
                                : default( SqlCommand );
                        }

                        case Provider.Excel:
                        case Provider.CSV:
                        case Provider.Access:
                        case Provider.OleDb:
                        {
                            return !string.IsNullOrEmpty( _sql )
                                ? new OleDbCommand( _sql )
                                : default( OleDbCommand );
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
        /// Gets the drop table command.
        /// </summary>
        /// <param name="dataTable">The Data table.</param>
        /// <returns></returns>
        public DbCommand GetDropTableCommand( DataTable dataTable )
        {
            if( dataTable != null
               && ConnectionBuilder != null )
            {
                try
                {
                    var _sql = $"DROP TABLE {dataTable.TableName};";
                    if( !string.IsNullOrEmpty( _sql )
                       && Enum.IsDefined( typeof( Provider ), Provider ) )
                    {
                        switch( Provider )
                        {
                            case Provider.SQLite:
                            {
                                return !string.IsNullOrEmpty( _sql )
                                    ? new SQLiteCommand( _sql )
                                    : default( SQLiteCommand );
                            }

                            case Provider.SqlCe:
                            {
                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCeCommand( _sql )
                                    : default( SqlCeCommand );
                            }

                            case Provider.SqlServer:
                            {
                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCommand( _sql )
                                    : default( SqlCommand );
                            }

                            case Provider.Excel:
                            case Provider.CSV:
                            case Provider.Access:
                            case Provider.OleDb:
                            {
                                return !string.IsNullOrEmpty( _sql )
                                    ? new OleDbCommand( _sql )
                                    : default( OleDbCommand );
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
        /// Gets the alter command.
        /// </summary>
        /// <param name="dataTable">The Data table.</param>
        /// <param name="dataColumn">The Data column.</param>
        /// <returns></returns>
        public DbCommand GetAddColumnCommand( DataTable dataTable, DataColumn dataColumn )
        {
            if( dataTable != null
               && dataColumn != null
               && ConnectionBuilder != null )
            {
                try
                {
                    var _sql =
                        $"ALTER TABLE {dataTable.TableName} ADD COLUMN {dataColumn.ColumnName};";

                    if( !string.IsNullOrEmpty( _sql )
                       && Enum.IsDefined( typeof( Provider ), Provider ) )
                    {
                        switch( Provider )
                        {
                            case Provider.SQLite:
                            {
                                return !string.IsNullOrEmpty( _sql )
                                    ? new SQLiteCommand( _sql )
                                    : default( SQLiteCommand );
                            }

                            case Provider.SqlCe:
                            {
                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCeCommand( _sql )
                                    : default( SqlCeCommand );
                            }

                            case Provider.SqlServer:
                            {
                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCommand( _sql )
                                    : default( SqlCommand );
                            }

                            case Provider.Excel:
                            case Provider.CSV:
                            case Provider.Access:
                            case Provider.OleDb:
                            {
                                return !string.IsNullOrEmpty( _sql )
                                    ? new OleDbCommand( _sql )
                                    : default( OleDbCommand );
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
        /// Gets the alter command.
        /// </summary>
        /// <param name="dataTable">The Data table.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public DbCommand GetRenameTableCommand( DataTable dataTable, string name )
        {
            if( dataTable != null
               && !string.IsNullOrEmpty( name )
               && Command != null )
            {
                try
                {
                    var _sql = $"ALTER TABLE {dataTable.TableName} RENAME {name};";
                    if( Enum.IsDefined( typeof( Provider ), Provider )
                       && !string.IsNullOrEmpty( _sql ) )
                    {
                        switch( Provider )
                        {
                            case Provider.SQLite:
                            {
                                return !string.IsNullOrEmpty( _sql )
                                    ? new SQLiteCommand( _sql )
                                    : default( SQLiteCommand );
                            }

                            case Provider.SqlCe:
                            {
                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCeCommand( _sql )
                                    : default( SqlCeCommand );
                            }

                            case Provider.SqlServer:
                            {
                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCommand( _sql )
                                    : default( SqlCommand );
                            }

                            case Provider.Excel:
                            case Provider.CSV:
                            case Provider.Access:
                            case Provider.OleDb:
                            {
                                return !string.IsNullOrEmpty( _sql )
                                    ? new OleDbCommand( _sql )
                                    : default( OleDbCommand );
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
        /// Gets the select command.
        /// </summary>
        /// <returns></returns>
        public DbCommand GetSelectCommand( )
        {
            if( Enum.IsDefined( typeof( Provider ), Provider )
               && SqlStatement != null )
            {
                try
                {
                    var _sql = SqlStatement.GetSelectStatement( );
                    switch( Provider )
                    {
                        case Provider.SQLite:
                        {
                            return new SQLiteCommand( _sql );
                        }

                        case Provider.SqlCe:
                        {
                            return new SqlCeCommand( _sql );
                        }

                        case Provider.SqlServer:
                        {
                            return new SqlCommand( _sql );
                        }

                        case Provider.Excel:
                        case Provider.CSV:
                        case Provider.Access:
                        case Provider.OleDb:
                        {
                            return new OleDbCommand( _sql );
                        }

                        default:
                        {
                            return new OleDbCommand( _sql );
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
        /// Gets the insert command.
        /// </summary>
        /// <returns></returns>
        public string GetInsertCommand( )
        {
            try
            {
                return SqlStatement.GetInsertStatement( );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets the update commande.
        /// </summary>
        /// <returns></returns>
        public string GetUpdateCommand( )
        {
            try
            {
                return SqlStatement.GetUpdateStatement( );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets the delete command.
        /// </summary>
        /// <returns></returns>
        public string GetDeleteCommand( )
        {
            try
            {
                return SqlStatement.GetDeleteStatement( );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }
    }
}