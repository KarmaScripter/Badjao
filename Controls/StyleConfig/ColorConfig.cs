// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using OfficeOpenXml.Style;
    using Syncfusion.XlsIO;

    /// <summary>
    /// 
    /// </summary>
    public class ColorConfig
    {
        /// <summary>
        /// The border dark
        /// </summary>
        public static readonly Color BorderDark = Color.FromArgb( 25, 18, 1 );

        /// <summary>
        /// The border blue
        /// </summary>
        public static readonly Color BorderBlue = Color.FromArgb( 0, 120, 212 );

        /// <summary>
        /// The border red
        /// </summary>
        public static readonly Color BorderRed = Color.FromArgb( 192, 0, 0 );

        /// <summary>
        /// The form dark back color
        /// </summary>
        public static readonly Color FormDarkBackColor = Color.FromArgb( 20, 20, 20 );

        /// <summary>
        /// The hover yellow
        /// </summary>
        public static readonly Color HoverYellow = Color.FromArgb( 24, 19, 1 );

        /// <summary>
        /// The fore red
        /// </summary>
        public static readonly Color ForeRed = Color.FromArgb( 192, 0, 0 );

        /// <summary>
        /// The fore gray
        /// </summary>
        public static readonly Color ForeGray = Color.FromArgb( 141, 139, 138 );

        /// <summary>
        /// The fore white
        /// </summary>
        public static readonly Color ForeWhite = Color.White;

        /// <summary>
        /// The fore black
        /// </summary>
        public static readonly Color ForeBlack = Color.Black;

        /// <summary>
        /// The control interior color
        /// </summary>
        public static readonly Color ControlInteriorColor = Color.FromArgb( 40, 40, 40 );

        /// <summary>
        /// The transparent
        /// </summary>
        public static readonly Color Transparent = Color.Transparent;

        /// <summary>
        /// The hover gray
        /// </summary>
        public static readonly Color HoverGray = Color.FromArgb( 70, 70, 70 );

        /// <summary>
        /// The hover blue
        /// </summary>
        public static readonly Color HoverBlue = Color.FromArgb( 50, 93, 129 );

        /// <summary>
        /// Initializes a new instance of the <see cref="ColorConfig"/> class.
        /// </summary>
        public ColorConfig( )
        {
        }
        
        /// <summary>
        /// Called when [color changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public static void OnColorChanged( object sender, EventArgs e )
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