//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// Defines the DataType
    /// </summary>
    public enum DataType
    {
        /// <summary>
        /// Defines the None
        /// </summary>
        NS = 0,

        /// <summary>
        /// Defines the Text
        /// </summary>
        Text,

        /// <summary>
        /// Defines the Integer
        /// </summary>
        Integer,

        /// <summary>
        /// Defines the BLOB
        /// </summary>
        Blob,

        /// <summary>
        /// Defines the Decimal
        /// </summary>
        Decimal,

        /// <summary>
        /// Defines the IsDateTime
        /// </summary>
        DateTime,

        /// <summary>
        /// Defines the ImageBase
        /// </summary>
        Image,

        /// <summary>
        /// Defines the Hyperlink
        /// </summary>
        Hyperlink,

        /// <summary>
        /// Defines the FileStream
        /// </summary>
        FileStream
    }
}