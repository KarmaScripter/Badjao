// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using CheckState = MetroSet_UI.Enums.CheckState;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.CheckBoxBase" />
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public class CheckBox : CheckBoxBase
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CheckBox"/> class.
        /// </summary>
        public CheckBox( )
        {
            Size = new Size( 125, 25 );
            BackColor = Color.FromArgb( 15, 15, 15 );
            Font = new Font( "Roboto", 8, FontStyle.Regular );
            ForeColor = Color.SteelBlue;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Cursor = Cursors.Hand;
            BorderColor = Color.FromArgb( 28, 28, 28 );
            CheckState = CheckState.Unchecked;

            // Disabled Color Configuration
            DisabledBorderColor = Color.Transparent;

            // Event Wiring
            MouseHover += OnMouseOver;
            MouseLeave += OnMouseLeave;
        }

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