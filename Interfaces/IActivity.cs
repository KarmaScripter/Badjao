// <copyright file = "IActivity.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    public interface IActivity : IElement
    {
        /// <summary>
        /// Gets the activity.
        /// </summary>
        /// <returns>
        /// </returns>
        IActivity GetActivity();
    }
}
