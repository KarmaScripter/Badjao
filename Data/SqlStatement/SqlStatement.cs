// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.SqlBase" />
    /// <seealso cref="BudgetExecution.ISqlStatement" />
    public class SqlStatement : SqlBase, ISqlStatement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        public SqlStatement( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        public SqlStatement( Source source, Provider provider, string sqlText )
            : base( source, provider, sqlText )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        /// <param name="commandType">Type of the command.</param>
        public SqlStatement( Source source, Provider provider, string sqlText,
            SQL commandType = SQL.SELECT )
            : base( source, provider, sqlText, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="commandType">Type of the command.</param>
        public SqlStatement( Source source, Provider provider, SQL commandType = SQL.SELECTALL )
            : base( source, provider, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where"></param>
        /// <param name="commandType"></param>
        public SqlStatement( Source source, Provider provider, IDictionary<string, object> where,
            SQL commandType = SQL.SELECTALL )
            : base( source, provider, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name = "updates" > </param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public SqlStatement( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
            : base( source, provider, updates, where, commandType )
        {
            CommandText = GetCommandText( updates, where, commandType );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <param name="where">The arguments.</param>
        public SqlStatement( Source source, Provider provider, SQL commandType,
            IDictionary<string, object> where )
            : base( source, provider, where, commandType )
        {
            CommandText = GetCommandText( where, commandType );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        public SqlStatement( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
            : base( source, provider, columns, where, commandType )
        {
            CommandText = GetCommandText( columns, where, commandType );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="aggregates">The aggregates.</param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public SqlStatement( Source source, Provider provider, IEnumerable<string> columns,
            IEnumerable<string> aggregates, IDictionary<string, object> where,
            SQL commandType = SQL.SELECT )
            : base( source, provider, columns, aggregates, where,
                commandType )
        {
            CommandText = GetCommandText( columns, where, commandType );
        }

        /// <summary>
        /// Gets the update statement.
        /// </summary>
        /// <returns></returns>
        public string GetUpdateStatement( )
        {
            if( Criteria != null
               && Updates != null )
            {
                try
                {
                    var _update = CreateUpdateStatement( Updates, Criteria );

                    return !string.IsNullOrEmpty( _update )
                        ? _update
                        : string.Empty;
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
        /// Gets the insert statement.
        /// </summary>
        /// <returns></returns>
        public string GetInsertStatement( )
        {
            try
            {
                return Updates?.Any( ) == true
                    ? CreateInsertStatement( Updates )
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );

                return default;
            }
        }

        /// <summary>
        /// Gets the delete statement.
        /// </summary>
        /// <returns></returns>
        public string GetDeleteStatement( )
        {
            try
            {
                return Criteria?.Any( ) == true
                    ? CreateDeleteStatement( Criteria )
                    : $"DELETE FROM {Source}";
            }
            catch( Exception ex )
            {
                Fail( ex );

                return default;
            }
        }

        /// <summary>
        /// Gets the command text.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns></returns>
        public string GetCommandText( IDictionary<string, object> dict,
            SQL commandType = SQL.SELECT )
        {
            if( dict?.Any( ) == true
               && Enum.IsDefined( typeof( Source ), Source ) )
            {
                try
                {
                    switch( commandType )
                    {
                        case SQL.SELECT:

                        {
                            return CreateSelectStatement( dict );
                        }

                        case SQL.SELECTALL:

                        {
                            return CreateSelectStatement( dict );
                        }

                        case SQL.INSERT:

                        {
                            return CreateInsertStatement( dict );
                        }

                        case SQL.DELETE:

                        {
                            return CreateDeleteStatement( dict );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Gets the command text.
        /// </summary>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns></returns>
        public string GetCommandText( IEnumerable<string> columns,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
        {
            if( where?.Any( ) == true
               && columns?.Any( ) == true
               && Enum.IsDefined( typeof( Source ), Source ) )
            {
                try
                {
                    switch( commandType )
                    {
                        case SQL.SELECT:

                        {
                            return GetCommandText( columns, where );
                        }

                        case SQL.SELECTALL:

                        {
                            return CreateSelectStatement( where );
                        }

                        case SQL.INSERT:

                        {
                            return CreateInsertStatement( where );
                        }

                        case SQL.DELETE:

                        {
                            return CreateDeleteStatement( where );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Gets the command text.
        /// </summary>
        /// <param name = "updates" > </param>
        /// <param name = "where" > </param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns></returns>
        public string GetCommandText( IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
        {
            if( where?.Any( ) == true
               && Enum.IsDefined( typeof( Source ), Source )
               && updates?.Any( ) == true )
            {
                try
                {
                    switch( commandType )
                    {
                        case SQL.SELECT:

                        {
                            var _cols = updates.Keys.ToList( );

                            return CreateSelectStatement( _cols, where );
                        }

                        case SQL.SELECTALL:

                        {
                            return CreateSelectStatement( where );
                        }

                        case SQL.INSERT:

                        {
                            return CreateInsertStatement( where );
                        }

                        case SQL.UPDATE:

                        {
                            return CreateUpdateStatement( updates, where );
                        }

                        case SQL.DELETE:

                        {
                            return CreateDeleteStatement( where );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString( )
        {
            try
            {
                return !string.IsNullOrEmpty( CommandText )
                    ? CommandText
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );

                return string.Empty;
            }
        }
    }
}