// // <copyright file = "DataUnit.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="IDataUnit" />
    public abstract class DataUnit : IDataUnit
    {
        /// <summary>
        /// The value
        /// </summary>
        public virtual object Value { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets the field.
        /// </summary>
        public virtual Field Field { get; set; }

        /// <summary>
        /// Determines whether the specified dataUnit is match.
        /// </summary>
        /// <param name="dataUnit">The dataUnit.</param>
        /// <returns>
        ///   <c>true</c> if the specified dataUnit is match; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool IsMatch( IDataUnit dataUnit )
        {
            if( dataUnit != null )
            {
                try
                {
                    var _name = dataUnit.Name;
                    var _value = dataUnit.Value;
                    return _value.Equals( Value ) && _name.Equals( Name );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified dataUnit is match.
        /// </summary>
        /// <param name="element">The dataUnit.</param>
        /// <returns>
        ///   <c>true</c> if the specified dataUnit is match; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool IsMatch( IElement element )
        {
            if( element != null )
            {
                try
                {
                    var _name = element.Name;
                    var _value = element.Value;
                    return _value.Equals( Value ) && _name.Equals( Name );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified dictionary is match.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <returns>
        ///   <c>true</c> if the specified dictionary is match; otherwise, <c>false</c>.
        /// </returns>
        public virtual bool IsMatch( IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true )
            {
                try
                {
                    var _name = dict.Keys.First( );
                    var _value = dict[ _name ];
                    return _value.Equals( Value ) && _name.Equals( Name );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}