// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// Defines the Fiscal Year Availability of Appropriated Funds
    /// </summary>
    public enum FundAvailability
    {
        /// <summary>
        /// The none
        /// </summary>
        NS = 0,

        /// <summary>
        /// The expirirng
        /// </summary>
        Expiring = 1,

        /// <summary>
        /// The mulit year
        /// </summary>
        MultiYear = 2,

        /// <summary>
        /// The no year
        /// </summary>
        NoYear
    }
}