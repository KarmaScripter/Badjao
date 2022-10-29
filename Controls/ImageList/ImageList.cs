//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;

    public class ImageList : ImageListBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageList"/> class.
        /// </summary>
        public ImageList( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageList"/> class.
        /// </summary>
        /// <param name = "imageImageSource" >
        /// The image source.
        /// </param>
        /// <param name = "size" >
        /// The size.
        /// </param>
        public ImageList( ImageDirectory imageImageSource, Size size )
        {
            ImageSource = imageImageSource;
            ImageSize = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ImageList"/> class.
        /// </summary>
        /// <param name = "path" >
        /// The image source.
        /// </param>
        /// <param name = "size" >
        /// The size.
        /// </param>
        public ImageList( string path, Size size )
        {
            ImageSource = ImageDirectory.NS;
            ImageSize = size;
            Images.Add( new Bitmap( path ) );
        }

        /// <summary>
        /// Gets or sets the image source.
        /// </summary>
        /// <value>
        /// The image source.
        /// </value>
        public ImageDirectory ImageSource { get; set; }

        /// <summary>
        /// Gets or sets the image.
        /// </summary>
        /// <value>
        /// The image.
        /// </value>
        public Image Image { get; set; }

        /// <summary>
        /// Gets or sets the file names.
        /// </summary>
        /// <value>
        /// The file names.
        /// </value>
        public IEnumerable<string> FileNames { get; set; }

        /// <summary>
        /// Gets or sets the file names.
        /// </summary>
        /// <value>
        /// The file names.
        /// </value>
        public IEnumerable<string> FilePaths { get; set; }

        /// <summary>
        /// Adds the specified image.
        /// </summary>
        /// <param name="image">The image.</param>
        public void Add( Image image )
        {
            if( image != null )
            {
                try
                {
                    Images.Add( image );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Adds the specified path.
        /// </summary>
        /// <param name="path">The path.</param>
        public void Add( string path )
        {
            if( !string.IsNullOrEmpty( path )
               && File.Exists( path ) )
            {
                try
                {
                    var _name = Path.GetFileName( path );
                    var _image = new Bitmap( path );

                    if( _image != null )
                    {
                        Images.Add( _name, _image );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Adds the specified paths.
        /// </summary>
        /// <param name="paths">The paths.</param>
        public void Add( string[ ] paths )
        {
            if( paths?.Any( ) == true )
            {
                try
                {
                    foreach( var _file in paths )
                    {
                        if( File.Exists( _file ) )
                        {
                            var _name = Path.GetFileName( _file );
                            var _image = new Bitmap( _file );

                            if( _image != null )
                            {
                                Images.Add( _name, _image );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Adds the specified paths.
        /// </summary>
        /// <param name="image">The paths.</param>
        public void Remove( Image image )
        {
            if( image != null
               && Images?.Contains( image ) == true )
            {
                try
                {
                    Images.Remove( image );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Creates the images.
        /// </summary>
        /// <param name="srcDir">The source dir.</param>
        /// <returns></returns>
        public IEnumerable<Image> CreateImages( string srcDir )
        {
            if( Directory.Exists( srcDir ) )
            {
                IEnumerable<string> _files = Directory.GetFiles( srcDir );
                var _list = new List<Image>( );

                if( _files?.Count( ) > 0 )
                {
                    foreach( var _file in _files )
                    {
                        using var _stream = File.Open( _file, FileMode.Open );
                        using var _img = new Bitmap( _stream );
                        _list.Add( _img );
                    }
                }

                return _list?.Any( ) == true
                    ? _list
                    : default( IEnumerable<Image> );
            }

            return default;
        }

        /// <summary>
        /// Gets the images.
        /// </summary>
        /// <param name="paths">The source path.</param>
        /// <returns></returns>
        public IEnumerable<Image> CreateImages( IEnumerable<string> paths )
        {
            if( paths?.Count( ) > 0 )
            {
                var _files = paths.ToList( );
                var _list = new List<Image>( );

                for( var i = 0; i < _files.Count; i++ )
                {
                    using var _stream = File.Open( _files[ i ], FileMode.Open );
                    using var _img = new Bitmap( _stream );
                    _list.Add( _img );
                }

                return _list.Count > 0
                    ? _list
                    : default( IEnumerable<Image> );
            }

            return default;
        }
    }
}