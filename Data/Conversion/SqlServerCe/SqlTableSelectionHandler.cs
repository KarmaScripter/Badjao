// <copyright file = "SqlTableSelectionHandler.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

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