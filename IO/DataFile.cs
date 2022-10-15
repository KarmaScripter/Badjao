// // <copyright file = "DataFile.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="PathBase" />
    public class DataFile : FileBase, IFile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataFile"/> class.
        /// </summary>
        public DataFile( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataFile"/> class.
        /// </summary>
        /// <param name="input">The input.</param>
        public DataFile( string input )
            : base( input )
        {
            Buffer = input;
            FileInfo = new FileInfo( input );
            FullPath = FileInfo.FullName;
            HasParent = CheckParent( );
            Length = FileInfo.Length;
            Attributes = FileInfo.Attributes;
            FileSecurity = FileInfo.GetAccessControl( );
            Created = FileInfo.CreationTime;
            Modified = FileInfo.LastWriteTime;
            Extension = FileInfo.Extension;
        }

        /// <summary>
        /// Creates the specified file path.
        /// </summary>
        /// <param name="filePath">
        /// The file path.
        /// </param>
        /// <returns></returns>
        public static FileInfo Create( string filePath )
        {
            try
            {
                return !string.IsNullOrEmpty( filePath )
                    ? new FileInfo( filePath )
                    : default( FileInfo );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( FileInfo );
            }
        }

        /// <summary>
        /// Transfers the specified folder.
        /// </summary>
        /// <param name="folder">The folder.</param>
        public void Transfer( DirectoryInfo folder )
        {
            if( folder != null
               && !Directory.Exists( folder.FullName ) )
            {
                Directory.CreateDirectory( folder.FullName );
            }

            try
            {
                var _files = folder?.GetFiles( );
                if( _files?.Any( ) == true )
                {
                    foreach( var _fileInfo in _files )
                    {
                        Directory.Move( _fileInfo.FullName, folder.Name );
                    }
                }
            }
            catch( IOException ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Determines whether this instance contains the object.
        /// </summary>
        /// <param name="search">The search.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified search]; otherwise, <c>false</c>.
        /// </returns>
        public bool Contains( string search )
        {
            try
            {
                if( !string.IsNullOrEmpty( search )
                   && File.Exists( search ) )
                {
                    using var _stream = File.Open( search, FileMode.Open );
                    using var _reader = new StreamReader( _stream );
                    if( _reader != null )
                    {
                        var _text = _reader?.ReadLine( );
                        var _result = false;
                        while( _text == string.Empty )
                        {
                            if( Regex.IsMatch( _text, search ) )
                            {
                                _result = true;
                                break;
                            }

                            _text = _reader.ReadLine( );
                        }

                        return _result;
                    }
                }

                return false;
            }
            catch( IOException ex )
            {
                Fail( ex );
                return false;
            }
        }

        /// <summary>
        /// Searches the specified pattern.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <returns></returns>
        public IEnumerable<FileInfo> Search( string pattern )
        {
            if( !string.IsNullOrEmpty( pattern ) )
            {
                try
                {
                    var _input = Path.GetFullPath( Buffer );
                    if( !string.IsNullOrEmpty( _input )
                       && File.Exists( _input ) )
                    {
                        IEnumerable<string> _enumerable =
                            Directory.GetDirectories( _input, pattern );

                        var _list = new List<FileInfo>( );
                        foreach( var file in _enumerable )
                        {
                            _list.Add( new FileInfo( file ) );
                        }

                        return _list?.Any( ) == true
                            ? _list
                            : default( List<FileInfo> );
                    }
                }
                catch( IOException ex )
                {
                    Fail( ex );
                    return default( IEnumerable<FileInfo> );
                }
            }

            return default( IEnumerable<FileInfo> );
        }

        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <returns></returns>
        public string GetParentDirectory( )
        {
            if( !string.IsNullOrEmpty( Buffer ) )
            {
                try
                {
                    return CheckParent( )
                        ? Directory.GetParent( Buffer )?.FullName
                        : string.Empty;
                }
                catch( IOException ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Browses this instance.
        /// </summary>
        /// <returns></returns>
        public static string Browse( )
        {
            try
            {
                var _dialog = new OpenFileDialog
                {
                    CheckFileExists = true,
                    CheckPathExists = true
                };

                return _dialog.FileName;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>Returns a string that
        /// represents the current object.
        /// </summary>
        /// <returns>A string that represents
        /// the current object.
        /// </returns>
        public override string ToString( )
        {
            try
            {
                return !string.IsNullOrEmpty( Name )
                    ? Name
                    : string.Empty;
            }
            catch( IOException ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }
    }
}