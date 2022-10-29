//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using MetroSet_UI.Controls;
    using MetroSet_UI.Design;
    using CheckState = MetroSet_UI.Enums.CheckState;

    public class RadioButton : MetroSetRadioButton
    {
        /// <summary>
        /// Initializes a new instance of the 
        /// <see cref="RadioButton"/> class.
        /// </summary>
        public RadioButton( )
        {
            BackgroundColor = Color.FromArgb( 30, 30, 30 );
            ForeColor = Color.FromArgb( 0, 120, 212 );
            CheckSignColor = Color.LimeGreen;
            BorderColor = Color.FromArgb( 0, 120, 212 );
            Style = Style.Custom;
            Size = new Size( 125, 17 );
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Execution";
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Font = new Font( "Roboto", 9, FontStyle.Regular );
            Dock = DockStyle.None;
            CheckState = CheckState.Unchecked;
            CheckedChanged += OnCheckStateChanged;
            MouseEnter += OnMouseHover;
            MouseLeave += OnMouseLeave;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RadioButton"/> class.
        /// </summary>
        /// <param name="text">The text displayed by the control.</param>
        public RadioButton( string text )
            : this( )
        {
            Text = text;
        }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public MetroTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public virtual string Result { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Called when [check state changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        public void OnCheckStateChanged( object sender )
        {
            if( sender is RadioButton radioButton
               && radioButton.Tag != null )
            {
                try
                {
                    Result = radioButton.Tag?.ToString( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [mouse over].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the
        ///     event data.</param>
        public virtual void OnMouseHover( object sender, EventArgs e )
        {
            try
            {
                var _control = sender as RadioButton;

                if( _control is RadioButton _radioButton
                   && !string.IsNullOrEmpty( HoverText ) )
                {
                    var tip = new MetroTip( _radioButton, HoverText );
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
        public virtual void OnMouseLeave( object sender, EventArgs e )
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

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The exception.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}