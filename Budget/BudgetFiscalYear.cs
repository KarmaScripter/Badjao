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
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
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
        public string Availability { get; set; }

        /// <summary>
        /// Gets or sets the federal holidays.
        /// </summary>
        /// <value>
        /// The federal holidays.
        /// </value>
        public IDictionary<Holiday, DateOnly> FederalHolidays { get; set; }

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
            InputYear = bfy;
            Record = new DataBuilder( Source, SetArgs( bfy ) )?.Record;
            FiscalYearId = new Key( Record, PrimaryKey.FiscalYearsId );
            FirstYear = Record[ $"{ Field.FirstYear }" ].ToString( );
            LastYear = Record[ $"{ Field.LastYear }" ].ToString( );
            Availability = Record[ $"{ Field.Availability }" ].ToString( );
            WorkDays = double.Parse( Record[ $"{ Field.WorkDays }" ].ToString( ) );
            WeekDays = double.Parse( Record[ $"{ Field.WeekDays }" ].ToString( ) );
            WeekEnds = double.Parse( Record[ $"{ Field.WeekEnds }" ].ToString( ) );
            ExpiringYear = Record[ $"{ Field.ExpiringYear }" ].ToString( );
            StartDate = Record[ $"{ Field.StartDate }" ].ToString( );
            EndDate = Record[ $"{ Field.EndDate }" ].ToString( );
            CancellationDate = Record[ $"{ Field.CancellationDate }" ].ToString( );
            Holidays = new HolidayFactory( Record );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public BudgetFiscalYear( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            FiscalYearId = new Key( Record, PrimaryKey.FiscalYearsId );
            FirstYear = Record[ $"{ Field.FirstYear }" ].ToString( );
            LastYear = Record[ $"{ Field.LastYear }" ].ToString( );
            Availability = Record[ $"{ Field.Availability }" ].ToString( );
            WorkDays = double.Parse( Record[ $"{ Field.WorkDays }" ].ToString( ) );
            WeekDays = double.Parse( Record[ $"{ Field.WeekDays }" ].ToString( ) );
            WeekEnds = double.Parse( Record[ $"{ Field.WeekEnds }" ].ToString( ) );
            ExpiringYear = Record[ $"{ Field.ExpiringYear }" ].ToString( );
            StartDate = Record[ $"{ Field.StartDate }" ].ToString( );
            EndDate = Record[ $"{ Field.EndDate }" ].ToString( );
            CancellationDate = Record[ $"{ Field.CancellationDate }" ].ToString( );
            Holidays = new HolidayFactory( Record );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        /// <param name="dataBuilder">The data builder.</param>
        public BudgetFiscalYear( IDataModel dataBuilder )
        {
            Record = dataBuilder?.Record;
            FiscalYearId = new Key( Record, PrimaryKey.FiscalYearsId );
            FirstYear = Record[ $"{ Field.FirstYear }" ].ToString( );
            LastYear = Record[ $"{ Field.LastYear }" ].ToString( );
            Availability = Record[ $"{ Field.Availability }" ].ToString( );
            WorkDays = double.Parse( Record[ $"{ Field.WorkDays }" ].ToString( ) );
            WeekDays = double.Parse( Record[ $"{ Field.WeekDays }" ].ToString( ) );
            WeekEnds = double.Parse( Record[ $"{ Field.WeekEnds }" ].ToString( ) );
            ExpiringYear = Record[ $"{ Field.ExpiringYear }" ].ToString( );
            StartDate = Record[ $"{ Field.StartDate }" ].ToString( );
            EndDate = Record[ $"{ Field.EndDate }" ].ToString( );
            CancellationDate = Record[ $"{ Field.CancellationDate }" ].ToString( );
            Holidays = new HolidayFactory( Record );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        /// <param name="fy">The fy.</param>
        public BudgetFiscalYear( BFY fy )
        {
            Record = new DataBuilder( Source, Provider.SQLite, SetArgs( fy ) )?.Record;
            FiscalYearId = new Key( Record, PrimaryKey.FiscalYearsId );
            FirstYear = Record[ $"{ Field.FirstYear }" ].ToString( );
            LastYear = Record[ $"{ Field.LastYear }" ].ToString( );
            Availability = Record[ $"{ Field.Availability }" ].ToString( );
            WorkDays = double.Parse( Record[ $"{ Field.WorkDays }" ].ToString( ) );
            WeekDays = double.Parse( Record[ $"{ Field.WeekDays }" ].ToString( ) );
            WeekEnds = double.Parse( Record[ $"{ Field.WeekEnds }" ].ToString( ) );
            ExpiringYear = Record[ $"{ Field.ExpiringYear }" ].ToString( );
            StartDate = Record[ $"{ Field.StartDate }" ].ToString( );
            EndDate = Record[ $"{ Field.EndDate }" ].ToString( );
            CancellationDate = Record[ $"{ Field.CancellationDate }" ].ToString( );
            Holidays = new HolidayFactory( Record );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetFiscalYear"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public BudgetFiscalYear( DataRow dataRow )
        {
            Record = dataRow;
            InputYear = dataRow[ $"{ Field.BFY }" ].ToString( );
            FiscalYearId = new Key( Record, PrimaryKey.FiscalYearsId );
            FirstYear = dataRow[ $"{ Field.FirstYear }" ].ToString( );
            LastYear = dataRow[ $"{ Field.LastYear }" ].ToString( );
            Availability = dataRow[ $"{ Field.Availability }" ].ToString( );
            WorkDays = double.Parse( Record[ $"{ Field.WorkDays }" ].ToString( ) );
            WeekDays = double.Parse( Record[ $"{ Field.WeekDays }" ].ToString( ) );
            WeekEnds = double.Parse( Record[ $"{ Field.WeekEnds }" ].ToString( ) );
            ExpiringYear = dataRow[ $"{ Field.ExpiringYear }" ].ToString( );
            StartDate = dataRow[ $"{ Field.StartDate }" ].ToString( );
            EndDate = dataRow[ $"{ Field.EndDate }" ].ToString( );
            CancellationDate = dataRow[ $"{ Field.CancellationDate }" ].ToString( );
            Holidays = new HolidayFactory( dataRow );
        }

        /// <summary>
        /// Gets the federal holidays.
        /// </summary>
        /// <returns></returns>
        public IDictionary<Holiday, DateOnly> GetFederalHolidays( )
        {
            try
            {
                var _holidays = new Dictionary<Holiday, DateOnly>( );
                var _factory = new HolidayFactory( Record );
                _holidays.Add( Holiday.NewYears, _factory.ChristmasDay );
                _holidays.Add( Holiday.MartinLutherKing, _factory.MartinLutherKingDay );
                _holidays.Add( Holiday.Memorial, _factory.MemorialDay );
                _holidays.Add( Holiday.Presidents, _factory.PresidentsDay );
                _holidays.Add( Holiday.Veterans, _factory.VeteransDay );
                _holidays.Add( Holiday.Labor, _factory.LaborDay );
                _holidays.Add( Holiday.Independence, _factory.IndependenceDay );
                _holidays.Add( Holiday.Columbus, _factory.ColumbusDay );
                _holidays.Add( Holiday.Thanksgiving, _factory.ThanksgivingDay );
                _holidays.Add( Holiday.Christmas, _factory.ChristmasDay );

                return _holidays.Any( ) == true
                    ? _holidays
                    : default( IDictionary<Holiday, DateOnly> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<Holiday, DateOnly> );
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
                return !string.IsNullOrEmpty( FirstYear )
                    ? FirstYear
                    : default( string? );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
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
                return default( IBudgetFiscalYear );
            }
        }
    }
}