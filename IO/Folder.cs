// <copyright file = "Folder.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Compression;
    using System.Linq;
    using System.Security.AccessControl;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="FolderBase" />
    /// <seealso cref="IFolder" />
    public class Folder : FolderBase, IFolder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Folder"/> class.
        /// </summary>
        public Folder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Folder"/> class.
        /// </summary>
        /// <param name="file">The file.</param>
        public Folder( string file )
        {
            FilePath = new FilePath( file );
            DirectoryInfo = GetBaseDirectory();
            Name = FilePath.GetParentFolder( );
            Path = DirectoryInfo.FullName;
            Files = Directory.GetFiles( Path );
            DirectorySecurity = DirectoryInfo.GetAccessControl();
            CreationDate = DirectoryInfo.CreationTime;
            ChangeDate = DirectoryInfo.LastWriteTime;
        }
        
        /// <summary>
        /// Gets the current directory.
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentDirectory( )
        {
            try
            {
                return !string.IsNullOrEmpty( Environment.CurrentDirectory )
                    ? Environment.CurrentDirectory
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// Creates the specified filepath.
        /// </summary>
        /// <param name="fullName">The filepath.</param>
        /// <returns></returns>
        public static DirectoryInfo Create( string fullName )
        {
            try
            {
                return !string.IsNullOrEmpty( fullName ) 
                    && !Directory.Exists( fullName )
                        ? Directory.CreateDirectory( fullName )
                        : default( DirectoryInfo );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( DirectoryInfo );
            }
        }

        /// <summary>
        /// Deletes the specified folderName.
        /// </summary>
        /// <param name="folderName">The folderName.</param>
        public static void Delete( string folderName )
        {
            try
            {
                if( !string.IsNullOrEmpty( folderName )
                    && Directory.Exists( folderName ) )
                {
                    Directory.Delete( folderName, true );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Creates the sub folder.
        /// </summary>
        /// <param name="folderName">The folderName.</param>
        /// <returns></returns>
        public DirectoryInfo CreateSubDirectory( string folderName )
        {
            if( string.IsNullOrEmpty( folderName ) )
            {
                return default( DirectoryInfo );
            }

            if( !string.IsNullOrEmpty( folderName )
                && Directory.Exists( folderName ) )
            {
                Directory.Delete( folderName );
            }

            try
            {
                return !string.IsNullOrEmpty( folderName ) 
                    && !Directory.Exists( folderName )
                        ? DirectoryInfo?.CreateSubdirectory( folderName )
                        : default( DirectoryInfo );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( DirectoryInfo );
            }
        }
        
        /// <summary>
        /// Gets the Data.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFilePath> GetSubFiles( )
        {
            try
            {
                return Files?.Select( f => new FilePath( f ) )
                    ?.ToArray( );
            }
            catch( IOException ex )
            {
                Fail( ex );
                return default( IEnumerable<IFilePath> );
            }
        }

        /// <summary>
        /// Moves the specified folderpath.
        /// </summary>
        /// <param name="fullName">The folderpath.</param>
        public void Move( string fullName )
        {
            try
            {
                if( !string.IsNullOrEmpty( fullName )
                    && !Directory.Exists( fullName ) )
                {
                    DirectoryInfo?.MoveTo( fullName );
                }
                else if( !string.IsNullOrEmpty( fullName )
                    && Directory.Exists( fullName ) )
                {
                    Directory.CreateDirectory( fullName );
                    DirectoryInfo?.MoveTo( fullName );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Zips the specified filepath.
        /// </summary>
        /// <param name="destinationPath">The filepath.</param>
        public void Zip( string destinationPath )
        {
            try
            {
                if( !string.IsNullOrEmpty( destinationPath ) )
                {
                    ZipFile.CreateFromDirectory( Path, destinationPath );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Uns the zip.
        /// </summary>
        /// <param name="zipPath">The zipPath.</param>
        public void UnZip( string zipPath )
        {
            try
            {
                if( !string.IsNullOrEmpty( zipPath )
                    && File.Exists( zipPath ) )
                {
                    ZipFile.ExtractToDirectory( zipPath, Path );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the access control.
        /// </summary>
        /// <param name="security">The security.</param>
        public void SetAccessControl( DirectorySecurity security )
        {
            if( security != null )
            {
                try
                {
                    DirectoryInfo?.SetAccessControl( security );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}
