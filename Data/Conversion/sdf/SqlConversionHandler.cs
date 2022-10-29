//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="done">if set to <c>true</c> [done].</param>
    /// <param name="success">if set to <c>true</c> [success].</param>
    /// <param name="percent">The percent.</param>
    /// <param name="msg">The MSG.</param>
    public delegate void SqlConversionHandler( bool done, bool success, int percent,
        string msg );
}