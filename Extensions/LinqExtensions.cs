// // <copyright file = "LinqExtensions.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    public static class LinqExtensions
    {
        /// <summary>
        /// Nones the specified predicate.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public static bool None<TSource>( this IEnumerable<TSource> source,
            Func<TSource, bool> predicate )
        {
            return !source.Any( predicate );
        }

        /// <summary>
        /// Determines whether [has at least] [the specified minimum count].
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="minCount">The minimum count.</param>
        /// <returns>
        ///   <c>true</c> if [has at least] [the specified minimum count]; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasAtLeast<TSource>( this IEnumerable<TSource> source, int minCount )
        {
            return source.HasAtLeast( minCount, _ => true );
        }

        /// <summary>
        /// Determines whether [has at least] [the specified minimum count].
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="minCount">The minimum count.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>
        ///   <c>true</c> if [has at least] [the specified minimum count]; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasAtLeast<TSource>( this IEnumerable<TSource> source, int minCount,
            Func<TSource, bool> predicate )
        {
            if( minCount == 0 )
            {
                return true;
            }

            if( source is ICollection _sequence
               && _sequence?.Count < minCount )
            {
                return false;
            }

            var _matches = 0;
            foreach( var _unused in source.Where( predicate ) )
            {
                _matches++;
                if( _matches >= minCount )
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified count has exactly.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="count">The count.</param>
        /// <returns>
        ///   <c>true</c> if the specified count has exactly; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasExactly<TSource>( this IEnumerable<TSource> source, int count )
        {
            return source is ICollection _sequence
                ? _sequence.Count == count
                : source.HasExactly( count, _ => true );
        }

        /// <summary>
        /// Determines whether the specified count has exactly.
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="count">The count.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>
        ///   <c>true</c> if the specified count has exactly; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasExactly<TSource>( this IEnumerable<TSource> source, int count,
            Func<TSource, bool> predicate )
        {
            if( source is ICollection _sequence
               && _sequence.Count < count )
            {
                return false;
            }

            var _matches = 0;
            foreach( var _unused in source.Where( predicate ) )
            {
                ++_matches;
                if( _matches > count )
                {
                    return false;
                }
            }

            return _matches == count;
        }

        /// <summary>
        /// Determines whether [has at most] [the specified limit].
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="limit">The limit.</param>
        /// <returns>
        ///   <c>true</c> if [has at most] [the specified limit]; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasAtMost<TSource>( this IEnumerable<TSource> source, int limit )
        {
            return source.HasAtMost( limit, _ => true );
        }

        /// <summary>
        /// Determines whether [has at most] [the specified limit].
        /// </summary>
        /// <typeparam name="TSource">The type of the source.</typeparam>
        /// <param name="source">The source.</param>
        /// <param name="limit">The limit.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns>
        ///   <c>true</c> if [has at most] [the specified limit]; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasAtMost<TSource>( this IEnumerable<TSource> source, int limit,
            Func<TSource, bool> predicate )
        {
            if( source is ICollection _sequence
               && _sequence.Count <= limit )
            {
                return true;
            }

            var _matches = 0;
            foreach( var _unused in source.Where( predicate ) )
            {
                _matches++;
                if( _matches > limit )
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Fails the specified ex.
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