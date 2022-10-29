//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.IO;

    public interface IFile : IPath
    {
        /// <summary>
        /// Transfers the specified folder.
        /// </summary>
        /// <param name="folder">The folder.</param>
        void Transfer( DirectoryInfo folder );

        /// <summary>
        /// Determines whether this instance contains the object.
        /// </summary>
        /// <param name="search">The search.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified search]; otherwise, <c>false</c>.
        /// </returns>
        bool Contains( string search );

        /// <summary>
        /// Searches the specified pattern.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <returns></returns>
        IEnumerable<FileInfo> Search( string pattern );

        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <returns></returns>
        string GetParentDirectory( );
    }
}