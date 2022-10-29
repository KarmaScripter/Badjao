// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    public abstract class DataConfig
    {
        /// <summary>
        /// The source
        /// </summary>
        public virtual Source Source { get; set; }

        /// <summary>
        /// The provider
        /// </summary>
        public virtual Provider Provider { get; set; }

        /// <summary>
        /// The connection builder
        /// </summary>
        public virtual IConnectionBuilder ConnectionBuilder { get; set; }

        /// <summary>
        /// The arguments
        /// </summary>
        public virtual IDictionary<string, object> Map { get; set; }

        /// <summary>
        /// The SQL statement
        /// </summary>
        public virtual ISqlStatement SqlStatement { get; set; }

        /// <summary>
        /// The query
        /// </summary>
        public virtual IQuery Query { get; set; }

        /// <summary>
        /// The record
        /// </summary>
        public virtual DataRow Record { get; set; }

        /// <summary>
        /// The Data table
        /// </summary>
        public virtual DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the columns.
        /// </summary>
        /// <value>
        /// The columns.
        /// </value>
        public virtual IEnumerable<DataColumn> DataColumns { get; set; }

        /// <summary>
        /// Gets or sets the column names.
        /// </summary>
        /// <value>
        /// The column names.
        /// </value>
        public virtual IEnumerable<string> ColumnNames { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public virtual string TableName { get; set; }

        /// <summary>
        /// Gets or sets the Data set.
        /// </summary>
        /// <value>
        /// The Data set.
        /// </value>
        public virtual DataSet DataSet { get; set; }

        /// <summary>
        /// Gets or sets the name of the data set.
        /// </summary>
        /// <value>
        /// The name of the data set.
        /// </value>
        public virtual string DataSetName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataConfig"/> class.
        /// </summary>
        protected DataConfig( )
        {
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}