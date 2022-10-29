//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;

    /// <summary>
    /// 
    /// </summary>
    public interface IButton
    {
        /// <summary>
        /// Sets the color of the fore. Required Attributes: ForeColor
        /// </summary>
        /// <param name="format">The format.</param>
        void SetForeColor( Color format );

        /// <summary>
        /// Sets the state of the back color.
        /// </summary>
        /// <param name="normal">The format.</param>
        /// <param name = "hover" > </param>
        void SetBackColorStyle( Color normal, Color hover );

        /// <summary>
        /// Sets the border configuration. Required Attributes: BorderColor, and HoverColor
        /// </summary>
        /// <param name="normal">The format.</param>
        /// <param name = "hover" > </param>
        void SetBorderStyle( Color normal, Color hover );

        /// <summary>
        /// Sets the text style configuration. Required Attributes: PressedColor, DisabledColor,
        /// EnabledColor, and HoverColor
        /// </summary>
        /// <param name="normal">The format.</param>
        /// <param name = "hover" > </param>
        void SetTextStyle( Color normal, Color hover );

        /// <summary>
        /// Sets the image.
        /// </summary>
        /// <param name="image">The image.</param>
        void SetImage( Image image );

        /// <summary>
        /// Called when [mouse over].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        void OnMouseOver( object sender, EventArgs e );

        /// <summary>
        /// Called when [click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        void OnClick( object sender, EventArgs e );
    }
}