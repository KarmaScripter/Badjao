// // <copyright file = "IToolStripLabel.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;

    /// <summary>
    /// 
    /// </summary>
    public interface IToolStripLabel
    {
        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="color">The color.</param>
        void SetText( string text, Color color );

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="color">The color.</param>
        /// <param name="font">The font.</param>
        void SetText( string text, Color color, Font font );

        /// <summary>
        /// Called when [mouse hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        void OnMouseHover( object sender, EventArgs e );

        /// <summary>
        /// Sets the font.
        /// </summary>
        /// <param name="font">The font.</param>
        void SetFont( Font font );

        /// <summary>
        /// Sets the color of the fore.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetForeColor( Color color );

        /// <summary>
        /// Sets the color of the back.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetBackColor( Color color );

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        void SetHoverText( string text );
    }
}