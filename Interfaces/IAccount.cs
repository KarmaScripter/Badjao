// <copyright file = "IAccount.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    public interface IAccount
    {
        /// <summary>
        /// Gets the account.
        /// </summary>
        /// <returns>
        /// </returns>
        string Code { get; set; }

        /// <summary>
        /// Gets the activity
        /// </summary>
        /// <returns>
        /// </returns>
        string ActivityCode { get; set; }

        /// <summary>
        /// Gets the national program code.
        /// </summary>
        /// <returns>
        /// </returns>
        string NpmCode { get; set; }

        /// <summary>
        /// Gets the goal code.
        /// </summary>
        /// <returns>
        /// </returns>
        string GoalCode { get; set; }

        /// <summary>
        /// Gets the objective code.
        /// </summary>
        /// <returns>
        /// </returns>
        string ObjectiveCode { get; set; }

        /// <summary>
        /// Gets the program project code.
        /// </summary>
        /// <returns>
        /// </returns>
        string ProgramProjectCode { get; set; }

        /// <summary>
        /// Gets the program area code.
        /// </summary>
        /// <returns>
        /// </returns>
        string ProgramAreaCode { get; set; }
    }
}
