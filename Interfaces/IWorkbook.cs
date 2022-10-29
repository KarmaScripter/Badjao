// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using OfficeOpenXml;
    using OfficeOpenXml.Style;
    using Syncfusion.Windows.Forms.Spreadsheet;

    public interface IWorkbook
    {
        /// <summary>
        /// Gets or sets the data connection.
        /// </summary>
        /// <value>
        /// The data connection.
        /// </value>
        OleDbConnection DataConnection { get; set; }

        /// <summary>
        /// Gets or sets the data command.
        /// </summary>
        /// <value>
        /// The data command.
        /// </value>
        OleDbCommand DataCommand { get; set; }

        /// <summary>
        /// Gets or sets the data adapter.
        /// </summary>
        /// <value>
        /// The data adapter.
        /// </value>
        OleDbDataAdapter DataAdapter { get; set; }

        /// <summary>
        /// Gets the excel package.
        /// </summary>
        /// <value>
        /// The excel package.
        /// </value>
        ExcelPackage ExcelPackage { get; set; }

        /// <summary>
        /// Gets or sets the ext.
        /// </summary>
        /// <value>
        /// The ext.
        /// </value>
        EXT Ext { get; set; }

        /// <summary>
        /// Gets or sets the file information.
        /// </summary>
        /// <value>
        /// The file information.
        /// </value>
        FileInfo FileInfo { get; set; }

        /// <summary>
        /// Gets or sets the excel.
        /// </summary>
        /// <value>
        /// The excel.
        /// </value>
        ExcelPackage Excel { get; set; }

        /// <summary>
        /// Gets or sets the workbook.
        /// </summary>
        /// <value>
        /// The workbook.
        /// </value>
        ExcelWorkbook Workbook { get; set; }

        /// <summary>
        /// Gets or sets the workSheet.
        /// </summary>
        /// <value>
        /// The workSheet.
        /// </value>
        ExcelWorksheet Worksheet { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The comment.
        /// </value>
        IEnumerable<ExcelComment> Comment { get; set; }

        /// <summary>
        /// Gets or sets the Data.
        /// </summary>
        /// <value>
        /// The Data.
        /// </value>
        IEnumerable<DataRow> Data { get; set; }

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        /// <value>
        /// The index.
        /// </value>
        int Index { get; set; }

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        string FileName { get; set; }

        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        /// <value>
        /// The connection string.
        /// </value>
        string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the color of the primary back.
        /// </summary>
        /// <value>
        /// The color of the primary back.
        /// </value>
        Color PrimaryBackColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the secondary back.
        /// </summary>
        /// <value>
        /// The color of the secondary back.
        /// </value>
        Color SecondaryBackColor { get; set; }

        /// <summary>
        /// Gets or sets the left.
        /// </summary>
        /// <value>
        /// The left.
        /// </value>
        ExcelHorizontalAlignment Left { get; set; }

        /// <summary>
        /// Gets or sets the center.
        /// </summary>
        /// <value>
        /// The center.
        /// </value>
        ExcelHorizontalAlignment Center { get; set; }

        /// <summary>
        /// Gets or sets the right.
        /// </summary>
        /// <value>
        /// The right.
        /// </value>
        ExcelHorizontalAlignment Right { get; set; }

        /// <summary>
        /// Gets or sets the height of the row.
        /// </summary>
        /// <value>
        /// The height of the row.
        /// </value>
        double RowHeight { get; set; }

        /// <summary>
        /// Gets or sets the width of the column.
        /// </summary>
        /// <value>
        /// The width of the column.
        /// </value>
        double ColumnWidth { get; set; }

        /// <summary>
        /// Gets or sets the top margin.
        /// </summary>
        /// <value>
        /// The top margin.
        /// </value>
        int TopMargin { get; set; }

        /// <summary>
        /// Gets or sets the bottom margin.
        /// </summary>
        /// <value>
        /// The bottom margin.
        /// </value>
        int BottomMargin { get; set; }

        /// <summary>
        /// Gets or sets the left margin.
        /// </summary>
        /// <value>
        /// The left margin.
        /// </value>
        decimal LeftMargin { get; set; }

        /// <summary>
        /// Gets or sets the right margin.
        /// </summary>
        /// <value>
        /// The right margin.
        /// </value>
        decimal RightMargin { get; set; }

        /// <summary>
        /// Gets or sets the header margin.
        /// </summary>
        /// <value>
        /// The header margin.
        /// </value>
        decimal HeaderMargin { get; set; }

        /// <summary>
        /// Gets or sets the footer margin.
        /// </summary>
        /// <value>
        /// The footer margin.
        /// </value>
        decimal FooterMargin { get; set; }

        /// <summary>
        /// Gets or sets the column count.
        /// </summary>
        /// <value>
        /// The column count.
        /// </value>
        int ColumnCount { get; set; }

        /// <summary>
        /// Gets or sets the row count.
        /// </summary>
        /// <value>
        /// The row count.
        /// </value>
        int RowCount { get; set; }

        /// <summary>
        /// Gets or sets the zoom level.
        /// </summary>
        /// <value>
        /// The zoom level.
        /// </value>
        int ZoomLevel { get; set; }

        /// <summary>
        /// Sets the width of the column.
        /// </summary>
        /// <param name = "grid" >
        /// The grid.
        /// </param>
        /// <param name = "width" >
        /// The width.
        /// </param>
        void SetColumnWidth( Grid grid, double width );

        /// <summary>
        /// Sets the color of the backgroud.
        /// </summary>
        /// <param name = "grid" >
        /// The grid.
        /// </param>
        /// <param name = "color" >
        /// The color.
        /// </param>
        void SetBackgroundColor( Grid grid, Color color );

        /// <summary>
        /// Sets the range font.
        /// </summary>
        /// <param name = "grid" >
        /// The grid.
        /// </param>
        /// <param name = "font" >
        /// The font.
        /// </param>
        void SetRangeFont( Grid grid, Font font );

        /// <summary>
        /// Sets the color of the font.
        /// </summary>
        /// <param name = "grid" >
        /// The grid.
        /// </param>
        /// <param name = "color" >
        /// The color.
        /// </param>
        void SetFontColor( Grid grid, Color color );

        /// <summary>
        /// Sets the border style.
        /// </summary>
        /// <param name = "grid" >
        /// The grid.
        /// </param>
        /// <param name = "side" >
        /// The side.
        /// </param>
        /// <param name = "style" >
        /// The style.
        /// </param>
        void SetBorderStyle( Grid grid, ExcelSettings.BorderSide side, ExcelBorderStyle style );

        /// <summary>
        /// Sets the horizontal aligment.
        /// </summary>
        /// <param name = "grid" >
        /// The grid.
        /// </param>
        /// <param name = "align" >
        /// The align.
        /// </param>
        void SetHorizontalAlignment( Grid grid, ExcelHorizontalAlignment align );

        /// <summary>
        /// Sets the vertical aligment.
        /// </summary>
        /// <param name = "grid" >
        /// The grid.
        /// </param>
        /// <param name = "align" >
        /// The align.
        /// </param>
        void SetVerticalAligment( Grid grid, ExcelVerticalAlignment align );

        /// <summary>
        /// Merges the cells.
        /// </summary>
        /// <param name = "grid" >
        /// The grid.
        /// </param>
        void MergeCells( Grid grid );

        /// <summary>
        /// Sets the file path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        void SetFilePath( string filePath );

        /// <summary>
        /// Sets the name of the file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        void SetFileName( string filePath );

        /// <summary>
        /// Gets the file extension.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        EXT GetFileExtension( string filePath );

        /// <summary>
        /// Gets the connection string.
        /// </summary>
        /// <param name="extension">The extension.</param>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        string GetConnectionString( string extension, string filePath );

        /// <summary>
        /// Sets the excel form.
        /// </summary>
        /// <param name="spreadSheet">The spread sheet.</param>
        /// <param name="dataTable">The data table.</param>
        void SetExcelForm( Spreadsheet spreadSheet, DataTable dataTable );

        /// <summary>
        /// Sets the excel form.
        /// </summary>
        /// <param name="spreadSheet">The spread sheet.</param>
        /// <param name="dataGrid">The data grid.</param>
        void SetExcelForm( Spreadsheet spreadSheet, DataGridView dataGrid );

        /// <summary>
        /// Adds the comment.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="text">The text.</param>
        void AddComment( Grid grid, string text );

        /// <summary>
        /// Sets the caption text.
        /// </summary>
        /// <param name="grid">The grid.</param>
        void SetCaptionText( Grid grid );

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="text">The text.</param>
        void SetText( Grid grid, IEnumerable<string> text );
    }
}