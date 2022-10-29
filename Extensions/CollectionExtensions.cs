// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    public static class CollectionExtensions
    {
        /// <summary>Adds if.</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection">The collection.</param>
        /// <param name="predicate">The predicate.</param>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static bool AddIf<T>( this ICollection<T> collection, Func<T, bool> predicate,
            T value )
        {
            if( collection?.Count > 0
               && predicate( value ) )
            {
                try
                {
                    collection.Add( value );

                    return true;
                }
                catch( Exception ex )
                {
                    Fail( ex );

                    return false;
                }
            }

            return false;
        }

        /// <summary>Adds the range.</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection">The collection.</param>
        /// <param name="values">The values.</param>
        public static void AddRange<T>( this ICollection<T> collection, params T[ ] values )
        {
            if( values?.Length > 0
               && collection?.Any( ) == true )
            {
                try
                {
                    for( var i = 0; i < values.Length; i++ )
                    {
                        var _value = values[ i ];

                        if( _value != null )
                        {
                            collection.Add( _value );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>Determines whether this instance is empty.</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection">The collection.</param>
        /// <returns>
        ///   <c>true</c> if the specified collection is empty; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsEmpty<T>( this ICollection<T> collection )
        {
            try
            {
                return !( collection?.Count > 0 );
            }
            catch( Exception ex )
            {
                Fail( ex );

                return false;
            }
        }

        /// <summary>Removes if contains.</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection">The collection.</param>
        /// <param name="value">The value.</param>
        public static void RemoveIfContains<T>( this ICollection<T> collection, T value )
        {
            if( collection?.Contains( value ) == true )
            {
                try
                {
                    collection.Remove( value );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>Removes the range.</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection">The collection.</param>
        /// <param name="values">The values.</param>
        public static void RemoveRange<T>( this ICollection<T> collection, params T[ ] values )
        {
            if( collection?.Any( ) == true
               && values?.Any( ) == true )
            {
                try
                {
                    foreach( var _item in values )
                    {
                        collection.Remove( _item );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>Removes the where.</summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection">The collection.</param>
        /// <param name="predicate">The predicate.</param>
        public static void RemoveWhere<T>( this ICollection<T> collection, Predicate<T> predicate )
        {
            if( collection?.Any( ) == true )
            {
                try
                {
                    var _list = collection?.Where( child => predicate( child ) )?.ToList( );

                    if( _list?.Any( ) == true )
                    {
                        _list.ForEach( t => collection.Remove( t ) );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>Determines whether this instance is empty.</summary>
        /// <param name="collection">The collection.</param>
        /// <returns>
        ///   <c>true</c> if the specified collection is empty; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsEmpty( this ICollection collection )
        {
            try
            {
                return !( collection?.Count > 0 );
            }
            catch( Exception ex )
            {
                Fail( ex );

                return true;
            }
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