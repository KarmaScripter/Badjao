//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System.Drawing;

    /// <summary>
    /// 
    /// </summary>
    public class TextItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextItem"/> class.
        /// </summary>
        public TextItem( )
        {
            HeaderFont = new Font( "Roboto", 10, FontStyle.Regular );
            HeaderAlignment = ContentAlignment.TopLeft;
            HeaderForeColor = Color.FromArgb( 0, 120, 212 );
            BodyFont = new Font( "Roboto", 9, FontStyle.Regular );
            BodyAlignment = ContentAlignment.MiddleLeft;
            BodyForeColor = Color.LightSteelBlue;
            FooterFont = new Font( "Roboto", 8, FontStyle.Regular );
            FooterAlignment = ContentAlignment.BottomLeft;
            FooterForeColor = Color.LightSteelBlue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextItem"/> class.
        /// </summary>
        /// <param name="bodyText">The body text.</param>
        public TextItem( string bodyText )
            : this( )
        {
            HeaderText = string.Empty;
            BodyText = bodyText;
            FooterText = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextItem"/> class.
        /// </summary>
        /// <param name="headerText">The header text.</param>
        /// <param name="bodyText">The body text.</param>
        public TextItem( string headerText, string bodyText )
            : this( )
        {
            HeaderText = headerText;
            BodyText = bodyText;
            FooterText = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextItem"/> class.
        /// </summary>
        /// <param name="headerText">The header text.</param>
        /// <param name="bodyText">The body text.</param>
        /// <param name="footerText">The footer text.</param>
        public TextItem( string headerText, string bodyText, string footerText )
            : this( )
        {
            HeaderText = headerText;
            BodyText = bodyText;
            FooterText = footerText;
        }

        /// <summary>
        /// Gets or sets the header text.
        /// </summary>
        /// <value>
        /// The header text.
        /// </value>
        public string HeaderText { get; set; }

        /// <summary>
        /// Gets or sets the header font.
        /// </summary>
        /// <value>
        /// The header font.
        /// </value>
        public Font HeaderFont { get; set; }

        /// <summary>
        /// Gets or sets the header alignment.
        /// </summary>
        /// <value>
        /// The header alignment.
        /// </value>
        public ContentAlignment HeaderAlignment { get; set; }

        /// <summary>
        /// Gets or sets the color of the header fore.
        /// </summary>
        /// <value>
        /// The color of the header fore.
        /// </value>
        public Color HeaderForeColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the header back.
        /// </summary>
        /// <value>
        /// The color of the header back.
        /// </value>
        public Color HeaderBackColor { get; set; }

        /// <summary>
        /// Gets or sets the body text.
        /// </summary>
        /// <value>
        /// The body text.
        /// </value>
        public string BodyText { get; set; }

        /// <summary>
        /// Gets or sets the body font.
        /// </summary>
        /// <value>
        /// The body font.
        /// </value>
        public Font BodyFont { get; set; }

        /// <summary>
        /// Gets or sets the body alignment.
        /// </summary>
        /// <value>
        /// The body alignment.
        /// </value>
        public ContentAlignment BodyAlignment { get; set; }

        /// <summary>
        /// Gets or sets the color of the body fore.
        /// </summary>
        /// <value>
        /// The color of the body fore.
        /// </value>
        public Color BodyForeColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the body back.
        /// </summary>
        /// <value>
        /// The color of the body back.
        /// </value>
        public Color BodyBackColor { get; set; }

        /// <summary>
        /// Gets or sets the footer text.
        /// </summary>
        /// <value>
        /// The footer text.
        /// </value>
        public string FooterText { get; set; }

        /// <summary>
        /// Gets or sets the footer font.
        /// </summary>
        /// <value>
        /// The footer font.
        /// </value>
        public Font FooterFont { get; set; }

        /// <summary>
        /// Gets or sets the footer alignment.
        /// </summary>
        /// <value>
        /// The footer alignment.
        /// </value>
        public ContentAlignment FooterAlignment { get; set; }

        /// <summary>
        /// Gets or sets the color of the footer fore.
        /// </summary>
        /// <value>
        /// The color of the footer fore.
        /// </value>
        public Color FooterForeColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the footer back.
        /// </summary>
        /// <value>
        /// The color of the footer back.
        /// </value>
        public Color FooterBackColor { get; set; }
    }
}