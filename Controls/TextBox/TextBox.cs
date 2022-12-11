// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Drawing;
    using System.Windows.Forms;
    using MetroSet_UI.Enums;

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
            // Basic Properties
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "BudgetExecution";
            BackColor = Color.FromArgb( 40, 40, 40 );
            ForeColor = Color.LightGray;
            BorderColor = Color.FromArgb( 0, 120, 212 );

            // Disabled Color Configuration
            DisabledBackColor = Color.Transparent;
            DisabledBorderColor = Color.Transparent;
            DisabledForeColor = Color.Transparent;
            Font = new Font( "Roboto", 9 );
            HoverColor = Color.FromArgb( 50, 93, 129 );
            TextAlign = HorizontalAlignment.Left;
        }
    }
}