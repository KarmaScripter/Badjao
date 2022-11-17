// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref = "ICalendarYear"/>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class CalendarYear : ICalendarYear
    {
        /// <summary>
        /// Gets or sets the Data.
        /// </summary>
        /// <value>
        /// The Data.
        /// </value>
        public virtual DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the work days.
        /// </summary>
        /// <value>
        /// The work days.
        /// </value>
        public virtual double WorkDays { get; set; }

        /// <summary>
        /// Gets or sets the week days.
        /// </summary>
        /// <value>
        /// The week days.
        /// </value>
        public virtual double WeekDays { get; set; }

        /// <summary>
        /// Gets or sets the week ends.
        /// </summary>
        /// <value>
        /// The week ends.
        /// </value>
        public virtual double WeekEnds { get; set; }

        /// <summary>
        /// Gets the current date.
        /// </summary>
        /// <value>
        /// The current date.
        /// </value>
        public DateTime CurrentDate = DateTime.Today;

        /// <summary>
        /// Gets the current month.
        /// </summary>
        /// <value>
        /// The current month.
        /// </value>
        public readonly int CurrentMonth = DateTime.Now.Month;

        /// <summary>
        /// Gets the current day.
        /// </summary>
        /// <value>
        /// The current day.
        /// </value>
        public readonly int CurrentDay = DateTime.Now.Day;

        /// <summary>
        /// Gets the current year.
        /// </summary>
        /// <value>
        /// The current year.
        /// </value>
        public readonly int CurrentYear = DateTime.Now.Year;

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