// <copyright file = "IBudgetFiscalYear.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;

    public interface IBudgetFiscalYear
    {
        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        BFY BFY { get; set; }

        /// <summary>
        /// Gets or sets the fiscal year identifier.
        /// </summary>
        /// <value>
        /// The fiscal year identifier.
        /// </value>
        int ID { get; set; }

        /// <summary>
        /// Gets or sets the bbfy.
        /// </summary>
        /// <value>
        /// The bbfy.
        /// </value>
        string FirstYear { get; set; }

        /// <summary>
        /// Gets or sets the ebfy.
        /// </summary>
        /// <value>
        /// The ebfy.
        /// </value>
        string LastYear { get; set; }

        /// <summary>
        /// Gets or sets the expiring year.
        /// </summary>
        /// <value>
        /// The expiring year.
        /// </value>
        string ExpiringYear { get; set; }

        /// <summary>
        /// Gets or sets the input year.
        /// </summary>
        /// <value>
        /// The input year.
        /// </value>
        string InputYear { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        DateOnly StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        DateOnly EndDate { get; set; }

        /// <summary>
        /// Gets or sets the cancellation date.
        /// </summary>
        /// <value>
        /// The cancellation date.
        /// </value>
        DateOnly CancellationDate { get; set; }

        /// <summary>
        /// Gets or sets the availability.
        /// </summary>
        /// <value>
        /// The availability.
        /// </value>
        string Availability { get; set; }

        /// <summary>
        /// Gets or sets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        DataRow Record { get; set; }

        /// <summary>
        /// Determines whether this instance is current.
        /// </summary>
        /// <returns>
        /// <c>
        /// true
        /// </c>
        /// if this instance is current; otherwise,
        /// <c>
        /// false
        /// </c>
        /// .
        /// </returns>
        bool IsCurrent();

        /// <summary>
        /// Gets the federal holidays.
        /// </summary>
        /// <returns>
        /// </returns>
        IDictionary<Holiday, DateOnly> GetFederalHolidays();
    }
}
