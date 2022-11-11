// <copyright file = "IFederalHoliday.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public interface IFederalHoliday
    {
        /// <summary>
        /// Creates new years.
        /// </summary>
        /// <value>
        /// The new years.
        /// </value>
        IElement NewYearsDay { get; set; }

        /// <summary>
        /// Gets or sets the martin luther king.
        /// </summary>
        /// <value>
        /// The martin luther king.
        /// </value>
        IElement MartinLutherKingDay { get; set; }

        /// <summary>
        /// Gets or sets the presidents.
        /// </summary>
        /// <value>
        /// The presidents.
        /// </value>
        IElement PresidentsDay { get; set; }

        /// <summary>
        /// Gets or sets the memorial.
        /// </summary>
        /// <value>
        /// The memorial.
        /// </value>
        IElement MemorialDay { get; set; }

        /// <summary>
        /// Gets or sets the veterans.
        /// </summary>
        /// <value>
        /// The veterans.
        /// </value>
        IElement VeteransDay { get; set; }

        /// <summary>
        /// Gets or sets the labor.
        /// </summary>
        /// <value>
        /// The labor.
        /// </value>
        IElement LaborDay { get; set; }

        /// <summary>
        /// Gets or sets the independence.
        /// </summary>
        /// <value>
        /// The independence.
        /// </value>
        IElement IndependenceDay { get; set; }

        /// <summary>
        /// Gets or sets the columbus.
        /// </summary>
        /// <value>
        /// The columbus.
        /// </value>
        IElement ColumbusDay { get; set; }

        /// <summary>
        /// Gets or sets the thanksgiving.
        /// </summary>
        /// <value>
        /// The thanksgiving.
        /// </value>
        IElement ThanksgivingDay { get; set; }

        /// <summary>
        /// Gets or sets the christmas.
        /// </summary>
        /// <value>
        /// The christmas.
        /// </value>
        IElement ChristmasDay { get; set; }
    }
}
