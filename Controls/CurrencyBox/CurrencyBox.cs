//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    public class CurrencyBox : CurrencyBase
    {
        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="CurrencyBox"/> class.
        /// </summary>
        /// <remarks>
        /// The CurrencyEdit class also creates
        /// the controls that it hosts such
        /// as the
        /// <see cref="T:Syncfusion.Windows.Forms.Tools.CurrencyBox" />
        /// control and the
        /// <see cref="T:Syncfusion.Windows.Forms.Tools.PopupCalculator" />
        /// control.
        /// </remarks>
        public CurrencyBox( )
        {
            // Basic Properties
            Size = new Size( 140, 30 );
            Location = new Point( 1, 1 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.White;
            Enabled = true;
            Visible = true;
            Text = string.Empty;
            Border3DStyle = Border3DStyle.Flat;
            PopupCalculatorAlignment = CalculatorPopupAlignment.Right;
            FlatStyle = FlatStyle.Flat;
            ShowCalculator = true;
            TextAlign = HorizontalAlignment.Center;

            // TextBox Properties
            TextBox.CurrencyDecimalDigits = 2;
            TextBox.NegativeColor = Color.Red;
            TextBox.PositiveColor = Color.LightSteelBlue;
            TextBox.BackGroundColor = Color.FromArgb( 30, 30, 30 );
            TextBox.Border3DStyle = Border3DStyle.Flat;
            TextBox.ThemeStyle = CurrencyTextBoxVisualStyle.DefaultStyle;
            TextBox.BorderColor = Color.FromArgb( 41, 41, 41 );
            TextBox.BorderStyle = BorderStyle.Fixed3D;
            TextBox.CurrencyDecimalSeparator = ".";
            TextBox.CurrencyGroupSeparator = ",";
            TextBox.FocusBorderColor = Color.SteelBlue;
            TransferFromCalculator = true;
            TransferToCalculator = true;

            // TextBox ThemeStyle Properties
            ThemeStyle.BackColor = Color.FromArgb( 28, 28, 28 );
            ThemeStyle.BorderColor = Color.FromArgb( 41, 41, 41 );
            ThemeStyle.DisabledBackColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.DisabledBorderColor = Color.FromArgb( 18, 18, 18 );
            ThemeStyle.HoverBorderColor = Color.SteelBlue;
            ThemeStyle.FocusedBorderColor = Color.SteelBlue;
            ThemeStyle.PressedBorderColor = Color.SteelBlue;
        }
    }
}