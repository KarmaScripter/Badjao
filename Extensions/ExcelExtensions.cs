// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using OfficeOpenXml;
    using OfficeOpenXml.Style;
    using VisualPlus.Extensibility;

    /// <summary>
    /// 
    /// </summary>
    public static class ExcelExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        public enum InsertMode
        {
            /// <summary>The row before</summary>
            RowBefore, RowAfter,

            ColumnRight,

            ColumnLeft
        }

        /// <summary>Converts to dataset.</summary>
        /// <param name="excelPackage">The excelPackage.</param>
        /// <param name="header">if set to <c>true</c> [header].</param>
        /// <returns></returns>
        public static DataSet ToDataSet( this ExcelPackage excelPackage, bool header = false )
        {
            var _row = header
                ? 1
                : 0;

            return excelPackage.ToDataSet( _row );
        }

        /// <summary>Converts to dataset.</summary>
        /// <param name="excelPackage">The excelPackage.</param>
        /// <param name="header">The header.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">header - Must be 0 or greater.</exception>
        public static DataSet ToDataSet( this ExcelPackage excelPackage, int header = 0 )
        {
            if( header < 0 )
            {
                throw new ArgumentOutOfRangeException( nameof( header ), header,
                    "Must be 0 or greater." );
            }

            var _result = new DataSet( );

            foreach( var _worksheet in excelPackage.Workbook.Worksheets )
            {
                var _table = new DataTable( ) ;
                _table.TableName = _worksheet?.Name;
                var _start = 1;

                if( header > 0 )
                {
                    _start = header;
                }

                var _columns =
                    from _cell in _worksheet?.Cells[ _start, 1, _start,
                        _worksheet.Dimension.End.Column ] select new DataColumn( header > 0
                        ? _cell?.Value?.ToString( )
                        : $"Column {_cell?.Start?.Column}" );

                _table.Columns.AddRange( _columns?.ToArray( ) );

                var i = header > 0
                    ? _start + 1
                    : _start;

                for( var index = i; index <= _worksheet?.Dimension.End.Row; index++ )
                {
                    var _range =
                        _worksheet.Cells[ index, 1, index, _worksheet.Dimension.End.Column ];

                    var _row = _table.Rows.Add( );

                    foreach( var cell in _range )
                    {
                        _row[ cell.Start.Column - 1 ] = cell.Value;
                    }
                }

                _result.Tables.Add( _table );
            }

            return _result;
        }

        /// <summary>Trims the last empty rows.</summary>
        /// <param name="worksheet">The worksheet.</param>
        public static void TrimLastEmptyRows( this ExcelWorksheet worksheet )
        {
            while( worksheet.IsLastRowEmpty( ) )
            {
                worksheet.DeleteRow( worksheet.Dimension.End.Row, 1 );
            }
        }

        /// <summary>
        /// Determines whether [is last row empty].
        /// </summary>
        /// <param name="worksheet">The worksheet.</param>
        /// <returns>
        ///   <c>true</c> if [is last row empty] [the specified worksheet]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsLastRowEmpty( this ExcelWorksheet worksheet )
        {
            var _empties = new List<bool>( );

            for( var index = 1; index <= worksheet.Dimension.End.Column; index++ )
            {
                var _value = worksheet.Cells[ worksheet.Dimension.End.Row, index ].Value;
                _empties.Add( string.IsNullOrEmpty( _value?.ToString( ) ) );
            }

            return _empties.All( e => e );
        }

        /// <summary>Sets the width.</summary>
        /// <param name="column">The column.</param>
        /// <param name="width">The width.</param>
        public static void SetWidth( this ExcelColumn column, double width )
        {
            var _first = width >= 1.0
                ? Math.Round( ( Math.Round( 7.0 * ( width - 0.0 ), 0 ) - 5.0 ) / 7.0, 2 )
                : Math.Round(
                    ( Math.Round( 12.0 * ( width - 0.0 ), 0 ) - Math.Round( 5.0 * width, 0 ) )
                    / 12.0, 2 );

            var _second = width - _first;

            var _third = width >= 1.0
                ? Math.Round( 7.0 * _second - 0.0, 0 ) / 7.0
                : Math.Round( 12.0 * _second - 0.0, 0 ) / 12.0 + 0.0;

            column.Width = _first > 0.0
                ? width + _third
                : 0.0;
        }

        /// <summary>Sets the height.</summary>
        /// <param name="row">The row.</param>
        /// <param name="height">The height.</param>
        public static void SetHeight( this ExcelRow row, double height )
        {
            row.Height = height;
        }

        /// <summary>Expands the column.</summary>
        /// <param name="index">The index.</param>
        /// <param name="offset">The offset.</param>
        /// <returns></returns>
        public static int[ ] ExpandColumn( this int[ ] index, int offset )
        {
            var _column = index;
            _column[ 3 ] += offset;

            return _column;
        }

        /// <summary>Expands the row.</summary>
        /// <param name="index">The index.</param>
        /// <param name="offset">The offset.</param>
        /// <returns></returns>
        public static int[ ] ExpandRow( this int[ ] index, int offset )
        {
            var row = index;
            row[ 2 ] += offset;

            return row;
        }

        /// <summary>Moves the column.</summary>
        /// <param name="index">The index.</param>
        /// <param name="offset">The offset.</param>
        /// <returns></returns>
        public static int[ ] MoveColumn( this int[ ] index, int offset )
        {
            var _column = index;
            _column[ 1 ] += offset;
            _column[ 3 ] += offset;

            return _column;
        }

        /// <summary>Moves the row.</summary>
        /// <param name="index">The index.</param>
        /// <param name="offset">The offset.</param>
        /// <returns></returns>
        public static int[ ] MoveRow( this int[ ] index, int offset )
        {
            var _row = index;
            _row[ 0 ] += offset;
            _row[ 2 ] += offset;

            return _row;
        }

        /// <summary>Alls the border.</summary>
        /// <param name="range">The range.</param>
        /// <param name="borderstyle">The borderstyle.</param>
        public static void AllBorder( this ExcelRange range, ExcelBorderStyle borderstyle )
        {
            range.ForEach( r => r.Style.Border.BorderAround( borderstyle ) );
        }

        /// <summary>Backgrounds the color.</summary>
        /// <param name="range">The range.</param>
        /// <param name="color">The color.</param>
        /// <param name="fillstyle">The fillstyle.</param>
        public static void BackgroundColor( this ExcelRange range, Color color,
            ExcelFillStyle fillstyle = ExcelFillStyle.Solid )
        {
            range.Style.Fill.PatternType = fillstyle;
            range.Style.Fill.BackgroundColor.SetColor( color );
        }

        /// <summary>Fails the specified ex.</summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}