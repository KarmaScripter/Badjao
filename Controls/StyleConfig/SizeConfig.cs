//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;

    /// <summary>
    /// 
    /// </summary>
    public class SizeConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref = "SizeConfig"/> class.
        /// </summary>
        public SizeConfig( )
        {
        }

        /// <summary>
        /// Gets the size of the normal form.
        /// </summary>
        /// <value>
        /// The size of the normal form.
        /// </value>
        public static readonly Size FormNormal = new ( 1200, 750 );

        /// <summary>
        /// Gets the maximum size of the form.
        /// </summary>
        /// <value>
        /// The maximum size of the form.
        /// </value>
        public static readonly Size FormMaximum = new ( 1500, 820 );

        /// <summary>
        /// Gets the minimum size of the form.
        /// </summary>
        /// <value>
        /// The minimum size of the form.
        /// </value>
        public static readonly Size FormMinimum = new ( 600, 400 );

        /// <summary>
        /// The dialog size normal
        /// </summary>
        public static readonly Size DialogNormal = new ( 680, 530 );

        /// <summary>
        /// The form size maximum
        /// </summary>
        public static readonly Size DialogMinimum = new ( 300, 300 );

        /// <summary>
        /// The form size minimum
        /// </summary>
        public static readonly Size DialogMaximum = new ( 800, 800 );

        /// <summary>
        /// The column configuration size
        /// </summary>
        public static readonly Size ContextMenuNormal = new ( 250, 350 );

        /// <summary>
        /// The small
        /// </summary>
        public static readonly Size ImageSmall = new ( 12, 12 );

        /// <summary>
        /// The medium
        /// </summary>
        public static readonly Size ImageMedium = new ( 16, 16 );

        /// <summary>
        /// The large
        /// </summary>
        public static readonly Size ImageLarge = new ( 20, 20 );

        /// <summary>
        /// The largest
        /// </summary>
        public static readonly Size ImageHuge = new ( 250, 250 );

        /// <summary>
        /// Gets or sets the size of the client.
        /// </summary>
        /// <value>
        /// The size of the client.
        /// </value>
        public Size ClientSize { get; set; }

        /// <summary>
        /// Gets or sets the bounds.
        /// </summary>
        /// <value>
        /// The bounds.
        /// </value>
        public Size Bounds { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        /// <value>
        /// The width.
        /// </value>
        public int Width { get; set; }

        /// <summary>
        /// Sets the color.
        /// </summary>
        /// <param name = "width" >
        /// The width.
        /// </param>
        /// <param name = "height" >
        /// The height.
        /// </param>
        /// <returns>
        /// </returns>
        public static Size GetSize( int width = 1, int height = 1 )
        {
            try
            {
                return width > 0 && height > 0
                    ? new Size( width, height )
                    : Size.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name = "size" >
        /// The size.
        /// </param>
        /// <returns>
        /// </returns>
        public static Size GetSize( Size size )
        {
            if( size.Width > -1
               && size.Height > -1 )
            {
                try
                {
                    return size;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default;
        }

        /// <summary>
        /// Called when [size changed].
        /// </summary>
        /// <param name = "sender" >
        /// The sender.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "EventArgs"/> instance containing the event data.
        /// </param>
        public static void OnSizeChanged( object sender, EventArgs e )
        {
            if( sender != null
               && e != null )
            {
                try
                {
                    var message = new Message( "NOT YET IMPLEMENTED" );
                    message?.ShowDialog( );
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
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}