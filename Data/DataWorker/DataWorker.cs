// <copyright file = "DataWorker.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.ComponentModel;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="System.ComponentModel.BackgroundWorker" />
    public class DataWorker : BackgroundWorker
    {
        /// <summary>
        /// Gets or sets the unit builder.
        /// </summary>
        /// <value>
        /// The unit builder.
        /// </value>
        public DataModel UnitBuilder { get; set; }

        public DataWorker( )
        {
        }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }
    }
}