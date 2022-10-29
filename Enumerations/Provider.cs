// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// Defines the Provider
    /// </summary>
    public enum Provider
    {
        /// <summary>
        /// Defines the SQLite
        /// </summary>
        SQLite = 0,

        /// <summary>
        /// Defines the Excel
        /// </summary>
        Excel = 1,

        /// <summary>
        /// Defines the SqlServer
        /// </summary>
        SqlServer = 2,

        /// <summary>
        /// Defines the SqlCe
        /// </summary>
        SqlCe = 3,

        /// <summary>
        /// Defines the Access
        /// </summary>
        Access = 4,

        /// <summary>
        /// Defines the OleDb
        /// </summary>
        OleDb = 5,

        /// <summary>
        /// Defines the CSV
        /// </summary>
        CSV = 6,

        /// <summary>
        /// The text
        /// </summary>
        TXT = 7,

        /// <summary>
        /// The ns
        /// </summary>
        NS = 8
    }
}