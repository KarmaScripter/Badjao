// <copyright file = "Selector.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using Syncfusion.Windows.Forms.Tools;

    public class Selector : Rotator
    {
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
                        var _bitmap = new Bitmap( _stream )
                        {
                            Tag = _name
                        };

                        _list.ImageSize = ImageSize;
                        _list?.Images?.Add( _bitmap );
                    }
                }

                return _list?.Images?.Count > 0
                    ? _list
                    : default( ImageList );
            }

            return default( ImageList );
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
                        var _img = new Bitmap( _stream )
                        {
                            Tag = _name
                        };

                        _list.ImageSize = size;
                        _list?.Images?.Add( _img );
                    }
                }

                return _list?.Images?.Count > 0
                    ? _list
                    : default( ImageList );
            }

            return default( ImageList );
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
                    var _carouselImage = new CarouselImage
                    {
                        ItemImage = _img
                    };

                    _carouselImages.Add( _carouselImage );
                }

                return _carouselImages.Any( )
                    ? _carouselImages
                    : default( IEnumerable<CarouselImage> );
            }

            return default( IEnumerable<CarouselImage> );
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
                var _carouselImages = new List<CarouselImage>( );
                for( var i = 0; i < images?.Count( ); i++ )
                {
                    var _carouselImage = new CarouselImage
                    {
                        ItemImage = _list[ i ]
                    };

                    ImageListCollection.Add( _carouselImage );
                    _carouselImages.Add( _carouselImage );
                }

                return _carouselImages.Any( )
                    ? _carouselImages
                    : default( IEnumerable<CarouselImage> );
            }

            return default( IEnumerable<CarouselImage> );
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
                var _carouselImages = new List<CarouselImage>( );
                for( var i = 0; i < _list?.Count; i++ )
                {
                    if( !string.IsNullOrEmpty( _list[ i ] )
                        && File.Exists( _list[ i ] ) )
                    {
                        using var _stream = File.Open( _list[ i ], FileMode.Open );
                        using var _image = new Bitmap( _stream );
                        var _carouselImage = new CarouselImage
                        {
                            ItemImage = _image
                        };

                        _carouselImages.Add( _carouselImage );
                    }
                }

                return _carouselImages?.Any( ) == true
                    ? _carouselImages
                    : default( IEnumerable<CarouselImage> );
            }

            return default( IEnumerable<CarouselImage> );
        }
    }
}