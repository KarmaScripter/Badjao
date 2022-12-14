// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    public class Selector : Carousel
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        public virtual IEnumerable<Image> Images { get; set; }
        
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
        public string FunctionalityPath { get; set; } =
            ConfigurationManager.AppSettings[ "FunctionalityPath" ];

        /// <summary>
        /// Gets or sets the fund path.
        /// </summary>
        /// <value>
        /// The fund path.
        /// </value>
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="Selector"/> class.
        /// </summary>
        public Selector( )
        {
            // Basic Carousel Properties
            BackColor = Color.FromArgb( 20, 20, 20 );
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

        /// <summary>
        /// Creates the image list.
        /// </summary>
        /// <param name="sourceDirectory">The source dir.</param>
        /// <returns></returns>
        public ImageList CreateImageList( string sourceDirectory )
        {
            if( Directory.Exists( sourceDirectory ) )
            {
                var _files = Directory.GetDirectories( sourceDirectory );
                var _paths = _files?.ToList( );
                var _list = new ImageList( );

                for( var i = 0; i < _paths.Count; i++ )
                {
                    if( !string.IsNullOrEmpty( _paths[ i ] )
                       && File.Exists( _paths[ i ] ) )
                    {
                        var _name = Path.GetFileNameWithoutExtension( _paths[ i ] );
                        using var _stream = File.Open( _paths[ i ], FileMode.Open );
                        var _bitmap = new Bitmap( _stream ) ;
                        _bitmap.Tag = _name;
                        _list.ImageSize = ImageSize;
                        _list?.Images?.Add( _bitmap );
                    }
                }

                return _list?.Images?.Count > 0
                    ? _list
                    : default;
            }

            return default;
        }

        /// <summary>
        /// Creates the image list.
        /// </summary>
        /// <param name="sourceDirectory">The source dir.</param>
        /// <param name = "size" > </param>
        /// <returns></returns>
        public ImageList CreateImageList( string sourceDirectory, Size size )
        {
            if( Directory.Exists( sourceDirectory ) )
            {
                var _files = Directory.GetDirectories( sourceDirectory );
                var _paths = _files?.ToList( );
                var _list = new ImageList( );

                for( var i = 0; i < _paths.Count; i++ )
                {
                    if( !string.IsNullOrEmpty( _paths[ i ] )
                       && File.Exists( _paths[ i ] ) )
                    {
                        var _name = Path.GetFileNameWithoutExtension( _paths[ i ] );
                        using var _stream = File.Open( _paths[ i ], FileMode.Open );
                        var _img = new Bitmap( _stream ) ;
                        _img.Tag = _name;
                        _list.ImageSize = size;
                        _list?.Images?.Add( _img );
                    }
                }

                return _list?.Images?.Count > 0
                    ? _list
                    : default;
            }

            return default;
        }

        /// <summary>
        /// Creates the carousel items.
        /// </summary>
        /// <param name="paths">The images.</param>
        /// <returns></returns>
        public IEnumerable<CarouselImage> CreateCarouselItems( IEnumerable<string> paths )
        {
            if( paths?.Any( ) == true )
            {
                var _list = paths.ToList( );
                var _carouselImages = new List<CarouselImage>( );

                for( var i = 0; i < _list?.Count; i++ )
                {
                    using var _stream = File.Open( _list[ i ], FileMode.Open );
                    using var _img = new Bitmap( _stream );
                    var _carouselImage = new CarouselImage( ) ;
                    _carouselImage.ItemImage = _img;
                    _carouselImages.Add( _carouselImage );
                }

                return _carouselImages.Any( )
                    ? _carouselImages
                    : default( IEnumerable<CarouselImage> );
            }

            return default;
        }

        /// <summary>
        /// Creates the carousel items.
        /// </summary>
        /// <param name="images">The images.</param>
        /// <returns></returns>
        public IEnumerable<CarouselImage> CreateCarouselItems( IEnumerable<Image> images )
        {
            if( images?.Any( ) == true )
            {
                var _list = images.ToList( );
                var _images = new List<CarouselImage>( );

                for( var i = 0; i < images?.Count( ); i++ )
                {
                    var _carouselImage = new CarouselImage( ) ;
                    _carouselImage.ItemImage = _list[ i ];
                    ImageListCollection.Add( _carouselImage );
                    _images.Add( _carouselImage );
                }

                return _images.Any( )
                    ? _images
                    : default( IEnumerable<CarouselImage> );
            }

            return default;
        }

        /// <summary>
        /// Creates the carousel items.
        /// </summary>
        /// <param name="srcDir">The source path.</param>
        /// <returns></returns>
        public IEnumerable<CarouselImage> CreateCarouselItems( string srcDir )
        {
            if( !string.IsNullOrEmpty( srcDir )
               && Directory.Exists( srcDir ) )
            {
                var _files = Directory.GetDirectories( srcDir );
                var _list = _files?.ToList( );
                var _images = new List<CarouselImage>( );

                for( var i = 0; i < _list?.Count; i++ )
                {
                    if( !string.IsNullOrEmpty( _list[ i ] )
                       && File.Exists( _list[ i ] ) )
                    {
                        using var _stream = File.Open( _list[ i ], FileMode.Open );
                        using var _image = new Bitmap( _stream );
                        var _carouselImage = new CarouselImage( ) ;
                        _carouselImage.ItemImage = _image;
                        _images.Add( _carouselImage );
                    }
                }

                return _images?.Any( ) == true
                    ? _images
                    : default( IEnumerable<CarouselImage> );
            }

            return default;
        }

        /// <summary>
        /// Sets the image.
        /// </summary>
        /// <param name="image">The image.</param>
        public virtual void AddImage( Image image )
        {
            if( image != null )
            {
                try
                {
                    ImageList.Images.Add( image );
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
        protected void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}