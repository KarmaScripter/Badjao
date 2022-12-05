// <copyright file = "ICalendarYear.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage( "ReSharper", "UnusedMemberInSuper.Global" )]
    public interface ICalendarYear
    {
        /// <summary>
        /// Gets or sets the Data.
        /// </summary>
        /// <value>
        /// The Data.
        /// </value>
        DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the work days.
        /// </summary>
        /// <value>
        /// The work days.
        /// </value>
        double WorkDays { get; set; }

        /// <summary>
        /// Gets or sets the week days.
        /// </summary>
        /// <value>
        /// The week days.
        /// </value>
        double WeekDays { get; set; }

        /// <summary>
        /// Gets or sets the week ends.
        /// </summary>
        /// <value>
        /// The week ends.
        /// </value>
        double WeekEnds { get; set; }
    }
}
