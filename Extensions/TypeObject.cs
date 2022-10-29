// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "CompareNonConstrainedGenericWithNull" ) ]
    public static class TypeObject
    {
        /// <summary>
        /// Converts to json.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public static string ToJson<T>( this T type )
        {
            if( type != null )
            {
                try
                {
                    var _encoding = Encoding.Default;
                    var _serializer = new DataContractJsonSerializer( typeof( T ) );
                    using var stream = new MemoryStream( );
                    _serializer.WriteObject( stream, type );
                    var json = _encoding.GetString( stream.ToArray( ) );

                    return json;
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
        /// An object extension method that serialize an object to binary.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="type">The @type to act on.</param>
        /// <returns>
        /// A string.
        /// </returns>
        public static string JavaScriptSerialize<T>( this T type )
        {
            if( type != null )
            {
                try
                {
                    var _encoding = Encoding.Default;
                    var _serializer = new DataContractJsonSerializer( typeof( T ) );
                    using var _stream = new MemoryStream( );
                    _serializer.WriteObject( _stream, type );
                    var json = _encoding.GetString( _stream.ToArray( ) );

                    return json;
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
        /// An object extension method that serialize a string to XML.
        /// </summary>
        /// <param name="type">The @type to act on.</param>
        /// <returns>
        /// The string representation of the Xml Serialization.
        /// </returns>
        public static string XmlSerialize<T>( this T type )
        {
            if( type != null )
            {
                try
                {
                    var _serializer = new XmlSerializer( type.GetType( ) );
                    using var _writer = new StringWriter( );
                    _serializer?.Serialize( _writer, type );
                    var _string = _writer?.GetStringBuilder( )?.ToString( );
                    using var _reader = new StringReader( _string );

                    return _reader?.ReadToEnd( ) ?? string.Empty;
                }
                catch( Exception ex )
                {
                    Fail( ex );

                    return default;
                }
            }

            return default;
        }

        /// <summary>Fails the specified ex.</summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}