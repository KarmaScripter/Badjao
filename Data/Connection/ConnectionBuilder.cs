// <copyright file = "ConnectionBuilder.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SqlServerCe;
    using System.Data.SQLite;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ConnectionBase" />
    /// <seealso cref="ISource" />
    /// <seealso cref="IProvider" />
    /// <seealso cref="IConnectionBuilder" />
    public class ConnectionBuilder : ConnectionBase, ISource, IProvider, IConnectionBuilder
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionBuilder" />
        /// class.
        /// </summary>
        public ConnectionBuilder( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionBuilder" />
        /// class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public ConnectionBuilder( Source source, Provider provider = Provider.Access )
            : base( source, provider )
        {
            Connection = GetConnection( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionBuilder" />
        /// class.
        /// </summary>
        /// <param name="fullPath">The fullPath.</param>
        public ConnectionBuilder( string fullPath )
            : base( fullPath )
        {
            Connection = GetConnection( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionBuilder" />
        /// class.
        /// </summary>
        /// <param name="fullPath">The fullPath.</param>
        /// <param name="provider">The provider.</param>
        public ConnectionBuilder( string fullPath, Provider provider = Provider.Access )
            : base( fullPath, provider )
        {
            Connection = GetConnection( );
        }

        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns></returns>
        public DbConnection GetConnection( )
        {
            if( Enum.IsDefined( typeof( Provider ), Provider ) )
            {
                try
                {
                    var _connectionString = ConnectionPath[ $"{Provider}" ]?.ConnectionString;
                    switch( Provider )
                    {
                        case Provider.SQLite:
                        {
                            return new SQLiteConnection( _connectionString );
                        }

                        case Provider.SqlCe:
                        {
                            return new SqlCeConnection( _connectionString );
                        }

                        case Provider.SqlServer:
                        {
                            return new SqlConnection( _connectionString );
                        }

                        case Provider.Excel:
                        case Provider.CSV:
                        case Provider.Access:
                        case Provider.OleDb:
                        {
                            return new OleDbConnection( _connectionString );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbConnection );
                }
            }

            return default( DbConnection );
        }
    }
}