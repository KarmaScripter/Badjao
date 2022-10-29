// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data.Common;

    /// <summary>
    /// </summary>
    public interface IConnectionFactory
    {
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns>
        /// </returns>
        DbConnection Connection { get; set; }

        /// <summary>
        /// Gets the connection manager.
        /// </summary>
        /// <returns>
        /// </returns>
        IConnectionBuilder ConnectionBuilder { get; set; }
    }
}