//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    public abstract class Arg : DataUnit
    {
        /// <summary>
        /// The values
        /// </summary>
        public IEnumerable<object> Values { get; set; }

        /// <summary>
        /// The names
        /// </summary>
        public IEnumerable<string> Names { get; set; }

        /// <summary>
        /// The input
        /// </summary>
        public IDictionary<string, object> Input { get; set; }

        /// <summary>
        /// The output
        /// </summary>
        public IDictionary<string, object> Output { get; set; }

        /// <summary>
        /// Gets the values.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<object> GetValues( )
        {
            if( Output?.Any( ) == true )
            {
                try
                {
                    var _array = Output.Values?.ToArray( );
                    var _enumerable = _array?.Select( o => o );
                    var _fields = Enum.GetNames( typeof( Field ) );
                    var _list = new List<object>( );

                    if( _enumerable?.Any( ) == true
                       && _fields?.Any( ) == true )
                    {
                        foreach( var value in _enumerable )
                        {
                            if( _fields.Contains( value ) )
                            {
                                _list.Add( value );
                            }
                        }
                    }

                    return _enumerable?.Any( ) == true
                        ? _enumerable
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
        /// Gets the names.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetNames( )
        {
            if( Output?.Any( ) == true )
            {
                try
                {
                    var _keys = Output?.Keys;
                    var _fields = Enum.GetNames( typeof( Field ) );
                    var _list = new List<string>( );

                    if( _keys?.Any( ) == true )
                    {
                        foreach( var key in _keys )
                        {
                            if( !string.IsNullOrEmpty( key )
                               && _fields.Contains( key ) )
                            {
                                _list.Add( key );
                            }
                        }
                    }

                    return _list?.Any( ) == true
                        ? _list
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
        /// Sets the input.
        /// </summary>
        /// <param name="input">The dictionary.</param>
        protected void SetInput( IDictionary<string, object> input )
        {
            if( input?.Any( ) == true )
            {
                try
                {
                    var _dict = new Dictionary<string, object>( );
                    var _fields = Enum.GetNames( typeof( Field ) );

                    foreach( var kvp in input )
                    {
                        if( !string.IsNullOrEmpty( kvp.Key )
                           && _fields?.Contains( kvp.Key ) == true )
                        {
                            _dict?.Add( kvp.Key, kvp.Value );
                        }
                    }

                    Input = _dict?.Any( ) == true && _dict != Output
                        ? _dict
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the output.
        /// </summary>
        /// <param name="output">The dictionary.</param>
        protected void SetOutput( IDictionary<string, object> output )
        {
            if( output?.Any( ) == true )
            {
                try
                {
                    var _dictionary = new Dictionary<string, object>( );

                    if( Values?.Any( ) == true )
                    {
                        var _data = Values.ToArray( );

                        foreach( var kvp in output )
                        {
                            for( var i = 0; i < _data.Length; i++ )
                            {
                                var _name = _data[ i ].ToString( );

                                if( !string.IsNullOrEmpty( _name )
                                   && kvp.Key.Contains( _name ) )
                                {
                                    _dictionary?.Add( kvp.Key, kvp.Value );
                                }
                            }
                        }

                        Output = _dictionary?.Any( ) == true
                            ? _dictionary
                            : default;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}