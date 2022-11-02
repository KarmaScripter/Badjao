// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    public static class Settings
    {
        /// <summary>
        /// Gets or sets the image size icon.
        /// </summary>
        /// <value>
        /// The image size icon.
        /// </value>
        public static Size ImageSizeIcon { get; set; } = new ( 16, 16 );

        /// <summary>
        /// Gets or sets the image size small.
        /// </summary>
        /// <value>
        /// The image size small.
        /// </value>
        public static Size ImageSizeSmall { get; set; } = new ( 20, 20 );

        /// <summary>
        /// Gets or sets the image size medium.
        /// </summary>
        /// <value>
        /// The image size medium.
        /// </value>
        public static Size ImageSizeMedium { get; set; } = new ( 50, 50 );

        /// <summary>
        /// Gets or sets the image size large.
        /// </summary>
        /// <value>
        /// The image size large.
        /// </value>
        public static Size ImageSizeLarge { get; set; } = new ( 100, 100 );

        /// <summary>
        /// Gets or sets the image size large.
        /// </summary>
        /// <value>
        /// The image size large.
        /// </value>
        public static Size ImageSizeHuge { get; set; } = new ( 250, 250 );

        /// <summary>
        /// Gets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        /// <returns></returns>
        public static object ReTag( object tag )
        {
            if( tag != null )
            {
                try
                {
                    return !string.IsNullOrEmpty( tag.ToString( ) )
                        ? tag
                        : default;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <returns></returns>
        public static Size ReSize( int width = 1, int height = 1 )
        {
            try
            {
                return width > -1 && height > -1
                    ? new Size( width, height )
                    : new Size( 1, 1 );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return new Size( 1, 1 );
            }
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns></returns>
        public static Size ReSize( Size size )
        {
            try
            {
                return size.Width > 0 && size.Height > 0
                    ? size
                    : new Size( 1, 1 );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Size.Empty;
            }
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <returns></returns>
        public static Size ReSize( PicSize size )
        {
            if( Enum.IsDefined( typeof( PicSize ), size ) )
            {
                try
                {
                    return size switch
                    {
                        PicSize.Small => new Size( 16, 16 ),
                        PicSize.Medium => new Size( 30, 30 ),
                        PicSize.Large => new Size( 50, 50 ),
                        PicSize.Huge => new Size( 250, 250 ),
                        _ => Size.Empty
                    };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return Size.Empty;
        }

        /// <summary>
        /// Gets the color.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <returns></returns>
        public static Color ReColor( Color color )
        {
            try
            {
                return color != Color.Empty
                    ? color
                    : Color.Transparent;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Color.Empty;
            }
        }

        /// <summary>
        /// Gets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public static string GetText( string text )
        {
            try
            {
                return !string.IsNullOrEmpty( text )
                    ? text
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets the anchor style.
        /// </summary>
        /// <param name="anchor">The anchor.</param>
        /// <returns></returns>
        public static AnchorStyles ReAnchor( AnchorStyles anchor =
            AnchorStyles.Left | AnchorStyles.Top )
        {
            try
            {
                return Enum.IsDefined( typeof( AnchorStyles ), anchor )
                    ? anchor
                    : AnchorStyles.Left | AnchorStyles.Top;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return AnchorStyles.None;
            }
        }

        /// <summary>
        /// Gets the dock style.
        /// </summary>
        /// <param name="doc">The document.</param>
        /// <returns></returns>
        public static DockStyle ReDock( DockStyle doc = DockStyle.None )
        {
            try
            {
                return Enum.IsDefined( typeof( DockStyle ), doc )
                    ? doc
                    : DockStyle.None;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return DockStyle.None;
            }
        }

        /// <summary>
        /// Gets the location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public static Point ReLocate( int x = 1, int y = 1 )
        {
            try
            {
                return x > 0 && y > 0
                    ? new Point( x, y )
                    : new Point( 1, 1 );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Point.Empty;
            }
        }

        /// <summary>
        /// Gets the location.
        /// </summary>
        /// <param name="point">The point.</param>
        /// <returns></returns>
        public static Point ReLocate( Point point )
        {
            if( point.X > -1
               && point.Y > -1 )
            {
                try
                {
                    return point.X > 0 && point.Y > 0
                        ? point
                        : new Point( 1, 1 );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Gets the font.
        /// </summary>
        /// <param name="family">The family.</param>
        /// <param name="size">The size.</param>
        /// <param name="style">The style.</param>
        /// <returns></returns>
        public static Font GetFont( string family = "Roboto",
            int size = 9,
            FontStyle style = FontStyle.Regular )
        {
            try
            {
                return !string.IsNullOrEmpty( family ) && size > 0
                    && Enum.IsDefined( typeof( FontStyle ), style )
                        ? new Font( family, size, style )
                        : new Font( "Roboto", 9, FontStyle.Regular );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the font.
        /// </summary>
        /// <param name="font">The font.</param>
        /// <returns></returns>
        public static Font GetFont( Font font )
        {
            try
            {
                return !string.IsNullOrEmpty( font?.FontFamily?.Name )
                    ? font
                    : new Font( "Roboto", 9, FontStyle.Regular );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the style.
        /// </summary>
        /// <param name="style">
        /// The style.
        /// </param>
        /// <returns></returns>
        public static BorderStyle ReStyleBorder( BorderStyle style = BorderStyle.None )
        {
            try
            {
                return Enum.IsDefined( typeof( BorderStyle ), style )
                    ? style
                    : BorderStyle.None;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return BorderStyle.None;
            }
        }

        /// <summary>
        /// Gets the tool tip.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public static MetroTip GetToolTip( Control control, string text )
        {
            if( control != null
               && !string.IsNullOrEmpty( text ) )
            {
                try
                {
                    return new MetroTip( control, text );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name = "alignment" >
        /// The alignment.
        /// </param>
        /// <returns>
        /// </returns>
        public static StringAlignment GetStringAlignment( StringAlignment alignment =
            StringAlignment.Center )
        {
            try
            {
                return Enum.IsDefined( typeof( StringAlignment ), alignment )
                    ? alignment
                    : StringAlignment.Center;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Sets the string alignment.
        /// </summary>
        /// <param name = "alignment" >
        /// The alignment.
        /// </param>
        /// <returns>
        /// </returns>
        public static HorizontalAlignment GetHorizontalAlignment( HorizontalAlignment alignment =
            HorizontalAlignment.Center )
        {
            try
            {
                return Enum.IsDefined( typeof( HorizontalAlignment ), alignment )
                    ? alignment
                    : HorizontalAlignment.Center;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        public static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}