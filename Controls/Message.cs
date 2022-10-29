//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class Message : MetroForm
    {
        public Message( )
        {
            InitializeComponent( );
            Size = new Size( 621, 412 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BorderColor = Color.SteelBlue;
            CloseButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OpenButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OpenButton.Text = "Open";
            OpenButton.ForeColor = Color.SteelBlue;
            OpenButton.BackColor = Color.FromArgb( 15, 15, 15 );
            CloseButton.Text = "Close";
            CloseButton.ForeColor = Color.SteelBlue;
            CloseButton.BackColor = Color.FromArgb( 15, 15, 15 );
            CloseButton.Click += OnCloseButtonClick;
            OpenButton.Click += OnOpenButtonClick;
            BackColor = Color.FromArgb( 15, 15, 15 );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        /// <param name="text">The text displayed by the control.</param>
        public Message( string text )
            : this( )
        {
            TextBox.Text = Environment.NewLine + text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="caption">The caption.</param>
        public Message( string text, string caption )
            : this( text )
        {
            Label.Text = caption;
        }

        /// <summary>
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void OnCloseButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button
               && !string.IsNullOrEmpty( _button?.Name ) )
            {
                try
                {
                    Close( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        public virtual void OnOpenButtonClick( object sender, EventArgs e )
        {
            if( sender is Button _button
               && !string.IsNullOrEmpty( _button?.Name ) )
            {
                try
                {
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}