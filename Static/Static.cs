// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Text;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public static class Static
    {
        /// <summary>
        /// Gets the type of the SQL.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public static string GetSqlType( this Type type )
        {
            try
            {
                type = Nullable.GetUnderlyingType( type ) ?? type;

                switch( type.Name )
                {
                    case "String":
                    case "Boolean":

                    {
                        return "Text";
                    }

                    case "IsDateTime":

                    {
                        return "Date";
                    }

                    case "Int32":

                    {
                        return "Double";
                    }

                    case "Decimal":

                    {
                        return "Currency";
                    }

                    default:

                    {
                        return type.Name;
                    }
                }
            }
            catch( Exception _ex )
            {
                Fail( _ex );

                return default;
            }
        }

        /// <summary>
        /// Creates the command.
        /// </summary>
        /// <param name="connection">The connection.</param>
        /// <param name="sql">The SQL.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">connection</exception>
        public static IDbCommand CreateCommand( this IDbConnection connection, string sql )
        {
            try
            {
                if( connection == null )
                {
                    throw new ArgumentNullException( nameof( connection ) );
                }

                var _command = connection?.CreateCommand( );
                _command.CommandText = sql;

                return !string.IsNullOrEmpty( _command?.CommandText )
                    ? _command
                    : default;
            }
            catch( Exception _ex )
            {
                Fail( _ex );

                return default;
            }
        }

        /// <summary>
        /// Executes the non query.
        /// </summary>
        /// <param name="connection">The connection.</param>
        /// <param name="sql">The SQL.</param>
        /// <returns></returns>
        public static int ExecuteNonQuery( this IDbConnection connection, string sql )
        {
            if ( !string.IsNullOrEmpty( sql ) )
            {
                try
                {
                    using var _command = connection?.CreateCommand( sql );

                    return _command?.ExecuteNonQuery( ) ?? 0;
                }
                catch( Exception _ex )
                {
                    Fail( _ex );

                    return default;
                }
            }

            return -1;
        }

        /// <summary>
        /// Converts to log string.
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        public static string ToLogString( this Exception ex, string message )
        {
            try
            {
                var _stringBuilder = new StringBuilder( );

                if( !string.IsNullOrEmpty( message ) )
                {
                    _stringBuilder.Append( message );
                    _stringBuilder.Append( Environment.NewLine );
                }

                if( ex != null )
                {
                    var _exception = ex;
                    _stringBuilder.Append( "Exception:" );
                    _stringBuilder.Append( Environment.NewLine );

                    while( _exception != null )
                    {
                        _stringBuilder.Append( _exception.Message );
                        _stringBuilder.Append( Environment.NewLine );
                        _exception = _exception.InnerException;
                    }

                    if( ex.Data != null )
                    {
                        foreach( var _i in ex.Data )
                        {
                            _stringBuilder.Append( "Data :" );
                            _stringBuilder.Append( _i );
                            _stringBuilder.Append( Environment.NewLine );
                        }
                    }

                    if( ex.StackTrace != null )
                    {
                        _stringBuilder.Append( "StackTrace:" );
                        _stringBuilder.Append( Environment.NewLine );
                        _stringBuilder.Append( ex.StackTrace );
                        _stringBuilder.Append( Environment.NewLine );
                    }

                    if( ex.Source != null )
                    {
                        _stringBuilder.Append( "ErrorSource:" );
                        _stringBuilder.Append( Environment.NewLine );
                        _stringBuilder.Append( ex.Source );
                        _stringBuilder.Append( Environment.NewLine );
                    }

                    if( ex.TargetSite != null )
                    {
                        _stringBuilder.Append( "TargetSite:" );
                        _stringBuilder.Append( Environment.NewLine );
                        _stringBuilder.Append( ex.TargetSite );
                        _stringBuilder.Append( Environment.NewLine );
                    }

                    var _baseException = ex.GetBaseException( );

                    if( _baseException != null )
                    {
                        _stringBuilder.Append( "BaseException:" );
                        _stringBuilder.Append( Environment.NewLine );
                        _stringBuilder.Append( ex.GetBaseException( ) );
                    }
                }

                return _stringBuilder.ToString( );
            }
            catch( Exception _e )
            {
                Fail( _e );

                return default;
            }
        }

        /// <summary>
        /// Converts to dictionary.
        /// </summary>
        /// <param name="nvm">The NVM.</param>
        /// <returns></returns>
        public static IDictionary<string, object> ToDictionary( this NameValueCollection nvm )
        {
            try
            {
                var _dictionary = new Dictionary<string, object>( );

                if( nvm != null )
                {
                    foreach( var _key in nvm.AllKeys )
                    {
                        _dictionary.Add( _key, nvm[ _key ] );
                    }
                }

                return _dictionary;
            }
            catch( Exception _ex )
            {
                Fail( _ex );

                return default;
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}