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
    /// <seealso cref="FiscalYear" />
    /// <seealso cref="IBudgetFiscalYear" />
    /// <seealso cref="ISource" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    public class BudgetFiscalYear : FiscalYear, IBudgetFiscalYear, ISource
    {
        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; } = Source.FiscalYears;

        /// <summary>
        /// Gets or sets the holidays.
        /// </summary>
        /// <value>
        /// The holidays.
        /// </value>
        public HolidayFactory Holidays { get; set; }

        /// <summary>
        /// Gets or sets the availability.
        /// </summary>
        /// <value>
        /// The availability.
        /// </value>
        public IElement Availability { get; set; }

        /// <summary>
        /// Gets or sets the federal holidays.
        /// </summary>
        /// <value>
        /// The federal holidays.
        /// </value>
        public IDictionary<Holiday, DateTime> FederalHolidays { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        public BudgetFiscalYear( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        /// <param name="bfy">The bfy.</param>
        public BudgetFiscalYear( string bfy )
        {
            InputYear = new Element( Field.BFY, bfy );
            Record = new DataBuilder( Source, SetArgs( bfy ) )?.Record;
            FiscalYearId = new Key( Record, PrimaryKey.FiscalYearsId );
            FirstYear = new Element( Record, Field.BBFY );
            LastYear = new Element( Record, Field.EBFY );
            Availability = new Element( Record, Field.Availability );
            Holidays = new HolidayFactory( Record );
            WorkDays = new Element( Record, Field.WorkDays );
            WeekDays = new Element( Record, Field.WeekDays );
            WeekEnds = new Element( Record, Field.WeekEnds );
            ExpiringYear = new Element( Record, Field.ExpiringYear );
            StartDate = new Element( Record, Field.StartDate );
            EndDate = new Element( Record, Field.EndDate );
            CancellationDate = new Element( Record, Field.CancellationDate );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public BudgetFiscalYear( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            FiscalYearId = new Key( Record, PrimaryKey.FiscalYearsId );
            FirstYear = new Element( Record, Field.BBFY );
            LastYear = new Element( Record, Field.EBFY );
            Availability = new Element( Record, Field.Availability );
            Holidays = new HolidayFactory( Record );
            WorkDays = new Element( Record, Field.WorkDays );
            WeekDays = new Element( Record, Field.WeekDays );
            WeekEnds = new Element( Record, Field.WeekEnds );
            ExpiringYear = new Element( Record, Field.ExpiringYear );
            StartDate = new Element( Record, Field.StartDate );
            EndDate = new Element( Record, Field.EndDate );
            CancellationDate = new Element( Record, Field.CancellationDate );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        /// <param name="dataBuilder">The data builder.</param>
        public BudgetFiscalYear( IDataModel dataBuilder )
        {
            Record = dataBuilder?.Record;
            FiscalYearId = new Key( Record, PrimaryKey.FiscalYearsId );
            FirstYear = new Element( Record, Field.BBFY );
            LastYear = new Element( Record, Field.EBFY );
            Availability = new Element( Record, Field.Availability );
            Holidays = new HolidayFactory( Record );
            WorkDays = new Element( Record, Field.WorkDays );
            WeekDays = new Element( Record, Field.WeekDays );
            WeekEnds = new Element( Record, Field.WeekEnds );
            ExpiringYear = new Element( Record, Field.ExpiringYear );
            StartDate = new Element( Record, Field.StartDate );
            EndDate = new Element( Record, Field.EndDate );
            CancellationDate = new Element( Record, Field.CancellationDate );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        /// <param name="fy">The fy.</param>
        public BudgetFiscalYear( BFY fy )
        {
            Record = new DataBuilder( Source, Provider.SQLite, SetArgs( fy ) )?.Record;
            FiscalYearId = new Key( Record, PrimaryKey.FiscalYearsId );
            FirstYear = new Element( Record, Field.BBFY );
            LastYear = new Element( Record, Field.EBFY );
            Availability = new Element( Record, Field.Availability );
            Holidays = new HolidayFactory( Record );
            WorkDays = new Element( Record, Field.WorkDays );
            WeekDays = new Element( Record, Field.WeekDays );
            WeekEnds = new Element( Record, Field.WeekEnds );
            ExpiringYear = new Element( Record, Field.ExpiringYear );
            StartDate = new Element( Record, Field.StartDate );
            EndDate = new Element( Record, Field.EndDate );
            CancellationDate = new Element( Record, Field.CancellationDate );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public BudgetFiscalYear( DataRow dataRow )
        {
            Record = dataRow;
            InputYear = new Element( Record, CurrentYear.ToString( ) );
            FiscalYearId = new Key( Record, PrimaryKey.FiscalYearsId );
            FirstYear = new Element( Record, Field.BBFY );
            LastYear = new Element( Record, Field.EBFY );
            Availability = new Element( Record, Field.Availability );
            Holidays = new HolidayFactory( Record );
            WorkDays = new Element( Record, Field.WorkDays );
            WeekDays = new Element( Record, Field.WeekDays );
            WeekEnds = new Element( Record, Field.WeekEnds );
            ExpiringYear = new Element( Record, Field.ExpiringYear );
            StartDate = new Element( Record, Field.StartDate );
            EndDate = new Element( Record, Field.EndDate );
            CancellationDate = new Element( Record, Field.CancellationDate );
        }

        /// <summary>
        /// Gets the federal holidays.
        /// </summary>
        /// <returns></returns>
        public IDictionary<Field, DateTime> GetFederalHolidays( )
        {
            try
            {
                var _holidays = new Dictionary<Field, DateTime>( );
                var _factory = new HolidayFactory( Record );
                _holidays.Add( Field.NewYears, 
                    DateTime.Parse( _factory?.NewYearsDay?.Value?.ToString( ) ) );

                _holidays.Add( Field.MartinLutherKing,
                    DateTime.Parse( _factory?.MartinLutherKingDay?.Value?.ToString( ) ) );

                _holidays.Add( Field.Memorial,
                    DateTime.Parse( _factory?.MemorialDay?.Value?.ToString( ) ) );

                _holidays.Add( Field.Presidents,
                    DateTime.Parse( _factory?.PresidentsDay?.Value?.ToString( ) ) );

                _holidays.Add( Field.Veterans,
                    DateTime.Parse( _factory?.VeteransDay?.Value?.ToString( ) ) );

                _holidays.Add( Field.Labor, DateTime.Parse( _factory?.LaborDay?.Value?.ToString( ) ) );
                _holidays.Add( Field.Independence,
                    DateTime.Parse( _factory?.IndependenceDay?.Value?.ToString( ) ) );

                _holidays.Add( Field.Columbus,
                    DateTime.Parse( _factory?.ColumbusDay?.Value?.ToString( ) ) );

                _holidays.Add( Field.Thanksgiving,
                    DateTime.Parse( _factory?.ThanksgivingDay?.Value?.ToString( ) ) );

                _holidays.Add( Field.Christmas,
                    DateTime.Parse( _factory?.ChristmasDay?.Value?.ToString( ) ) );

                return _holidays?.Any( ) == true
                    ? _holidays
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString( )
        {
            try
            {
                return !string.IsNullOrEmpty( FirstYear?.Value?.ToString( ) )
                    ? FirstYear?.Value?.ToString( )
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the budget fiscal year.
        /// </summary>
        /// <returns></returns>
        public IBudgetFiscalYear GetBudgetFiscalYear( )
        {
            try
            {
                return MemberwiseClone( ) as BudgetFiscalYear;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <returns></returns>
        public Source GetSource( )
        {
            try
            {
                return Enum.IsDefined( typeof( Source ), Source )
                    ? Source
                    : Source.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }
    }
}