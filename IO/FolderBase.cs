//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

// ReSharper disable All

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Security.AccessControl;

    /// <summary>
    /// 
    /// </summary>
    public abstract class FolderBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderBase"/> class.
        /// </summary>
        public FolderBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderBase"/> class.
        /// </summary>
        /// <param name="input">The input.</param>
        public FolderBase( string input )
        {
            Buffer = input;
            FullPath = Path.GetFullPath( input );
            DirectoryInfo = new DirectoryInfo( FullPath );
            Name = Path.GetDirectoryName( input );
            FullName = DirectoryInfo.FullName;
            Created = DirectoryInfo.CreationTime;
            Modified = DirectoryInfo.LastWriteTime;
            HasParent = DirectoryInfo.Parent != null;
            HasSubFiles = Directory.GetFiles( input ).Length > 0;
            HasSubFolders = Directory.GetDirectories( input ).Length > 0;
        }

        /// <summary>
        /// Gets or sets the buffer.
        /// </summary>
        /// <value>
        /// The buffer.
        /// </value>
        public virtual string Buffer { get; set; }

        /// <summary>
        /// The base stream
        /// </summary>
        public virtual DirectoryInfo DirectoryInfo { get; set; }

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
        public virtual string FullName { get; set; }

        /// <summary>
        /// Gets or sets the full path.
        /// </summary>
        /// <value>
        /// The full path.
        /// </value>
        public virtual string FullPath { get; set; }

        /// <summary>
        /// Gets or sets the changed date.
        /// </summary>
        /// <value>
        /// The changed date.
        /// </value>
        public virtual DateTime Modified { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has parent.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has parent { get; set; } otherwise, <c>false</c>.
        /// </value>
        public virtual bool HasParent { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        /// <value>
        /// The creation date.p/// </value>
        public virtual DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has sub files.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has sub files; otherwise, <c>false</c>.
        /// </value>
        public virtual bool HasSubFiles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has sub folders.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has sub folders; otherwise, <c>false</c>.
        /// </value>
        public virtual bool HasSubFolders { get; set; }

        /// <summary>
        /// Gets or sets the security.
        /// </summary>
        /// <value>
        /// The security.
        /// </value>
        public virtual FileSecurity FileSecurity { get; set; }

        /// <summary>
        /// Gets the files.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<string> GetFileNames( )
        {
            if( HasSubFiles )
            {
                try
                {
                    var _files = Directory.GetFiles( FullPath );

                    return _files?.Any( ) == true
                        ? _files
                        : default( IEnumerable<string> );
                }
                catch( IOException ex )
                {
                    Fail( ex );
                    return default( IEnumerable<string> );
                }
            }

            return default( IEnumerable<string> );
        }

        /// <summary>
        /// Gets the Data.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<FileInfo> GetStreamData( )
        {
            if( !string.IsNullOrEmpty( FullPath ) )
            {
                try
                {
                    IEnumerable<FileInfo> _enumerable = DirectoryInfo?.GetFiles( FullPath );

                    return _enumerable?.Any( ) == true
                        ? _enumerable
                        : default( IEnumerable<FileInfo> );
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
        /// Gets the special folders.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<string> GetSpecialFolders( )
        {
            try
            {
                var _folders = Enum.GetNames( typeof( Environment.SpecialFolder ) );

                return _folders?.Any( ) == true
                    ? _folders
                    : default( string[ ] );
            }
            catch( IOException ex )
            {
                Fail( ex );
                return default( IEnumerable<string> );
            }
        }

        /// <summary>
        /// Gets the sub folders.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<DirectoryInfo> GetSubFolders( )
        {
            if( DirectoryInfo != null )
            {
                try
                {
                    var _folders = DirectoryInfo?.GetDirectories( );

                    return _folders?.Any( ) != true
                        ? _folders
                        : default( DirectoryInfo[ ] );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DirectoryInfo> );
                }
            }

            return default( IEnumerable<DirectoryInfo> );
        }

        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <returns></returns>
        protected virtual DirectoryInfo GetBaseDirectory( )
        {
            try
            {
                if( !string.IsNullOrEmpty( Buffer )
                   && Directory.Exists( Buffer ) )
                {
                    var _file = new DirectoryInfo( Buffer );
                    return _file?.Parent;
                }

                return default( DirectoryInfo );
            }
            catch( IOException ex )
            {
                Fail( ex );
                return default( DirectoryInfo );
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