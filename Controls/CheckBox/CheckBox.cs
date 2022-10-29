//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using VisualPlus.Models;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.CheckBoxBase" />
    public class CheckBox : CheckBoxBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBox"/> class.
        /// </summary>
        public CheckBox( )
        {
            Size = new Size( 125, 25 );
            Box = new Size( 14, 14 );
            BackColor = Color.FromArgb( 15, 15, 15 );
            Font = new Font( "Roboto", 8, FontStyle.Regular );
            ForeColor = Color.SteelBlue;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Cursor = Cursors.Hand;
            Border.Color = Color.FromArgb( 28, 28, 28 );
            Border.HoverColor = Color.FromArgb( 50, 93, 129 );
            Border.HoverVisible = true;
            CheckState = CheckState.Unchecked;
            CheckStyle.Style = CheckStyle.CheckType.Checkmark;
            CheckStyle.CheckColor = Color.Lime;
            BoxColorState.Enabled = Color.FromArgb( 28, 28, 28 );
            BoxColorState.Hover = Color.FromArgb( 50, 93, 129 );
            BoxColorState.Disabled = Color.FromArgb( 15, 15, 15 );
            CheckStyle.AutoSize = true;
            CheckStyle.Bounds = new Rectangle( 0, 0, 125, 23 );
            CheckStyle.Style = CheckStyle.CheckType.Checkmark;
            BoxSpacing = 4;
            MouseHover += OnMouseOver;
            MouseLeave += OnMouseLeave;
        }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Called when [mouse over].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the
        ///     event data.</param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            try
            {
                var _control = sender as CheckBox;

                if( _control is Control _checkBox
                   && !string.IsNullOrEmpty( HoverText ) )
                {
                    _control.Tag = HoverText;
                    var tip = new MetroTip( _checkBox );
                    ToolTip = tip;
                }
                else
                {
                    if( !string.IsNullOrEmpty( Tag?.ToString( ) ) )
                    {
                        var _tool = new MetroTip( _control );
                        ToolTip = _tool;
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [mouse leave].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the
        ///     event data.</param>
        public override void OnMouseLeave( object sender, EventArgs e )
        {
            try
            {
                if( ToolTip?.Active == true )
                {
                    ToolTip.RemoveAll( );
                    ToolTip = null;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}