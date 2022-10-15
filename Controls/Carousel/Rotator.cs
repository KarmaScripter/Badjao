// <copyright file = "Rotator.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Configuration;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    public abstract class Rotator : Carousel
    {
        /// <summary>
        /// Gets or sets the size of the image.
        /// </summary>
        /// <value>
        /// The size of the image.
        /// </value>
        public Size ImageSize { get; set; }

        /// <summary>
        /// Gets or sets the provider path.
        /// </summary>
        /// <value>
        /// The provider path.
        /// </value>
        public string ProviderPath { get; set; } = ConfigurationManager.AppSettings[ "DbPath" ];

        /// <summary>
        /// Gets or sets the provider path.
        /// </summary>
        /// <value>
        /// The provider path.
        /// </value>
        public string FunctionalityPath { get; set; } =
            ConfigurationManager.AppSettings[ "FunctionalityPath" ];

        protected Rotator( )
        {
            // Basic Carousel Properties
            BackColor = Color.FromArgb( 15, 15, 15 );
            ForeColor = Color.White;
            Font = new Font( "Roboto", 9 );
            CarouselPath = CarouselPath.Default;
            ImageSlides = true;
            Padding = new Padding( 0, 10, 0, 10 );
            PadX = 0;
            PadY = 0;
            Perspective = 4;
            RotateAlways = false;
            ShowImagePreview = true;
            ShowImageShadow = true;
            TransitionSpeed = 2;
            UseOriginalImageinPreview = true;
            UseCustomBounds = false;
            CanOverrideStyle = true;
            VisualStyle = CarouselVisualStyle.Metro;
            FilePath = FunctionalityPath;
            HighlightColor = Color.SteelBlue;

            // ThemeStyle Properties
            ThemeStyle.BackColor = Color.Transparent;
            ThemeStyle.Font = new Font( "Roboto", 9 );
            ThemeStyle.ForeColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.HoverImageBorderColor = Color.FromArgb( 0, 120, 212 );
            ThemeStyle.HoverImageBorderThickness = 2;
            ThemeStyle.ImageShadeColor = Color.FromArgb( 18, 18, 18 );

            // User Properties
            ImageSize = new Size( 250, 250 );
        }
    }
}