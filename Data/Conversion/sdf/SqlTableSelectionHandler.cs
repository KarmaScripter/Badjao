//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="schema">The schema.</param>
    /// <returns></returns>
    public delegate List<TableSchema> SqlTableSelectionHandler( List<TableSchema> schema );
}