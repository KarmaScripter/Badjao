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
    using MetroSet_UI.Enums;
    using VisualPlus.Toolkit.Controls.Interactivity;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ButtonBase" />
    /// <seealso cref="IButton" />
    /// <seealso cref="VisualPlus.Toolkit.Controls.Interactivity.VisualButton" />
    /// <seealso cref="IDisposable" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class Button : MetroSetButton, IButton
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
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Button" />
        /// class.
        /// </summary>
        public Button( )
        {
            // Basic SeriesConfiguration
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "BudgetExecution";
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.LightSteelBlue;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Size = new Size( 140, 40 );
            Location = new Point( 1, 1 );
            Dock = DockStyle.None;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Visible = true;
            Enabled = true;

            // Normal Color Configuration
            NormalColor = Color.Transparent;
            NormalBorderColor = Color.Transparent;
            NormalTextColor = Color.FromArgb( 0, 120, 212 );

            // Hover Color Configuration
            HoverBorderColor = Color.FromArgb( 50, 93, 129 );
            HoverColor = Color.FromArgb( 50, 93, 129 );
            HoverTextColor = Color.LightSteelBlue;

            // Disabled Color Configuration
            DisabledBorderColor = Color.Transparent;
            DisabledBackColor = Color.Transparent;
            DisabledForeColor = Color.Transparent;

            // Pressed Color Configuration
            PressColor = Color.FromArgb( 0, 120, 212 );
            PressBorderColor = Color.FromArgb( 0, 120, 212 );
            PressTextColor = Color.White;

            // Event-Wiring
            MouseHover += OnMouseOver;
            MouseLeave += OnMouseLeave;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Button" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public Button( Size size, Point location )
            : this( )
        {
            Size = size;
            Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Button" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public Button( Size size, Point location, Control parent )
            : this( size, location )
        {
            Parent = parent;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Button" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        /// <param name="text">The text.</param>
        public Button( Size size, Point location, Control parent,
            string text )
            : this( size, location, parent )
        {
            Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Button" />
        /// class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="text">The text displayed by the control.</param>
        public Button( Control parent, string text )
            : this( )
        {
            Parent = parent;
            Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Button" />
        /// class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public Button( Control parent )
            : this( )
        {
            Parent = parent;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Button" />
        /// class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        /// <param name="field">The field.</param>
        public Button( Control parent, Field field )
            : this( )
        {
            Parent = parent;
            Tag = field.ToString( );
        }
        
        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="size">The size.</param>
        public virtual void ReSize( Size size )
        {
            try
            {
                Size = size;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public virtual void ReSize( int width, int height )
        {
            try
            {
                Size = new Size( width, height );
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
        public virtual void SetText( string text )
        {
            try
            {
                Text = text;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="point">The point.</param>
        public virtual void ReLocate( Point point )
        {
            if( point != Point.Empty )
            {
                try
                {
                    Location = point;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public virtual void ReLocate( int x, int y )
        {
            if( x > 0 
               && y > 0 )
            {
                try
                {
                    Location = new Point( x, y  );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Sets the anchor style.
        /// </summary>
        /// <param name="anchor">The anchor.</param>
        public virtual void ReAnchor( AnchorStyles anchor )
        {
            try
            {
                Anchor = Settings.ReAnchor( anchor );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the dock style.
        /// </summary>
        /// <param name="dock">The dock.</param>
        public virtual void ReDock( DockStyle dock )
        {
            try
            {
                Dock = Settings.ReDock( dock );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public virtual void ReTag( object tag )
        {
            try
            {
                Tag = Settings.ReTag( tag );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the tool tip.
        /// </summary>
        /// <param name="tip">The tip.</param>
        public virtual void SetToolTip( string tip )
        {
            try
            {
                Tag = Settings.GetToolTip( this, tip );
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
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void OnMouseLeave( object sender, EventArgs e )
        {
            try
            {
                if( sender is VisualButton _button
                   && _button != null
                   && ToolTip?.Active == true )
                {
                    ToolTip.RemoveAll( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the color of the fore. Required Attributes: ForeColor
        /// </summary>
        public void SetForeColor( Color foreColor )
        {
            if( foreColor != Color.Empty )
            {
                try
                {
                    ForeColor = foreColor;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the state of the back color. Required Attributes: BackColor, DisableColor,
        /// EnabledColor, HoverColor, and PressedColor
        /// </summary>
        /// <param name="normal">The format.</param>
        public void SetBackColor( Color normal )
        {
            if( normal != Color.Empty )
            {
                try
                {
                    BackColor = normal;
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
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public void OnMouseOver( object sender, EventArgs e )
        {
            var _button = sender as Button;

            try
            {
                if( _button != null
                   && !string.IsNullOrEmpty( HoverText ) )
                {
                    if( !string.IsNullOrEmpty( HoverText ) )
                    {
                        var _hoverText = _button?.HoverText;
                        var _ = new MetroTip( _button, _hoverText );
                    }
                    else
                    {
                        if( !string.IsNullOrEmpty( Tag?.ToString( ) ) )
                        {
                            var _text = Tag?.ToString( )?.SplitPascal( );
                            var _ = new MetroTip( _button, _text );
                        }
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public virtual void OnClick( object sender, EventArgs e )
        {
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}