// <copyright file = "IElement.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    public interface IElement : IDataUnit
    {
        /// <summary>
        /// Gets the field.
        /// </summary>
        /// <returns></returns>
        string Code { get; set; }

        /// <summary>
        /// Gets or sets the initial.
        /// </summary>
        /// <value>
        /// The initial.
        /// </value>
        string Initial { get; set; }
    }
}