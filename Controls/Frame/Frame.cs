// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class Frame : UserControl
    {
        public int Index { get; set; }

        public BindingSource BindingSource { get; set; }

        public Frame( )
        {
            InitializeComponent( );
            Table.BackColor = Color.Transparent;
            Table.ColumnCount = 1;
            Table.RowCount = 2;
            Table.Font = new Font( "Roboto", 9 );
            Table.ForeColor = Color.LightGray;
        }
    }
}
