// <copyright file = "ColumnSchema.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Contains the schema of a single DB column.
    /// </summary>
    public class ColumnSchema
    {
        /// <summary>
        /// Gets or sets the name of the column.
        /// </summary>
        /// <value>
        /// The name of the column.
        /// </value>
        public string ColumnName { get; set; }

        /// <summary>
        /// Gets or sets the type of the column.
        /// </summary>
        /// <value>
        /// The type of the column.
        /// </value>
        public string ColumnType { get; set; }

        /// <summary>
        /// Gets or sets the default value.
        /// </summary>
        /// <value>
        /// The default value.
        /// </value>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Gets or sets the is case sensitive.
        /// </summary>
        /// <value>
        /// The is case sensitive.
        /// </value>
        public bool? IsCaseSensitive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is identity.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is identity; otherwise, <c>false</c>.
        /// </value>
        public bool IsIdentity { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is nullable.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is nullable; otherwise, <c>false</c>.
        /// </value>
        public bool IsNullable { get; set; }

        /// <summary>
        /// Gets or sets the length.
        /// </summary>
        /// <value>
        /// The length.
        /// </value>
        public int Length { get; set; }
    }
}