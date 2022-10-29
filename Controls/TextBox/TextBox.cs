// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Drawing;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.TextBoxBase" />
    public class TextBox : TextBoxBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextBox"/> class.
        /// </summary>
        public TextBox( )
        {
            BackColor = Color.FromArgb( 30, 30, 30 );
            ForeColor = Color.LightSteelBlue;
            Font = new Font( "Roboto", 9 );
            BackColorState.Disabled = Color.FromArgb( 30, 30, 30 );
            BackColorState.Enabled = Color.FromArgb( 30, 30, 30 );
            Border.HoverColor = Color.FromArgb( 0, 120, 212 );
            Border.Color = Color.FromArgb( 65, 65, 65 );
            Border.HoverVisible = true;
        }
    }
}