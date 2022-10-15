// // <copyright file = "Static.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

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
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
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
                    : default( IDbCommand );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDbCommand );
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
            try
            {
                using var _command = connection?.CreateCommand( sql );
                return _command?.ExecuteNonQuery( ) ?? 0;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( int );
            }
        }

        /// <summary>
        /// Converts to logstring.
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
                    var _orgex = ex;
                    _stringBuilder.Append( "Exception:" );
                    _stringBuilder.Append( Environment.NewLine );
                    while( _orgex != null )
                    {
                        _stringBuilder.Append( _orgex.Message );
                        _stringBuilder.Append( Environment.NewLine );
                        _orgex = _orgex.InnerException;
                    }

                    if( ex.Data != null )
                    {
                        foreach( var i in ex.Data )
                        {
                            _stringBuilder.Append( "Data :" );
                            _stringBuilder.Append( i );
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
                        _stringBuilder.Append( "ImageSource:" );
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
            catch( Exception e )
            {
                Fail( e );
                return default( string );
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
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, object> );
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        public static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}