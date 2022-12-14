// <copyright file = "IChartConfig.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Drawing;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    public interface IChartConfig
    {
        /// <summary>
        /// Gets or sets the color of the text.
        /// </summary>
        /// <value>
        /// The color of the text.
        /// </value>
        Color TextColor { get; set; }

        /// <summary>
        /// Gets or sets the font.
        /// </summary>
        /// <value>
        /// The font.
        /// </value>
        ChartFontInfo Font { get; set; }

        /// <summary>
        /// Gets or sets the border.
        /// </summary>
        /// <value>
        /// The border.
        /// </value>
        ChartLineInfo Border { get; set; }

        /// <summary>
        /// Gets or sets the interior.
        /// </summary>
        /// <value>
        /// The interior.
        /// </value>
        BrushInfo Interior { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        string Text { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        string ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the tool tip format.
        /// </summary>
        /// <value>
        /// The tool tip format.
        /// </value>
        string ToolTipFormat { get; set; }

        /// <summary>
        /// Gets or sets the text orientation.
        /// </summary>
        /// <value>
        /// The text orientation.
        /// </value>
        ChartTextOrientation TextOrientation { get; set; }

        /// <summary>
        /// Gets or sets the shadow interior.
        /// </summary>
        /// <value>
        /// The shadow interior.
        /// </value>
        BrushInfo ShadowInterior { get; set; }

        /// <summary>
        /// Gets or sets a value
        /// indicating whether [highlight on mouse over].
        /// </summary>
        /// <value>
        /// <c>true</c>
        /// if [highlight on mouse over]; otherwise,
        /// <c> false </c>.
        /// </value>
        bool HighlightOnMouseOver { get; set; }

        /// <summary>
        /// Gets or sets the highlight interior.
        /// </summary>
        /// <value>
        /// The highlight interior.
        /// </value>
        BrushInfo HighlightInterior { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        string Label { get; set; }

        /// <summary>
        /// Gets or sets the text format.
        /// </summary>
        /// <value>
        /// The text format.
        /// </value>
        string TextFormat { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [display text].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [display text]; otherwise, <c>false</c>.
        /// </value>
        bool DisplayText { get; set; }

        /// <summary>
        /// Resets the color of the text.
        /// </summary>
        void ResetTextColor( );

        /// <summary>
        /// Resets the font.
        /// </summary>
        void ResetFont( );

        /// <summary>
        /// Resets the border.
        /// </summary>
        void ResetBorder( );

        /// <summary>
        /// Resets the interior.
        /// </summary>
        void ResetInterior( );

        /// <summary>
        /// Resets the text.
        /// </summary>
        void ResetText( );

        /// <summary>
        /// Resets the tool tip.
        /// </summary>
        void ResetToolTip( );

        /// <summary>
        /// Resets the tool tip format.
        /// </summary>
        void ResetToolTipFormat( );

        /// <summary>
        /// Resets the images.
        /// </summary>
        void ResetImages( );

        /// <summary>
        /// Resets the call-out.
        /// </summary>
        void ResetCallout( );

        /// <summary>
        /// Resets the text orientation.
        /// </summary>
        void ResetTextOrientation( );

        /// <summary>
        /// Resets the highlight interior.
        /// </summary>
        void ResetHighlightInterior( );

        /// <summary>
        /// Resets the label.
        /// </summary>
        void ResetLabel( );

        /// <summary>
        /// Resets the text format.
        /// </summary>
        void ResetTextFormat( );

        /// <summary>
        /// Resets the display text.
        /// </summary>
        void ResetDisplayText( );
    }
}