// <copyright file = "IFederalHoliday.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;

    public interface IFederalHoliday
    {
        /// <summary>
        /// Creates new years.
        /// </summary>
        /// <value>
        /// The new years.
        /// </value>
        DateOnly NewYearsDay { get; set; }

        /// <summary>
        /// Gets or sets the martin luther king.
        /// </summary>
        /// <value>
        /// The martin luther king.
        /// </value>
        DateOnly MartinLutherKingDay { get; set; }

        /// <summary>
        /// Gets or sets the presidents.
        /// </summary>
        /// <value>
        /// The presidents.
        /// </value>
        DateOnly PresidentsDay { get; set; }

        /// <summary>
        /// Gets or sets the memorial.
        /// </summary>
        /// <value>
        /// The memorial.
        /// </value>
        DateOnly MemorialDay { get; set; }

        /// <summary>
        /// Gets or sets the veterans.
        /// </summary>
        /// <value>
        /// The veterans.
        /// </value>
        DateOnly VeteransDay { get; set; }

        /// <summary>
        /// Gets or sets the labor.
        /// </summary>
        /// <value>
        /// The labor.
        /// </value>
        DateOnly LaborDay { get; set; }

        /// <summary>
        /// Gets or sets the independence.
        /// </summary>
        /// <value>
        /// The independence.
        /// </value>
        DateOnly IndependenceDay { get; set; }

        /// <summary>
        /// Gets or sets the columbus.
        /// </summary>
        /// <value>
        /// The columbus.
        /// </value>
        DateOnly ColumbusDay { get; set; }

        /// <summary>
        /// Gets or sets the thanksgiving.
        /// </summary>
        /// <value>
        /// The thanksgiving.
        /// </value>
        DateOnly ThanksgivingDay { get; set; }

        /// <summary>
        /// Gets or sets the christmas.
        /// </summary>
        /// <value>
        /// The christmas.
        /// </value>
        DateOnly ChristmasDay { get; set; }
    }
}
