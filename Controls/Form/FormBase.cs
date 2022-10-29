// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExeuction
{
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    public partial class FormBase : MetroForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormBase"/> class.
        /// </summary>
        public FormBase( )
        {
            InitializeComponent( );
            Font = new Font( "Roboto", 9 );
            BackColor = Color.FromArgb( 15, 15, 15 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            CaptionAlign = HorizontalAlignment.Center;
            CaptionBarColor = Color.FromArgb( 15, 15, 15 );
            CaptionFont = new Font( "Roboto", 11 );
            ShowIcon = false;
            ShowInTaskbar = true;
            CaptionButtonColor = Color.FromArgb( 0, 120, 212 );
            CaptionButtonHoverColor = Color.DarkRed;
            BorderThickness = 1;
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MetroColor = Color.FromArgb( 15, 15, 15 );
            ShowMaximizeBox = false;
            ShowMinimizeBox = false;
            ShowMouseOver = true;
            Size = new Size( 1400, 800 );
            StartPosition = FormStartPosition.CenterScreen;
            Text = string.Empty;
        }
    }
}