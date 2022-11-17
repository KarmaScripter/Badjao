// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class HolidayFactory : IFederalHoliday
    {
        /// <summary>
        /// Gets the Data.
        /// </summary>
        /// <value>
        /// The Data.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public IDictionary<string, object> Args { get; set; }

        /// <summary>
        /// Creates new years.
        /// </summary>
        /// <value>
        /// The new years.
        /// </value>
        public DateOnly NewYearsDay { get; set; }

        /// <summary>
        /// Gets the martin luther king.
        /// </summary>
        /// <value>
        /// The martin luther king.
        /// </value>
        public DateOnly MartinLutherKingDay { get; set; }

        /// <summary>
        /// Gets the presidents.
        /// </summary>
        /// <value>
        /// The presidents.
        /// </value>
        public DateOnly PresidentsDay { get; set; }

        /// <summary>
        /// Gets the memorial.
        /// </summary>
        /// <value>
        /// The memorial.
        /// </value>
        public DateOnly MemorialDay { get; set; }

        /// <summary>
        /// Gets or sets the Juneteenth day.
        /// </summary>
        /// <value>
        /// The Juneteenth day.
        /// </value>
        public DateOnly JuneteenthDay { get; set; }

        /// <summary>
        /// Gets the veterans.
        /// </summary>
        /// <value>
        /// The veterans.
        /// </value>
        public DateOnly VeteransDay { get; set; }

        /// <summary>
        /// Gets the labor.
        /// </summary>
        /// <value>
        /// The labor.
        /// </value>
        public DateOnly LaborDay { get; set; }

        /// <summary>
        /// Gets the independence.
        /// </summary>
        /// <value>
        /// The independence.
        /// </value>
        public DateOnly IndependenceDay { get; set; }

        /// <summary>
        /// Gets the columbus.
        /// </summary>
        /// <value>
        /// The columbus.
        /// </value>
        public DateOnly ColumbusDay { get; set; }

        /// <summary>
        /// Gets the thanksgiving.
        /// </summary>
        /// <value>
        /// The thanksgiving.
        /// </value>
        public DateOnly ThanksgivingDay { get; set; }

        /// <summary>
        /// Gets the christmas.
        /// </summary>
        /// <value>
        /// The christmas.
        /// </value>
        public DateOnly ChristmasDay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public HolidayFactory( )
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataRow"></param>
        public HolidayFactory( DataRow dataRow )
        {
            Record = dataRow;
            NewYearsDay = DateOnly.Parse( dataRow[ $"{ Field.NewYears }" ].ToString( ) );
            MartinLutherKingDay = 
                DateOnly.Parse( dataRow[ $"{Field.MartinLutherKing }" ].ToString( ) );
            PresidentsDay = DateOnly.Parse( dataRow[ $"{ Field.Presidents }" ].ToString( ) );
            MemorialDay = DateOnly.Parse( dataRow[ $"{ Field.Memorial }" ].ToString( ) );
            VeteransDay = DateOnly.Parse( dataRow[ $"{ Field.Veterans }" ].ToString( ) );
            LaborDay = DateOnly.Parse( dataRow[ $"{ Field.Labor }" ].ToString( ) );
            IndependenceDay = DateOnly.Parse( dataRow[ $"{ Field.Independence }" ].ToString( ) );
            ColumbusDay = DateOnly.Parse( dataRow[ $"{ Field.Columbus }" ].ToString( ) );
            ThanksgivingDay = DateOnly.Parse( dataRow[ $"{ Field.Thanksgiving }" ].ToString( ) );
            ChristmasDay = DateOnly.Parse( dataRow[ $"{ Field.Christmas}" ].ToString( ) );
            Args = Record?.ToDictionary( );
        }

        /// <summary>
        /// Gets the federal holidays.
        /// </summary>
        /// <param name = "dict" >
        /// The dictionary.
        /// </param>
        /// <returns>
        /// </returns>
        public IDictionary<string, DateTime> GetFederalHolidays( IDictionary<string, string> dict )
        {
            try
            {
                var _holiday = new Dictionary<string, DateTime>( );

                foreach( var kvp in dict )
                {
                    _holiday.Add( kvp.Key, DateTime.Parse( kvp.Value ) );
                }

                return _holiday.Any( )
                    ? _holiday
                    : default( Dictionary<string, DateTime> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, DateTime> );
            }
        }

        /// <summary>
        /// Gets the national holidays.
        /// </summary>
        /// <param name = "dict" >
        /// The dictionary.
        /// </param>
        /// <returns>
        /// </returns>
        public IDictionary<string, DateTime> GetNationalHolidays( IDictionary<string, string> dict )
        {
            try
            {
                var _holiday = new Dictionary<string, DateTime>( );

                foreach( var kvp in dict )
                {
                    _holiday.Add( kvp.Key, DateTime.Parse( kvp.Value ) );
                }

                return _holiday.Any( )
                    ? _holiday
                    : default( Dictionary<string, DateTime> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, DateTime> );
            }
        }

        /// <summary>
        /// Converts to dictionary.
        /// </summary>
        /// <returns>
        /// </returns>
        public IDictionary<string, object> ToDictionary( )
        {
            try
            {
                return Args.Count > 0
                    ? Args
                    : default( IDictionary<string, object> );
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
        private protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}