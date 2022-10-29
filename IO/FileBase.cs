//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

    /// <summary>
    /// 
    /// </summary>
    public abstract class FileBase : PathBase
    {
        /// <summary>
        /// Initializes a new instance 
        /// of the <see cref="PathBase"/> class.
        /// </summary>
        public FileBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileBase"/> class.
        /// </summary>
        /// <param name="input">The input.</param>
        public FileBase( string input )
        {
            Buffer = input;
            FullPath = Path.GetFullPath( input );
            FileInfo = new FileInfo( FullPath );
            Name = FileInfo.Name;
            FullPath = FileInfo.FullName;
            Extension = FileInfo.Extension;
            Length = FileInfo.Length;
            Attributes = FileInfo.Attributes;
            FileSecurity = FileInfo.GetAccessControl( );
            Created = FileInfo.CreationTime;
            Modified = FileInfo.LastWriteTime;
        }
    }
}