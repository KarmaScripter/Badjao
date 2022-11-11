// <copyright file = "HolidayFactory.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
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
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
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
        public IElement NewYearsDay { get; set; }

        /// <summary>
        /// Gets the martin luther king.
        /// </summary>
        /// <value>
        /// The martin luther king.
        /// </value>
        public IElement MartinLutherKingDay { get; set; }

        /// <summary>
        /// Gets the presidents.
        /// </summary>
        /// <value>
        /// The presidents.
        /// </value>
        public IElement PresidentsDay { get; set; }

        /// <summary>
        /// Gets the memorial.
        /// </summary>
        /// <value>
        /// The memorial.
        /// </value>
        public IElement MemorialDay { get; set; }

        /// <summary>
        /// Gets or sets the Juneteenth day.
        /// </summary>
        /// <value>
        /// The Juneteenth day.
        /// </value>
        public IElement JuneteenthDay { get; set; }

        /// <summary>
        /// Gets the veterans.
        /// </summary>
        /// <value>
        /// The veterans.
        /// </value>
        public IElement VeteransDay { get; set; }

        /// <summary>
        /// Gets the labor.
        /// </summary>
        /// <value>
        /// The labor.
        /// </value>
        public IElement LaborDay { get; set; }

        /// <summary>
        /// Gets the independence.
        /// </summary>
        /// <value>
        /// The independence.
        /// </value>
        public IElement IndependenceDay { get; set; }

        /// <summary>
        /// Gets the columbus.
        /// </summary>
        /// <value>
        /// The columbus.
        /// </value>
        public IElement ColumbusDay { get; set; }

        /// <summary>
        /// Gets the thanksgiving.
        /// </summary>
        /// <value>
        /// The thanksgiving.
        /// </value>
        public IElement ThanksgivingDay { get; set; }

        /// <summary>
        /// Gets the christmas.
        /// </summary>
        /// <value>
        /// The christmas.
        /// </value>
        public IElement ChristmasDay { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public HolidayFactory()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataRow"></param>
        public HolidayFactory( DataRow dataRow )
        {
            Record = dataRow;
            NewYearsDay = new Element( Record, Field.NewYears );
            MartinLutherKingDay = new Element( Record, Field.MartinLutherKing );
            PresidentsDay = new Element( Record, Field.Presidents );
            MemorialDay = new Element( Record, Field.Memorial );
            VeteransDay = new Element( Record, Field.Veterans );
            LaborDay = new Element( Record, Field.Labor );
            IndependenceDay = new Element( Record, Field.Independence );
            ColumbusDay = new Element( Record, Field.Columbus );
            ThanksgivingDay = new Element( Record, Field.Thanksgiving );
            ChristmasDay = new Element( Record, Field.Christmas );
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
        public IDictionary<string, object> ToDictionary()
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