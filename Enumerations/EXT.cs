// <copyright file = "EXT.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// Defines the EXT
    /// </summary>
    public enum EXT
    {
        /// <summary>
        /// Defines the DB on SQLite database files.
        /// </summary>
        DB,

        /// <summary>
        /// Defines the ACCDB on newer MS Access database files.
        /// </summary>
        ACCDB,

        /// <summary>
        /// Defines the MDB on older MS Access database files.
        /// </summary>
        MDB,

        /// <summary>
        /// Defines the SDF on MS SQL Server Compact Edition database files.
        /// </summary>
        SDF,

        /// <summary>
        /// Defines the MDF on MS SQL Server database files.
        /// </summary>
        MDF,

        /// <summary>
        /// Defines the XLS on older MS Excel files.
        /// </summary>
        XLS,

        /// <summary>
        /// Defines the XLSX on newer MS Excel files.
        /// </summary>
        XLSX,

        /// <summary>
        /// Defines the CSV on Comma Seperated Value files.
        /// </summary>
        CSV,

        /// <summary>
        /// Defines the TXT on Text files.
        /// </summary>
        TXT,

        /// <summary>
        /// Defines the PDF on Portable Document Codec files.
        /// </summary>
        PDF,

        /// <summary>
        /// Defines the DOCX on newer MS Word files.
        /// </summary>
        DOCX,

        /// <summary>
        /// Defines the DOC on older MS Word files.
        /// </summary>
        DOC,

        /// <summary>
        /// Identifies SQL files
        /// </summary>
        SQL,

        /// <summary>
        /// Identififes .resx file extension for resource files
        /// </summary>
        RESX,

        /// <summary>
        /// Identifies .dll extension for libraries
        /// </summary>
        DLL,

        /// <summary>
        /// Identifies the .exe file extenstion for executables
        /// </summary>
        EXE,

        /// <summary>
        /// Identifies the .ico file extension for icons
        /// </summary>
        ICO,

        /// <summary>
        /// Identifies the .png file extension for images
        /// </summary>
        PNG,

        /// <summary>
        /// Identifies the .gif file extension for gifs
        /// </summary>
        GIF
    }
}