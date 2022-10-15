// <copyright file = "ChartConfig.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// This provides the basic application form settings.
    /// </summary>
    /// <seealso cref = "IDisposable"/>
    public class ChartConfig : ChartStyleInfo, IChartConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see/> class.
        /// </summary>
        public ChartConfig( )
        {
            DisplayText = true;
            TextColor = ColorConfig.ForeGray;
            Interior = new BrushInfo( Color.FromArgb( 5, 5, 5 ) );
            Border = SetBorderStyle( ColorConfig.FormDarkBackColor, BorderConfig.Thin );
        }

        /// <summary>
        /// Sets the font.
        /// </summary>
        /// <param name = "font" >
        /// The font.
        /// </param>
        /// <returns>
        /// </returns>
        public static ChartFontInfo SetFont( Font font )
        {
            if( font != null )
            {
                try
                {
                    var _chartFont = new ChartFontInfo
                    {
                        FontStyle = font.Style,
                        FontFamilyTemplate = font.FontFamily,
                        Size = font.Size
                    };

                    return _chartFont;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default( ChartFontInfo );
        }

        /// <summary>
        /// Sets the font.
        /// </summary>
        /// <param name = "family" >
        /// The family.
        /// </param>
        /// <param name = "size" >
        /// The size.
        /// </param>
        /// <param name = "style" >
        /// The style.
        /// </param>
        /// <returns>
        /// </returns>
        public static ChartFontInfo SetFont( string family = "Roboto", int size = 8,
            FontStyle style = FontStyle.Regular )
        {
            if( !string.IsNullOrEmpty( family ) )
            {
                try
                {
                    var chart = new ChartFontInfo
                    {
                        FontStyle = style,
                        Facename = family,
                        Size = size
                    };

                    return chart;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default( ChartFontInfo );
        }

        /// <summary>
        /// Sets the anchor.
        /// </summary>
        /// <param name = "anchor" >
        /// The anchor.
        /// </param>
        /// <returns>
        /// </returns>
        public AnchorStyles SetAnchor( AnchorStyles anchor = AnchorStyles.Left & AnchorStyles.Top )
        {
            try
            {
                return anchor;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( AnchorStyles );
            }
        }

        /// <summary>
        /// Sets the border style.
        /// </summary>
        /// <param name = "color" >
        /// The color.
        /// </param>
        /// <param name = "width" >
        /// The width.
        /// </param>
        /// <returns>
        /// </returns>
        public static ChartLineInfo SetBorderStyle( Color color, int width = 1 )
        {
            try
            {
                var style = new ChartLineInfo
                {
                    Alignment = PenAlignment.Center,
                    Width = width,
                    Color = color
                };

                return style;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ChartLineInfo );
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