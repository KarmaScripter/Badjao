//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// </summary>
    /// <seealso cref = "IDisposable"/>
    public class Query : QueryBase, IQuery
    {
        /// <summary>
        /// Initializes a new instance of the <see cref = "Query"/> class.
        /// </summary>
        public Query( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Query"/> class.
        /// </summary>
        /// <param name = "source" >
        /// The source.
        /// </param>
        /// <param name = "provider" >
        /// The provider.
        /// </param>
        /// <param name = "commandType" >
        /// The commandType.
        /// </param>
        public Query( Source source, Provider provider = Provider.Access,
            SQL commandType = SQL.SELECTALL )
            : base( source, provider, commandType )
        {
            Source = source;
            Provider = provider;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            DataConnection = ConnectionBuilder.Connection;
            SqlStatement = new SqlStatement( source, provider, commandType );
            CommandBuilder = new CommandBuilder( SqlStatement );
            DataCommand = CommandBuilder.GetCommand( SqlStatement );
            DataAdapter = new AdapterBuilder( CommandBuilder ).GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Query"/> class.
        /// </summary>
        /// <param name = "source" >
        /// The source Data.
        /// </param>
        /// <param name = "provider" >
        /// The provider used.
        /// </param>
        /// <param name = "where" >
        /// The dictionary of parameters.
        /// </param>
        /// <param name = "commandType" >
        /// The type of sql command.
        /// </param>
        public Query( Source source, Provider provider, IDictionary<string, object> where,
            SQL commandType )
            : base( source, provider, where, commandType )
        {
            Source = source;
            Provider = provider;
            Criteria = where;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            DataConnection = ConnectionBuilder.Connection;
            SqlStatement = new SqlStatement( source, provider, where, commandType );
            CommandBuilder = new CommandBuilder( SqlStatement );
            DataCommand = CommandBuilder.GetCommand( SqlStatement );
            DataAdapter = new AdapterBuilder( CommandBuilder ).GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Query"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name = "updates" > </param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public Query( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
            : base( source, provider, updates, where, commandType )
        {
            Source = source;
            Provider = provider;
            Criteria = where;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            DataConnection = ConnectionBuilder.Connection;
            SqlStatement = new SqlStatement( source, provider, updates, where, commandType );
            CommandBuilder = new CommandBuilder( SqlStatement );
            DataCommand = CommandBuilder.GetCommand( SqlStatement );
            DataAdapter = new AdapterBuilder( CommandBuilder ).GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Query"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The criteria.</param>
        /// <param name="commandType">Type of the command.</param>
        public Query( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
            : base( source, provider, columns, where, commandType )
        {
            Source = source;
            Provider = provider;
            Criteria = where;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            DataConnection = ConnectionBuilder.Connection;
            SqlStatement = new SqlStatement( source, provider, columns, where, commandType );
            CommandBuilder = new CommandBuilder( SqlStatement );
            DataCommand = CommandBuilder.GetCommand( SqlStatement );
            DataAdapter = new AdapterBuilder( CommandBuilder ).GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Query"/> class.
        /// </summary>
        /// <param name = "sqlStatement" >
        /// The sqlStatement.
        /// </param>
        public Query( ISqlStatement sqlStatement )
            : base( sqlStatement.Source, sqlStatement.Provider, sqlStatement )
        {
            Source = sqlStatement.Source;
            Provider = sqlStatement.Provider;
            Criteria = sqlStatement.Criteria;
            ConnectionBuilder = new ConnectionBuilder( Source, Provider );
            DataConnection = ConnectionBuilder.Connection;
            SqlStatement = sqlStatement;
            CommandBuilder = new CommandBuilder( sqlStatement );
            DataCommand = CommandBuilder.GetCommand( sqlStatement );
            DataAdapter = new AdapterBuilder( CommandBuilder ).GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Query"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        public Query( Source source, Provider provider, string sqlText )
            : base( source, provider, sqlText )
        {
            Source = source;
            Provider = provider;
            ConnectionBuilder = new ConnectionBuilder( Source, Provider );
            DataConnection = ConnectionBuilder.Connection;
            SqlStatement = new SqlStatement( source, provider, sqlText );
            DataCommand = CommandBuilder.GetCommand( SqlStatement );
            DataAdapter = new AdapterBuilder( CommandBuilder ).GetAdapter( );
            IsDisposed = false;
            Criteria = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Query"/> class.
        /// </summary>
        /// <param name = "source" >
        /// The source.
        /// </param>
        /// <param name = "provider" >
        /// The provider.
        /// </param>
        /// <param name = "where" >
        /// The dictionary.
        /// </param>
        public Query( Source source, Provider provider, IDictionary<string, object> where )
            : base( source, provider, where )
        {
            Source = source;
            Provider = provider;
            Criteria = where;
            ConnectionBuilder = new ConnectionBuilder( Source, Provider );
            DataConnection = ConnectionBuilder.Connection;
            SqlStatement = new SqlStatement( source, provider, where );
            DataCommand = CommandBuilder.GetCommand( SqlStatement );
            DataAdapter = new AdapterBuilder( CommandBuilder ).GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Query"/> class.
        /// </summary>
        /// <param name = "fullPath" >
        /// The fullpath.
        /// </param>
        /// <param name = "sqlText" > </param>
        /// <param name = "commandType" >
        /// The commandType.
        /// </param>
        public Query( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
            : base( fullPath, sqlText, commandType )
        {
            Criteria = null;
            ConnectionBuilder = new ConnectionBuilder( fullPath );
            Provider = ConnectionBuilder.Provider;
            Source = ConnectionBuilder.Source;
            DataConnection = ConnectionBuilder.Connection;

            SqlStatement = new SqlStatement( ConnectionBuilder.Source, ConnectionBuilder.Provider,
                sqlText );

            CommandBuilder = new CommandBuilder( SqlStatement );
            DataCommand = CommandBuilder.GetCommand( SqlStatement );
            DataAdapter = new AdapterBuilder( CommandBuilder ).GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Query"/> class.
        /// </summary>
        /// <param name = "fullPath" >
        /// The fullpath.
        /// </param>
        /// <param name = "commandType" >
        /// The commandType.
        /// </param>
        /// <param name = "where" >
        /// The dictionary.
        /// </param>
        public Query( string fullPath, SQL commandType, IDictionary<string, object> where )
            : base( fullPath, commandType, where )
        {
            Criteria = where;
            ConnectionBuilder = new ConnectionBuilder( fullPath );
            Source = ConnectionBuilder.Source;
            Provider = ConnectionBuilder.Provider;
            DataConnection = ConnectionBuilder.Connection;
            SqlStatement = new SqlStatement( Source, Provider, where, commandType );
            CommandBuilder = new CommandBuilder( SqlStatement );
            DataCommand = CommandBuilder.GetCommand( SqlStatement );
            DataAdapter = new AdapterBuilder( CommandBuilder ).GetAdapter( );
            IsDisposed = false;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or
        /// resetting unmanaged resources.
        /// </summary>
        public virtual void Dispose( )
        {
            try
            {
                Dispose( true );
                GC.SuppressFinalize( this );
            }
            catch( Exception ex )
            {
                IsDisposed = false;
                Fail( ex );
            }
        }

        /// <inheritdoc/>
        /// <summary>
        /// Sets the Data reader.
        /// </summary>
        /// <param name = "behavior" >
        /// The behavior.
        /// </param>
        /// <returns>
        /// </returns>
        public DbDataReader GetDataReader(
            CommandBehavior behavior = CommandBehavior.CloseConnection )
        {
            if( DataConnection != null
               && !string.IsNullOrEmpty( DataCommand?.CommandText )
               && Enum.IsDefined( typeof( CommandBehavior ), behavior ) )
            {
                try
                {
                    if( DataCommand.Connection?.State != ConnectionState.Open )
                    {
                        DataCommand.Connection?.Open( );
                        return DataCommand.ExecuteReader( CommandBehavior.CloseConnection );
                    }

                    if( DataCommand.Connection?.State == ConnectionState.Open )
                    {
                        return DataCommand.ExecuteReader( CommandBehavior.CloseConnection );
                    }
                }
                catch( Exception ex )
                {
                    if( DataCommand.Connection?.State == ConnectionState.Open )
                    {
                        DataCommand.Connection?.Close( );
                    }

                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name = "disposing" >
        /// <c>
        /// true
        /// </c>
        /// to release both managed and unmanaged resources;
        /// <c>
        /// false
        /// </c>
        /// to release only unmanaged resources.
        /// </param>
        protected virtual void Dispose( bool disposing )
        {
            if( ConnectionFactory?.Connection != null )
            {
                try
                {
                    ConnectionFactory?.Connection?.Close( );
                    ConnectionFactory?.Connection?.Dispose( );
                    IsDisposed = true;
                }
                catch( Exception ex )
                {
                    IsDisposed = false;
                    Fail( ex );
                }
            }
        }
    }
}