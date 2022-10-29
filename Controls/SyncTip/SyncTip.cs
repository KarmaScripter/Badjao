//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System.Windows.Forms;

    public class SyncTip : SyncTipBase
    {
        public SyncTip( )
        {
        }

        public SyncTip( Control control, string text, string title = "" )
            : this( )
        {
        }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }
    }
}