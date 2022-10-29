//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Spreadsheet;
    using Syncfusion.XlsIO;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class ExcelSettings
    {
        /// <summary>
        /// 
        /// </summary>
        public enum BorderSide
        {
            /// <summary>
            /// The top
            /// </summary>
            Top,

            /// <summary>
            /// The bottom
            /// </summary>
            Bottom,

            /// <summary>
            /// The left
            /// </summary>
            Left,

            /// <summary>
            /// The right
            /// </summary>
            Right
        };

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        /// <value>
        /// The index.
        /// </value>
        public virtual int Index { get; set; } = 10;

        /// <summary>
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        public virtual string FilePath { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public virtual string FileName { get; set; }

        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        /// <value>
        /// The connection string.
        /// </value>
        public virtual string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the color of the primary back.
        /// </summary>
        /// <value>
        /// The color of the primary back.
        /// </value>
        public virtual Color PrimaryBackColor { get; set; } = Color.FromArgb( 255, 242, 242, 242 );

        /// <summary>
        /// Gets or sets the color of the secondary back.
        /// </summary>
        /// <value>
        /// The color of the secondary back.
        /// </value>
        public virtual Color SecondaryBackColor { get; set; } =
            Color.FromArgb( 255, 221, 235, 247 );

        /// <summary>
        /// Gets or sets the left.
        /// </summary>
        /// <value>
        /// The left.
        /// </value>
        public virtual ExcelHorizontalAlignment Left { get; set; } = ExcelHorizontalAlignment.Left;

        /// <summary>
        /// Gets or sets the center.
        /// </summary>
        /// <value>
        /// The center.
        /// </value>
        public virtual ExcelHorizontalAlignment Center { get; set; } =
            ExcelHorizontalAlignment.CenterMiddle;

        /// <summary>
        /// Gets or sets the right.
        /// </summary>
        /// <value>
        /// The right.
        /// </value>
        public virtual ExcelHorizontalAlignment Right { get; set; } =
            ExcelHorizontalAlignment.Right;

        /// <summary>
        /// Gets or sets the height of the row.
        /// </summary>
        /// <value>
        /// The height of the row.
        /// </value>
        public virtual double RowHeight { get; set; } = 0.22;

        /// <summary>
        /// Gets or sets the width of the column.
        /// </summary>
        /// <value>
        /// The width of the column.
        /// </value>
        public virtual double ColumnWidth { get; set; } = 0.75;

        /// <summary>
        /// Gets or sets the top margin.
        /// </summary>
        /// <value>
        /// The top margin.
        /// </value>
        public virtual int TopMargin { get; set; } = 1;

        /// <summary>
        /// Gets or sets the bottom margin.
        /// </summary>
        /// <value>
        /// The bottom margin.
        /// </value>
        public virtual int BottomMargin { get; set; } = 1;

        /// <summary>
        /// Gets or sets the left margin.
        /// </summary>
        /// <value>
        /// The left margin.
        /// </value>
        public virtual decimal LeftMargin { get; set; } = 0.25m;

        /// <summary>
        /// Gets or sets the right margin.
        /// </summary>
        /// <value>
        /// The right margin.
        /// </value>
        public virtual decimal RightMargin { get; set; } = 0.25m;

        /// <summary>
        /// Gets or sets the header margin.
        /// </summary>
        /// <value>
        /// The header margin.
        /// </value>
        public virtual decimal HeaderMargin { get; set; } = 0.25m;

        /// <summary>
        /// Gets or sets the footer margin.
        /// </summary>
        /// <value>
        /// The footer margin.
        /// </value>
        public virtual decimal FooterMargin { get; set; } = 0.25m;

        /// <summary>
        /// Gets or sets the column count.
        /// </summary>
        /// <value>
        /// The column count.
        /// </value>
        public virtual int ColumnCount { get; set; } = 12;

        /// <summary>
        /// Gets or sets the row count.
        /// </summary>
        /// <value>
        /// The row count.
        /// </value>
        public virtual int RowCount { get; set; } = 55;

        /// <summary>
        /// Gets or sets the zoom level.
        /// </summary>
        /// <value>
        /// The zoom level.
        /// </value>
        public virtual int ZoomLevel { get; set; } = 100;

        /// <summary>
        /// Sets the file path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public virtual void SetFilePath( string filePath )
        {
            if( !string.IsNullOrEmpty( filePath )
               && File.Exists( filePath ) )
            {
                try
                {
                    FilePath = Path.GetFileName( filePath );
                }
                catch( Exception e )
                {
                    Console.WriteLine( e );
                    throw;
                }
            }
        }

        /// <summary>
        /// Sets the name of the file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public virtual void SetFileName( string filePath )
        {
            if( !string.IsNullOrEmpty( filePath )
               && File.Exists( filePath ) )
            {
                try
                {
                    FilePath = Path.GetFileNameWithoutExtension( filePath );
                }
                catch( Exception e )
                {
                    Console.WriteLine( e );
                    throw;
                }
            }
        }

        /// <summary>
        /// Gets the file extension.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public virtual EXT GetFileExtension( string filePath )
        {
            try
            {
                var _path = Path.GetExtension( filePath );

                if( _path != null )
                {
                    var _extension = (EXT)Enum.Parse( typeof( EXT ), _path );

                    return Enum.IsDefined( typeof( EXT ), _extension )
                        ? _extension
                        : default;
                }

                return default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the connection string.
        /// </summary>
        /// <param name="extension">The extension.</param>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        public virtual string GetConnectionString( string extension, string filePath )
        {
            if( !string.IsNullOrEmpty( extension )
               && !string.IsNullOrEmpty( filePath ) )
            {
                try
                {
                    // ReSharper disable once ConvertSwitchStatementToSwitchExpression
                    switch( extension?.ToUpper( ) )
                    {
                        case ".XLS":
                        {
                            return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath
                                + ";Extended Properties=\"Excel 8.0;HDR=YES;\"";
                        }

                        case ".XLSX":
                        {
                            return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath
                                + ";Extended Properties=\"Excel 12.0;HDR=YES;\"";
                        }

                        default:
                        {
                            return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath
                                + ";Extended Properties=\"Excel 12.0;HDR=YES;\"";
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Sets the excel form.
        /// </summary>
        /// <param name="spreadSheet">The spread sheet.</param>
        /// <param name="dataTable">The data table.</param>
        public virtual void SetExcelForm( Spreadsheet spreadSheet, DataTable dataTable )
        {
            if( spreadSheet != null
               && dataTable?.Rows?.Count > 0 )
            {
                try
                {
                    spreadSheet.Workbook.ActiveSheet.ListObjects.Clear( );
                    spreadSheet.Workbook.ActiveSheet.UsedRange.Clear( true );
                    spreadSheet.Workbook.ActiveSheet.StandardWidth = 12.5f;
                    var name = spreadSheet.Workbook.Worksheets[ 0 ].Name;
                    var sheet = spreadSheet.Workbook.ActiveSheet;
                    spreadSheet.ActiveSheet.ImportDataTable( dataTable, true, 1, 1 );
                    var range = sheet.UsedRange;
                    var table = sheet.ListObjects.Create( name, range );
                    table.BuiltInTableStyle = TableBuiltInStyles.TableStyleMedium2;
                    spreadSheet.ActiveGrid.InvalidateCells( );
                    spreadSheet.SetZoomFactor( "Sheet1", 110 );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the excel form.
        /// </summary>
        /// <param name="spreadSheet">The spread sheet.</param>
        /// <param name="dataGrid">The data grid.</param>
        public virtual void SetExcelForm( Spreadsheet spreadSheet, DataGridView dataGrid )
        {
            if( spreadSheet != null
               && dataGrid?.DataSource != null )
            {
                try
                {
                    spreadSheet.Workbook.ActiveSheet.ListObjects.Clear( );
                    spreadSheet.Workbook.ActiveSheet.StandardWidth = 12.5f;
                    var name = spreadSheet.Workbook.Worksheets[ 0 ].Name;
                    var sheet = spreadSheet.Workbook.ActiveSheet;
                    var _table = (DataTable)dataGrid.DataSource;
                    spreadSheet.ActiveSheet.ImportDataTable( _table, 1, 1, true, false );
                    var range = sheet.UsedRange;
                    var table = sheet.ListObjects.Create( name, range );
                    table.BuiltInTableStyle = TableBuiltInStyles.TableStyleMedium2;
                    spreadSheet.ActiveGrid.InvalidateCells( );
                    spreadSheet.SetZoomFactor( "Sheet1", 110 );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Adds the comment.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="text">The text.</param>
        public void AddComment( Grid grid, string text )
        {
            if( grid != null
               && !string.IsNullOrEmpty( text ) )
            {
                try
                {
                    using var _range = grid?.GetRange( );
                    var _excelComment = _range?.AddComment( text, "Budget" );

                    if( _excelComment != null )
                    {
                        _excelComment.From.Row = _range.Start.Row;
                        _excelComment.From.Column = _range.Start.Column;
                        _excelComment.To.Row = _range.End.Row;
                        _excelComment.To.Column = _range.End.Column;
                        _excelComment.BackgroundColor = Color.FromArgb( 15, 15, 15 );
                        _excelComment.Font.FontName = "Roboto";
                        _excelComment.Font.Size = 8;
                        _excelComment.Font.Color = Color.Black;
                        _excelComment.Text = text;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the caption text.
        /// </summary>
        /// <param name="grid">The grid.</param>
        public void SetCaptionText( Grid grid )
        {
            if( grid != null )
            {
                try
                {
                    using var _sheet = grid.GetWorksheet( );
                    var _row = grid.GetRange( ).Start.Row;
                    var _column = grid.GetRange( ).Start.Column;
                    _sheet.Cells[ _row, _column ].Value = "Account";
                    _sheet.Cells[ _row, _column + 1 ].Value = "SuperfundSite";
                    _sheet.Cells[ _row, _column + 2 ].Value = "Travel";
                    _sheet.Cells[ _row, _column + 3 ].Value = "Expenses";
                    _sheet.Cells[ _row, _column + 4 ].Value = "Contracts";
                    _sheet.Cells[ _row, _column + 5 ].Value = "Grants";
                    _sheet.Cells[ _row, _column + 6 ].Value = "Total";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="text">The text.</param>
        public void SetText( Grid grid, IEnumerable<string> text )
        {
            if( grid != null
               && text?.Any( ) == true
               && grid.GetRange( ).Any( ) )
            {
                try
                {
                    foreach( var cell in grid.GetRange( ) )
                    {
                        foreach( var caption in text )
                        {
                            if( cell != null
                               && !string.IsNullOrEmpty( caption ) )
                            {
                                cell.Value = caption;
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
        /// Get Error Dialog.
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