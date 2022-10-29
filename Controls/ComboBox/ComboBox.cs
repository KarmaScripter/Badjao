//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.ComboBoxBase" />
    public class ComboBox : ComboBoxBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComboBox"/> class.
        /// </summary>
        public ComboBox( )
        {
            ButtonColor = Color.FromArgb( 0, 120, 212 );
            BackColor = Color.FromArgb( 30, 30, 30 );
            ForeColor = Color.LightSteelBlue;
            FlatStyle = FlatStyle.Flat;
            DropDownStyle = ComboBoxStyle.DropDownList;
            ItemHeight = 24;
            Font = new Font( "Roboto", 9 );
            MenuItemHover = Color.FromArgb( 22, 39, 70 );
            MenuItemNormal = Color.FromArgb( 30, 30, 30 );
            MenuTextColor = Color.LightSteelBlue;
            BackColorState.Disabled = Color.FromArgb( 30, 30, 30 );
            BackColorState.Enabled = Color.FromArgb( 30, 30, 30 );
            Border.HoverColor = Color.FromArgb( 0, 120, 212 );
            Border.Color = Color.FromArgb( 65, 65, 65 );
            Border.HoverVisible = true;
        }
    }
}