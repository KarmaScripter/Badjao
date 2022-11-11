// <copyright file = "IFiscalYear.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;

    /// <summary>
    /// 
    /// </summary>
    public interface IFiscalYear
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
        IKey FiscalYearId { get; set; }

        /// <summary>
        /// Gets or sets the first year.
        /// </summary>
        /// <value>
        /// The first year.
        /// </value>
        IElement FirstYear { get; set; }

        /// <summary>
        /// Gets or sets the last year.
        /// </summary>
        /// <value>
        /// The last year.
        /// </value>
        IElement LastYear { get; set; }

        /// <summary>
        /// Gets or sets the expiring year.
        /// </summary>
        /// <value>
        /// The expiring year.
        /// </value>
        IElement ExpiringYear { get; set; }

        /// <summary>
        /// Gets or sets the input year.
        /// </summary>
        /// <value>
        /// The input year.
        /// </value>
        IElement InputYear { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        IElement StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        IElement EndDate { get; set; }

        /// <summary>
        /// Gets or sets the cancellation date.
        /// </summary>
        /// <value>
        /// The cancellation date.
        /// </value>
        IElement CancellationDate { get; set; }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        DataRow Record { get; set; }

        /// <summary>
        /// Determines whether this instance is current.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is current; otherwise, <c>false</c>.
        /// </returns>
        bool IsCurrent();

        /// <summary>
        /// Determines whether this instance is carryover.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is carryover; otherwise, <c>false</c>.
        /// </returns>
        bool IsCarryover();
    }
}
