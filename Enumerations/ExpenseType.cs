// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// Defines the OutlayType
    /// </summary>
    public enum ExpenseType
    {
        /// <summary>
        /// Defines the None
        /// </summary>
        NS = 0,

        /// <summary>
        /// Defines the Commitment
        /// </summary>
        Commitment,

        /// <summary>
        /// Defines the OpenCommitment
        /// </summary>
        OpenCommitment,

        /// <summary>
        /// Defines the Obligation
        /// </summary>
        Obligation,

        /// <summary>
        /// Defines the ULO
        /// </summary>
        ULO,

        /// <summary>
        /// The de-obligation
        /// </summary>
        Deobligation,

        /// <summary>
        /// Defines the Expenditure
        /// </summary>
        Expenditure,

        /// <summary>
        /// Defines the All
        /// </summary>
        All
    }
}