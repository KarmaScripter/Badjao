// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using BudgetExecution.Budget;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DataUnit" />
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Global" ) ]
    public abstract class TimeBase : DataUnit
    {
        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public string GetDate( string name )
        {
            if( !string.IsNullOrEmpty( name )
               && Enum.GetNames( typeof( EventDate ) )?.Contains( name ) == true )
            {
                try
                {
                    return !string.IsNullOrEmpty( name )
                        ? name
                        : string.Empty;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <param name="dataRow">The Data row.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public string GetDate( DataRow dataRow, string name )
        {
            if( dataRow != null
               && !string.IsNullOrEmpty( name )
               && Enum.GetNames( typeof( EventDate ) )?.Contains( name ) == true )
            {
                try
                {
                    var _columns = dataRow.Table?.GetColumnNames( );
                    return _columns?.Contains( name ) == true
                        ? name
                        : EventDate.NS.ToString( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return EventDate.NS.ToString( );
                }
            }

            return EventDate.NS.ToString( );
        }

        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public string GetDate( EventDate date )
        {
            try
            {
                return Enum.IsDefined( typeof( EventDate ), date )
                    ? date.ToString( )
                    : EventDate.NS.ToString( );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return EventDate.NS.ToString( );
            }
        }

        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <param name="dataRow">The Data row.</param>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public string GetDate( DataRow dataRow, EventDate date )
        {
            if( dataRow != null
               && Enum.IsDefined( typeof( EventDate ), date ) )
            {
                try
                {
                    var _names = dataRow.Table?.GetColumnNames( );
                    return _names?.Contains( date.ToString( ) ) == true
                        ? date.ToString( )
                        : EventDate.NS.ToString( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return EventDate.NS.ToString( );
                }
            }

            return EventDate.NS.ToString( );
        }

        /// <summary>
        /// Sets the date.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public EventDate SetDate( string name )
        {
            if( !string.IsNullOrEmpty( name )
               && Enum.GetNames( typeof( EventDate ) )?.Contains( name ) == true )
            {
                try
                {
                    var _date = (EventDate)Enum.Parse( typeof( EventDate ), name );
                    return Enum.IsDefined( typeof( EventDate ), _date )
                        ? _date
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return EventDate.NS;
                }
            }

            return EventDate.NS;
        }

        /// <summary>
        /// Sets the date.
        /// </summary>
        /// <param name="dataRow">The Data row.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public EventDate SetDate( DataRow dataRow, string name )
        {
            if( dataRow != null
               && !string.IsNullOrEmpty( name ) )
            {
                try
                {
                    var _date = (EventDate)Enum.Parse( typeof( EventDate ), name );
                    var _columns = dataRow.Table?.GetColumnNames( );

                    if( _columns?.Any( ) == true
                       && _columns?.Contains( $"{_date}" ) == true )
                    {
                        return Enum.GetNames( typeof( EventDate ) )?.Contains( $"{_date}" ) == true
                            ? _date
                            : EventDate.NS;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return EventDate.NS;
                }
            }

            return EventDate.NS;
        }

        /// <summary>
        /// Sets the date.
        /// </summary>
        /// <param name="dataRow">The Data row.</param>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public EventDate SetDate( DataRow dataRow, EventDate date )
        {
            if( dataRow != null
               && Enum.IsDefined( typeof( EventDate ), date ) )
            {
                try
                {
                    var _names = dataRow.Table?.GetColumnNames( );

                    if( _names?.Any( ) == true )
                    {
                        return _names?.Contains( date.ToString( ) ) == true
                            ? date
                            : EventDate.NS;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return EventDate.NS;
                }
            }

            return EventDate.NS;
        }

        /// <summary>
        /// Sets the day.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public DateTime SetDay( string value )
        {
            try
            {
                return !string.IsNullOrEmpty( value )
                    ? DateTime.Parse( value )
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Sets the day.
        /// </summary>
        /// <param name="dataRow">The Data row.</param>
        /// <param name="column">The column.</param>
        /// <returns></returns>
        public DateTime SetDay( DataRow dataRow, string column )
        {
            if( dataRow != null
               && !string.IsNullOrEmpty( column )
               && Enum.GetNames( typeof( EventDate ) )?.Contains( column ) == true )
            {
                try
                {
                    var _names = dataRow.Table?.GetColumnNames( );
                    var _timeString = dataRow[ column ]?.ToString( );
                    return _names?.Contains( column ) == true
                        && !string.IsNullOrEmpty( _timeString )
                            ? DateTime.Parse( _timeString )
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
        /// Sets the day.
        /// </summary>
        /// <param name="dataRow">The Data row.</param>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public DateTime SetDay( DataRow dataRow, EventDate date )
        {
            if( dataRow != null
               && Enum.IsDefined( typeof( EventDate ), date ) )
            {
                try
                {
                    var value = dataRow[ $"{ date }" ]?.ToString( );
                    return DateTime.Parse( value ) != null
                        ? DateTime.Parse( value )
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
        /// Sets the value.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public string SetValue( string value )
        {
            try
            {
                return !string.IsNullOrEmpty( value )
                    ? value
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="dataRow">The Data row.</param>
        /// <param name="column">The column.</param>
        /// <returns></returns>
        public string SetValue( DataRow dataRow, string column )
        {
            if( dataRow != null
               && !string.IsNullOrEmpty( column )
               && Enum.GetNames( typeof( EventDate ) )?.Contains( column ) == true )
            {
                try
                {
                    var _names = dataRow.Table?.GetColumnNames( );
                    var _input = dataRow[ column ]?.ToString( );
                    return _names?.Contains( column ) == true && !string.IsNullOrEmpty( _input )
                        ? dataRow[ column ].ToString( )
                        : string.Empty;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="dataRow">The Data row.</param>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public string SetValue( DataRow dataRow, EventDate date )
        {
            if( dataRow != null
               && Enum.IsDefined( typeof( EventDate ), date ) )
            {
                try
                {
                    var _timeString = dataRow[ $"{ date }" ]?.ToString( );
                    return DateTime.Parse( _timeString ) != null
                        ? dataRow[ $"{ date }" ]?.ToString( )
                        : string.Empty;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }
    }
}