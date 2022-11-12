// <copyright file = "IsTime.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using BudgetExecution.Budget;
    using DocumentFormat.OpenXml.Bibliography;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="TimeBase" />
    /// <seealso cref="ITime" />
    /// <seealso cref="TimeBase" />
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" )]
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "ArrangeModifiersOrder" )]
    public class Time : TimeBase, ITime
    {
        /// <summary>
        /// The default
        /// </summary>
        public static readonly Time Default = new Time( EventDate.NS );

        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public EventDate Date { get; set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public DateTime Day { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Time" /> class.
        /// </summary>
        public Time( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Time" /> class.
        /// </summary>
        /// <param name="kvp">The KVP.</param>
        public Time( KeyValuePair<string, object> kvp )
        {
            Name = GetDate( kvp.Key );
            Date = SetDate( kvp.Key );
            Day = SetDay( kvp.Value?.ToString( ) );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Time" /> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="value">The value.</param>
        public Time( string name, string value = "" )
        {
            Name = GetDate( name );
            Date = SetDate( name );
            Day = SetDay( value );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Time" /> class.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <param name="value">The value.</param>
        public Time( EventDate date, string value = "" )
        {
            Name = GetDate( date );
            Date = SetDate( date.ToString( ) );
            Day = SetDay( value );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Time" /> class.
        /// </summary>
        /// <param name="dataRow">The Data.</param>
        /// <param name="date">The date.</param>
        public Time( DataRow dataRow, EventDate date )
        {
            Date = SetDate( dataRow, date );
            Name = GetDate( dataRow, date );
            Day = SetDay( dataRow, date );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Time" /> class.
        /// </summary>
        /// <param name="dataRow">The Data.</param>
        /// <param name="value">The value.</param>
        public Time( DataRow dataRow, string value )
        {
            Date = SetDate( dataRow, value );
            Name = GetDate( dataRow, value );
            Day = SetDay( dataRow, value );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Time" /> class.
        /// </summary>
        /// <param name="dataRow">The Data.</param>
        /// <param name="column">The column.</param>
        public Time( DataRow dataRow, DataColumn column )
        {
            Date = SetDate( dataRow, column.ColumnName );
            Name = GetDate( dataRow, column.ColumnName );
            Day = SetDay( dataRow, dataRow[ column ]?.ToString( ) );
        }
        
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        public string GetName( )
        {
            try
            {
                return Enum.IsDefined( typeof( EventDate ), Date )
                    ? Date.ToString( )
                    : EventDate.NS.ToString( );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return EventDate.NS.ToString( );
            }
        }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <returns></returns>
        public string GetValue()
        {
            try
            {
                return Enum.IsDefined( typeof( EventDate ), Date )
                    ? $"{ Name } = { Day }"
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <returns></returns>
        public EventDate GetEventDate()
        {
            try
            {
                return Enum.IsDefined( typeof( EventDate ), Date )
                    ? Date
                    : EventDate.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return EventDate.NS;
            }
        }

        /// <summary>
        /// Determines whether the specified element is equal.
        /// </summary>
        /// <param name="day">The element.</param>
        /// <returns>
        /// <c>
        /// true
        /// </c>
        /// if the specified element is equal; otherwise,
        /// <c>
        /// false
        /// </c>
        /// .
        /// </returns>
        public bool IsEqual( IDataUnit day )
        {
            if( day != null
               && day != Default )
            {
                try
                {
                    if( day?.Value?.ToString( )?.Equals( Day ) == true )
                    {
                        return true;
                    }
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
        /// Determines whether the specified primary is equal.
        /// </summary>
        /// <param name="first">The primary.</param>
        /// <param name="second">The secondary.</param>
        /// <returns>
        /// <c>
        /// true
        /// </c>
        /// if the specified primary is equal; otherwise,
        /// <c>
        /// false
        /// </c>
        /// .
        /// </returns>
        public static bool IsEqual( ITime first, ITime second )
        {
            if( first != null
               && first != Element.Default
               && first != null
               && second != Element.Default )
            {
                try
                {
                    if( first?.Value?.ToString( )?.Equals( second?.Value?.ToString( ) ) == true )
                    {
                        return true;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return false;
                }
            }

            return false;
        }
    }
}