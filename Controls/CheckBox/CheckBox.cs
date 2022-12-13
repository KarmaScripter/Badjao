// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using MetroSet_UI.Controls;
    using CheckState = MetroSet_UI.Enums.CheckState;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.CheckBoxBase" />
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public class CheckBox : MetroSetCheckBox
    {
        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public virtual MetroTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

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
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public virtual void OnMouseOver( object sender, EventArgs e )
        {
            var _checkBox = sender as CheckBox;

            try
            {
                if( _checkBox != null
                   && !string.IsNullOrEmpty( HoverText ) )
                {
                    var _hoverText = _checkBox?.HoverText;
                    var _ = new MetroTip( _checkBox, _hoverText );
                }
                else
                {
                    if( !string.IsNullOrEmpty( Tag?.ToString( ) ) )
                    {
                        var _text = Tag?.ToString( )?.SplitPascal( );
                        var _ = new MetroTip( _checkBox, _text );
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
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.
        /// </param>
        public virtual void OnMouseLeave( object sender, EventArgs e )
        {
            var _checkBox = sender as CheckBox;

            try
            {
                if( _checkBox != null )
                {
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
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}