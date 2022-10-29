//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics;
    using System.Linq;
    using DocumentFormat.OpenXml;
    using DocumentFormat.OpenXml.Packaging;
    using DocumentFormat.OpenXml.Spreadsheet;

    public class ExcelReport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelReport"/> class.
        /// </summary>
        public ExcelReport( )
        {
        }

        /// <summary>
        /// Creates the excel document.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">The data.</param>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public bool CreateExcelDocument<T>( IEnumerable<T> data, string path )
        {
            if( data != null
               && !string.IsNullOrEmpty( path ) )
            {
                try
                {
                    using var _dataSet = new DataSet( );
                    _dataSet?.Tables?.Add( ListToDataTable( data ) );
                    return CreateExcelDocument( _dataSet, path );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Creates the excel document.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public bool CreateExcelDocument( DataTable dataTable, string path )
        {
            if( !string.IsNullOrEmpty( path )
               && dataTable?.Rows?.Count > 0
               && dataTable?.Columns?.Count > 0 )
            {
                try
                {
                    using var _dataSet = new DataSet( );
                    _dataSet.Tables.Add( dataTable );
                    var _document = CreateExcelDocument( _dataSet, path );
                    _dataSet.Tables.Remove( dataTable );
                    return _document;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return false;
        }

        /// <summary>
        /// Creates the excel document.
        /// </summary>
        /// <param name="dataSet">The data set.</param>
        /// <param name="fileName">Name of the file.</param>
        /// <returns></returns>
        public bool CreateExcelDocument( DataSet dataSet, string fileName )
        {
            if( !string.IsNullOrEmpty( fileName )
               && dataSet != null )
            {
                try
                {
                    using( var _document =
                          SpreadsheetDocument.Create( fileName, SpreadsheetDocumentType.Workbook ) )
                    {
                        WriteExcelFile( dataSet, _document );
                    }

                    Trace.WriteLine( "Successfully created: " + fileName );
                    return true;
                }
                catch( Exception ex )
                {
                    Trace.WriteLine( "Failed, exception thrown: " + ex.Message );
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Lists to data table.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public DataTable ListToDataTable<T>( IEnumerable<T> data )
        {
            if( data?.Any( ) == true )
            {
                try
                {
                    var _table = new DataTable( );

                    foreach( var info in typeof( T ).GetProperties( ) )
                    {
                        _table?.Columns?.Add( new DataColumn( info.Name,
                            GetNullableType( info.PropertyType ) ) );
                    }

                    foreach( var t in data )
                    {
                        var _row = _table.NewRow( );

                        foreach( var info in typeof( T ).GetProperties( ) )
                        {
                            _row[ info.Name ] = !IsNullableType( info.PropertyType )
                                ? info.GetValue( t, null )
                                : info.GetValue( t, null ) ?? DBNull.Value;
                        }

                        _table.Rows.Add( _row );
                    }

                    return _table;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Gets the type of the nullable.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public Type GetNullableType( Type type )
        {
            try
            {
                var _returnType = type;

                if( type.IsGenericType
                   && type.GetGenericTypeDefinition( ) == typeof( Nullable<> ) )
                {
                    _returnType = Nullable.GetUnderlyingType( type );
                }

                return _returnType;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Appends the text cell.
        /// </summary>
        /// <param name="cellReference">The cell reference.</param>
        /// <param name="cellStringValue">The cell string value.</param>
        /// <param name="excelRow">The excel row.</param>
        public void AppendTextCell( string cellReference, string cellStringValue,
            OpenXmlElement excelRow )
        {
            try
            {
                var _cell = new Cell
                {
                    CellReference = cellReference,
                    DataType = CellValues.String
                };

                var _cellValue = new CellValue { Text = cellStringValue };
                _cell.Append( _cellValue );
                excelRow.Append( _cell );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Appends the numeric cell.
        /// </summary>
        /// <param name="cellReference">The cell reference.</param>
        /// <param name="cellStringValue">The cell string value.</param>
        /// <param name="excelRow">The excel row.</param>
        public void AppendNumericCell( string cellReference, string cellStringValue,
            OpenXmlElement excelRow )
        {
            if( !string.IsNullOrEmpty( cellReference )
               && !string.IsNullOrEmpty( cellStringValue )
               && excelRow != null )
            {
                try
                {
                    var _cell = new Cell { CellReference = cellReference };
                    var _cellValue = new CellValue { Text = cellStringValue };
                    _cell.Append( _cellValue );
                    excelRow.Append( _cell );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the name of the excel column.
        /// </summary>
        /// <param name="columnIndex">Index of the column.</param>
        /// <returns></returns>
        public string GetExcelColumnName( int columnIndex )
        {
            try
            {
                if( columnIndex < 26 )
                {
                    return ( (char)( 'A' + columnIndex ) ).ToString( );
                }

                var _first = (char)( 'A' + columnIndex / 26 - 1 );
                var _second = (char)( 'A' + columnIndex % 26 );
                return $"{_first}{_second}";
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Writes the excel file.
        /// </summary>
        /// <param name="dataSet">The data set.</param>
        /// <param name="spreadSheet">The spread sheet.</param>
        public void WriteExcelFile( DataSet dataSet, SpreadsheetDocument spreadSheet )
        {
            if( dataSet != null
               && spreadSheet != null )
            {
                try
                {
                    spreadSheet.AddWorkbookPart( );

                    if( spreadSheet.WorkbookPart != null )
                    {
                        spreadSheet.WorkbookPart.Workbook =
                            new DocumentFormat.OpenXml.Spreadsheet.Workbook( );

                        spreadSheet.WorkbookPart.Workbook?.Append(
                            new BookViews( new WorkbookView( ) ) );

                        var _styles =
                            spreadSheet.WorkbookPart.AddNewPart<WorkbookStylesPart>( "rIdStyles" );

                        var _stylesheet = new Stylesheet( );
                        _styles.Stylesheet = _stylesheet;
                        uint _id = 1;

                        foreach( DataTable _dataTable in dataSet.Tables )
                        {
                            var _part = spreadSheet?.WorkbookPart?.AddNewPart<WorksheetPart>( );

                            if( _part != null )
                            {
                                _part.Worksheet = new Worksheet( );
                                _part.Worksheet.AppendChild( new SheetData( ) );
                                WriteDataTableToExcelWorksheet( _dataTable, _part );
                                _part.Worksheet.Save( );

                                if( _id == 1 )
                                {
                                    spreadSheet?.WorkbookPart?.Workbook?.AppendChild(
                                        new Sheets( ) );
                                }

                                spreadSheet.WorkbookPart?.Workbook?.GetFirstChild<Sheets>( )
                                    ?.AppendChild( new Sheet
                                    {
                                        Id = spreadSheet.WorkbookPart.GetIdOfPart( _part ),
                                        SheetId = _id,
                                        Name = _dataTable.TableName
                                    } );
                            }

                            _id++;
                        }

                        spreadSheet.WorkbookPart?.Workbook?.Save( );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Writes the data table to excel worksheet.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <param name="workSheetPart">The work sheet part.</param>
        public void WriteDataTableToExcelWorksheet( DataTable dataTable,
            WorksheetPart workSheetPart )
        {
            if( dataTable?.Rows.Count > 0
               && dataTable.Columns.Count > 0
               && workSheetPart != null )
            {
                try
                {
                    var _worksheet = workSheetPart.Worksheet;
                    var _data = _worksheet?.GetFirstChild<SheetData>( );
                    var _columns = dataTable.Columns.Count;
                    var _isNumeric = new bool[ _columns ];
                    var _names = new string[ _columns ];

                    for( var n = 0; n < _columns; n++ )
                    {
                        _names[ n ] = GetExcelColumnName( n );
                    }

                    uint _rowIndex = 1;
                    var _row = new Row { RowIndex = _rowIndex };
                    _data?.Append( _row );

                    for( var colinx = 0; colinx < _columns; colinx++ )
                    {
                        var _column = dataTable.Columns[ colinx ];
                        AppendTextCell( _names[ colinx ] + "1", _column.ColumnName, _row );

                        _isNumeric[ colinx ] = _column.DataType.FullName == "System.Decimal"
                            || _column.DataType.FullName == "System.Int32";
                    }

                    foreach( DataRow _dataRow in dataTable.Rows )
                    {
                        ++_rowIndex;
                        var _excelRow = new Row { RowIndex = _rowIndex };
                        _data?.Append( _excelRow );

                        for( var i = 0; i < _columns; i++ )
                        {
                            var _value = _dataRow?.ItemArray[ i ].ToString( );

                            if( _isNumeric[ i ] )
                            {
                                if( double.TryParse( _value, out var cellnumericvalue ) )
                                {
                                    _value = cellnumericvalue.ToString( );
                                    AppendNumericCell( _names[ i ] + _rowIndex, _value, _excelRow );
                                }
                            }
                            else
                            {
                                AppendTextCell( _names[ i ] + _rowIndex, _value, _excelRow );
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
        /// Determines whether [is nullable type] [the specified type].
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>
        ///   <c>true</c> if [is nullable type] [the specified type]; otherwise, <c>false</c>.
        /// </returns>
        protected bool IsNullableType( Type type )
        {
            try
            {
                return type == typeof( string ) || type.IsArray || type.IsGenericType
                    && type.GetGenericTypeDefinition( ) == typeof( Nullable<> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return false;
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