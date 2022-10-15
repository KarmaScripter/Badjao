// // <copyright file = "IToolStripTextBox.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    public interface IToolStripTextBox
    {
        /// <summary>
        /// Sets the hover text.
        /// </summary>
        /// <param name="item">The item.</param>
        void SetHoverText( ToolStripItem item );

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        void ResetText( string text );

        /// <summary>
        /// Clears this instance.
        /// </summary>
        void Clear( );
    }
}