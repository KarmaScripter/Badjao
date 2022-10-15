// <copyright file = "SpreadsheetBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Spreadsheet;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Spreadsheet" />
    /// <seealso cref="ISpreadsheet" />
    public abstract class SpreadsheetBase : Spreadsheet, ISpreadsheet
    {
        /// <summary>
        /// Gets or sets the grid.
        /// </summary>
        /// <value>
        /// The grid.
        /// </value>
        public SpreadsheetGrid Grid { get; set; }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public SpreadsheetGridModel Model { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SpreadsheetBase"/> class.
        /// </summary>
        protected SpreadsheetBase( )
        {
            CanApplyTheme = true;
            CanOverrideStyle = true;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            BackColor = Color.FromArgb( 15, 15, 15 );
            ForeColor = Color.Black;
            Font = new Font( "Roboto", 9, FontStyle.Regular );
            DefaultColumnCount = 26;
            DefaultRowCount = 66;
            AllowZooming = true;
        }

        /// <summary>
        /// Opens the file.
        /// </summary>
        /// <param name="file">The file.</param>
        public virtual void OpenFile( Stream file )
        {
        }

        /// <summary>
        /// Displays the message box.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        /// <param name="button">The button.</param>
        /// <param name="icon">The icon.</param>
        /// <returns></returns>
        public virtual bool DisplayMessageBox( string text, string caption,
            MessageBoxButtons button, MessageBoxIcon icon )
        {
            return false;
        }
    }
}