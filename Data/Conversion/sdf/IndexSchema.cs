// // <copyright file = "IndexSchema.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class IndexSchema
    {
        /// <summary>
        /// The columns
        /// </summary>
        public List<IndexColumn> Columns { get; set; }

        /// <summary>
        /// The index name
        /// </summary>
        public string IndexName { get; set; }

        /// <summary>
        /// The is unique
        /// </summary>
        public bool IsUnique { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class IndexColumn
    {
        /// <summary>
        /// The column name
        /// </summary>
        public string ColumnName { get; set; }

        /// <summary>
        /// The is ascending
        /// </summary>
        public bool IsAscending { get; set; }
    }
}