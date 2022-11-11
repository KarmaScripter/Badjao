// <copyright file = "IFund.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    public interface IFund : IElement
    {
        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <returns>
        /// </returns>
        IElement GetTitle();

        /// <summary>
        /// Gets the treasury symbol.
        /// </summary>
        /// <returns>
        /// </returns>
        IElement GetTreasurySymbol();

        /// <summary>
        /// Gets the fund.
        /// </summary>
        /// <returns>
        /// </returns>
        IFund GetFund();
    }
}
