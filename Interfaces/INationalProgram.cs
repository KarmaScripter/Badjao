// <copyright file = "INationalProgram.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    public interface INationalProgram : IElement
    {
        /// <summary>
        /// Gets or sets the NPM.
        /// </summary>
        /// <value>
        /// The NPM.
        /// </value>
        NPM NPM { get; set; }
        
        /// <summary>
        /// Gets the national program.
        /// </summary>
        /// <returns>
        /// </returns>
        INationalProgram GetNationalProgram();
    }
}
