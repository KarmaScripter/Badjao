// // <copyright file = "PathBase.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Security.AccessControl;

    /// <summary>
    /// 
    /// </summary>
    public abstract class PathBase
    {
        /// <summary>
        /// The path
        /// </summary>
        public virtual string Buffer { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        public virtual string FullPath { get; set; }

        /// <summary>
        /// Gets or sets the full path.
        /// </summary>
        /// <value>
        /// The full path.
        /// </value>
        public virtual string AbsolutePath { get; set; }

        /// <summary>
        /// Gets or sets the changed date.
        /// </summary>
        /// <value>
        /// The changed date.
        /// </value>
        public virtual DateTime Modified { get; set; }

        /// <summary>
        /// Gets the information.
        /// </summary>
        /// <value>
        /// The information.
        /// </value>
        public virtual FileInfo FileInfo { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        /// <value>
        /// The extension.
        /// </value>
        public virtual string Extension { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has parent.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has parent { get; set; } otherwise, <c>false</c>.
        /// </value>
        public virtual bool HasParent { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has parent.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has parent { get; set; } otherwise, <c>false</c>.
        /// </value>
        public virtual string ParentFolder { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        /// <value>
        /// The creation date.p/// </value>
        public virtual DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets the lengeth.
        /// </summary>
        /// <value>
        /// The lengeth.
        /// </value>
        public virtual long Length { get; set; }

        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <value>
        /// The attributes.
        /// </value>
        public virtual FileAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or sets the security.
        /// </summary>
        /// <value>
        /// The security.
        /// </value>
        public virtual FileSecurity FileSecurity { get; set; }

        /// <summary>
        /// Gets the dir sep.
        /// </summary>
        /// <value>
        /// The dir sep.
        /// </value>
        public char DirSep { get; } = Path.DirectorySeparatorChar;

        /// <summary>
        /// Gets the path sep.
        /// </summary>
        /// <value>
        /// The path sep.
        /// </value>
        public char PathSep { get; } = Path.PathSeparator;

        /// <summary>
        /// Gets the invalid path character.
        /// </summary>
        /// <value>
        /// The invalid path character.
        /// </value>
        public char[ ] InvalidPathChars { get; } = Path.GetInvalidPathChars( );

        /// <summary>
        /// Gets the invalid namehar.
        /// </summary>
        /// <value>
        /// The invalid namehar.
        /// </value>
        public char[ ] InvalidNameChars { get; } = Path.GetInvalidFileNameChars( );

        /// <summary>
        /// Initializes a new instance 
        /// of the <see cref="PathBase"/> class.
        /// </summary>
        public PathBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        ///  <see cref="PathBase"/> class.
        /// </summary>
        /// <param name="input">The input.</param>
        public PathBase( string input )
        {
            Buffer = input;
            AbsolutePath = Path.GetFullPath( input );
            FileInfo = new FileInfo( AbsolutePath );
            Name = FileInfo.Name;
            FullPath = FileInfo.FullName;
            Extension = FileInfo.Extension;
            Length = FileInfo.Length;
            Attributes = FileInfo.Attributes;
            FileSecurity = FileInfo.GetAccessControl( );
            Created = FileInfo.CreationTime;
            Modified = FileInfo.LastWriteTime;
        }

        /// <summary>
        /// Moves the specified destination.
        /// </summary>
        /// <param name="filePath">The destination.</param>
        public virtual void Move( string filePath )
        {
            if( !string.IsNullOrEmpty( filePath ) )
            {
                try
                {
                    FileInfo?.MoveTo( filePath );
                }
                catch( IOException ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Copies the specified filePath.
        /// </summary>
        /// <param name="filePath">The filePath.</param>
        public virtual void Copy( string filePath )
        {
            try
            {
                if( !string.IsNullOrEmpty( filePath )
                   && !File.Exists( filePath ) )
                {
                    FileInfo.CopyTo( filePath );
                }
            }
            catch( IOException ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Deletes this instance.
        /// </summary>
        public virtual void Delete( )
        {
            try
            {
                var _file = Path.GetFullPath( Buffer );
                if( !string.IsNullOrEmpty( _file )
                   && File.Exists( _file ) )
                {
                    File.Delete( _file );
                }
            }
            catch( IOException ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Determines whether [has parent folder].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [has parent folder]; otherwise, <c>false</c>.
        /// </returns>
        protected bool CheckParent( )
        {
            try
            {
                return !string.IsNullOrEmpty( FileInfo?.DirectoryName )
                    && Directory.Exists( FileInfo?.DirectoryName );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return false;
            }
        }

        /// <summary>
        /// Gets the file security.
        /// </summary>
        /// <returns></returns>
        public FileSecurity GetFileSecurity( )
        {
            try
            {
                return FileSecurity ?? default( FileSecurity );
            }
            catch( IOException ex )
            {
                Fail( ex );
                return default( FileSecurity );
            }
        }

        /// <summary>
        /// Gets the base stream.
        /// </summary>
        /// <returns></returns>
        public FileStream GetBaseStream( )
        {
            try
            {
                var _path = Path.GetFullPath( Buffer );
                return !string.IsNullOrEmpty( _path ) && File.Exists( _path )
                    ? new FileInfo( _path )?.Create( )
                    : default( FileStream );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( FileStream );
            }
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString( )
        {
            try
            {
                return !string.IsNullOrEmpty( Buffer )
                    ? Path.GetFullPath( Buffer )
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
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