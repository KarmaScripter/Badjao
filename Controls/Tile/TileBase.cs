// <copyright file = "TileBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="HubTile" />
    public abstract class TileBase : HubTile
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

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
        /// Gets/Sets HubTile Font
        /// </summary>
        public override Font Font { get; set; }

        /// <summary>
        /// Gets or sets the color of the hover.
        /// </summary>
        /// <value>
        /// The color of the hover.
        /// </value>
        public virtual Color HoverColor { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        ///  <see cref="TileBase"/> class.
        /// </summary>
        protected TileBase( )
        {
        }

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public virtual void SetLocation( int x = 1, int y = 1 )
        {
            if( x > 0
                && y > 0 )
            {
                try
                {
                    Location = new Point( x, y );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public virtual void SetSize( int width = 140, int height = 140 )
        {
            if( width > -1
                && height > -1 )
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
        }

        /// <summary>
        /// Sets the image configuration.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="speed">The speed.</param>
        public virtual void SetImageConfiguration( Image image, int speed = 1 )
        {
            if( speed > 0
                && image != null )
            {
                try
                {
                    ImageTransitionSpeed = speed;
                    ImageSource = image;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the type of the tile.
        /// </summary>
        /// <param name="type">The type.</param>
        public virtual void SetTileType( HubTileType type )
        {
            if( Enum.IsDefined( typeof( HubTileType ), type ) )
            {
                try
                {
                    TileType = type;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the title text.
        /// </summary>
        /// <param name="message">The message.</param>
        public virtual void SetTitleText( string message )
        {
            if( !string.IsNullOrEmpty( message )
                && Title != null )
            {
                try
                {
                    Title.Text = message;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the title configuration.
        /// </summary>
        /// <param name="font">The font.</param>
        /// <param name="color">The color.</param>
        public virtual void SetTitleConfiguration( Font font, Color color )
        {
            if( font != null
                && color != Color.Empty )
            {
                try
                {
                    Title.Font = font;
                    Title.TextColor = color;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the body text.
        /// </summary>
        /// <param name="message">The message.</param>
        public virtual void SetBodyText( string message )
        {
            if( !string.IsNullOrEmpty( message )
                && Body != null )
            {
                try
                {
                    Body.Text = message;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the body configuration.
        /// </summary>
        /// <param name="font">The font.</param>
        /// <param name="color">The color.</param>
        public virtual void SetBodyConfiguration( Font font, Color color )
        {
            if( font != null
                && color != Color.Empty )
            {
                try
                {
                    Body.Font = font;
                    Body.TextColor = color;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the banner text.
        /// </summary>
        /// <param name="message">The message.</param>
        public virtual void SetBannerText( string message )
        {
            if( !string.IsNullOrEmpty( message )
                && Banner != null
                && ShowBanner )
            {
                try
                {
                    Banner.Text = message;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the banner configuration.
        /// </summary>
        /// <param name="font">The font.</param>
        /// <param name="color">The color.</param>
        /// <param name="height">The height.</param>
        public virtual void SetBannerConfiguration( Font font, Color color, int height )
        {
            if( font != null
                && color != Color.Empty )
            {
                try
                {
                    ShowBanner = true;
                    BannerHeight = height;
                    Banner.Font = font;
                    BannerColor = color;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the banner icon.
        /// </summary>
        /// <param name="image">The image.</param>
        public virtual void SetBannerIcon( Image image )
        {
            if( image != null
                && Banner != null )
            {
                try
                {
                    ShowBannerIcon = true;
                    BannerIcon = image;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the slide transition.
        /// </summary>
        /// <param name="direction">The direction.</param>
        public virtual void SetSlideTransition(
            TransitionDirection direction = TransitionDirection.RightToLeft )
        {
            if( Enum.IsDefined( typeof( TransitionDirection ), direction ) )
            {
                try
                {
                    SlideTransition = direction;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}