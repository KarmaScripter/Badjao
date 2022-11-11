// <copyright file = "ITime.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;

    /// <summary>
    /// Defines the interface for the budget time objects
    /// </summary>
    public interface ITime : IDataUnit
    {
        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <returns>
        /// </returns>
        EventDate GetEventDate();

        /// <summary>
        /// Determines whether the specified element is equal.
        /// </summary>
        /// <param name = "element" >
        /// The element.
        /// </param>
        /// <returns>
        /// <c>
        /// true
        /// </c>
        /// if the specified element is equal; otherwise,
        /// <c>
        /// false
        /// </c>
        /// .
        /// </returns>
        bool IsEqual( IDataUnit element );
    }
}
