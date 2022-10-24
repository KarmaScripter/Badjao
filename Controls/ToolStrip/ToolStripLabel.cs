// <copyright file = "ToolStripLabel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ToolStripLabel : ToolStripLabelBase, IToolStripLabel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "ToolStripLabel"/>
        /// class.
        /// </summary>
        public ToolStripLabel( )
        {
            Margin = new Padding( 5, 5, 5, 5 );
            Padding = new Padding( 0 );
            Size = new Size( 150, 23 );
            ForeColor = Color.White;
            BackColor = Color.FromArgb( 45, 45, 45 );
            Font = new Font( "Roboto", 9, FontStyle.Regular );
            Tag = Name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolStripLabel"/> class.
        /// </summary>
        /// <param name="text">The text to display
        /// on the <see/>.</param>
        public ToolStripLabel( string text )
            : this( )
        {
            Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolStripLabel"/> class.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="hoverText">The hover text.</param>
        public ToolStripLabel( string text, string hoverText = "" )
            : this( text )
        {
            HoverText = hoverText;
            MouseHover += OnMouseHover;
        }

        /// <summary> Sets the text. </summary>
        /// <param name = "text" > The text. </param>
        /// <param name = "color" > The color. </param>
        public void SetText( string text, Color color )
        {
            try
            {
                ForeColor = color != Color.Empty
                    ? color
                    : Color.Empty;

                Text = !string.IsNullOrEmpty( text )
                    ? text
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <param name="font">The font.</param>
        /// <param name="color">The color.</param>
        public void SetText( string text, Color color, Font font )
        {
            try
            {
                Font = font ?? new Font( "Roboto", 9 );

                ForeColor = color != Color.Empty
                    ? color
                    : Color.Empty;

                Text = !string.IsNullOrEmpty( text )
                    ? text
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary> Sets the text. </summary>
        /// <param name = "text" > The text. </param>
        public void SetHoverText( string text )
        {
            try
            {
                HoverText = !string.IsNullOrEmpty( text )
                    ? text
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [mouse hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" /> instance
        /// containing the event data.</param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            if( sender is ToolStripLabel _label
               && !string.IsNullOrEmpty( _label?.HoverText ) )
            {
                try
                {
                    if( !string.IsNullOrEmpty( HoverText ) )
                    {
                        var _text = _label?.HoverText;
                        var _ = new MetroTip( this, _text );
                    }
                    else
                    {
                        if( !string.IsNullOrEmpty( Tag?.ToString( ) ) )
                        {
                            var _text = Tag?.ToString( )?.SplitPascal( );
                            var _ = new MetroTip( _label, _text );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}