// <copyright file = "ExcelForm.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using Syncfusion.Windows.Forms;

    public partial class ExcelForm : MetroForm
    {
        public ExcelForm( )
        {
            InitializeComponent( );
            ToolStrip.Office12Mode = true;
        }
    }
}