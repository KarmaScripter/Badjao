// <copyright file = "ExcelQuery.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;
    using OfficeOpenXml;
    using DataTable = System.Data.DataTable;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Query" />
    public class ExcelQuery : Query
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelQuery"/> class.
        /// </summary>
        public ExcelQuery( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ExcelQuery"/> class.
        /// </summary>
        /// <param name = "source" >
        /// The source.
        /// </param>
        public ExcelQuery( Source source )
            : base( source, Provider.Access, SQL.SELECT )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ExcelQuery"/> class.
        /// </summary>
        /// <param name = "source" >
        /// The source.
        /// </param>
        /// <param name = "dict" >
        /// The dictionary.
        /// </param>
        public ExcelQuery( Source source, IDictionary<string, object> dict )
            : base( source, Provider.Access, dict, SQL.SELECT )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelQuery"/> class.
        /// </summary>
        /// <param name="source">The source Data.</param>
        /// <param name="provider">The provider used.</param>
        /// <param name="dict">The dictionary of parameters.</param>
        /// <param name="commandType">The type of sql command.</param>
        public ExcelQuery( Source source, Provider provider, IDictionary<string, object> dict,
            SQL commandType )
            : base( source, provider, dict, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelQuery"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="updates"></param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public ExcelQuery( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
            : base( source, provider, updates, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelQuery"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="criteria">The criteria.</param>
        /// <param name="commandType">Type of the command.</param>
        public ExcelQuery( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> criteria, SQL commandType = SQL.SELECT )
            : base( source, provider, columns, criteria, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ExcelQuery"/> class.
        /// </summary>
        /// <param name = "sqlStatement" >
        /// The sqlStatement.
        /// </param>
        public ExcelQuery( ISqlStatement sqlStatement )
            : base( sqlStatement )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelQuery"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        public ExcelQuery( Source source, Provider provider, string sqlText )
            : base( source, provider, sqlText )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelQuery"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="dict">The dictionary.</param>
        public ExcelQuery( Source source, Provider provider, IDictionary<string, object> dict )
            : base( source, provider, dict )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelQuery"/> class.
        /// </summary>
        /// <param name="fullPath">The fullpath.</param>
        /// <param name="sqlText"></param>
        /// <param name="commandType">The commandType.</param>
        public ExcelQuery( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
            : base( fullPath, sqlText, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExcelQuery"/> class.
        /// </summary>
        /// <param name="fullPath">The fullpath.</param>
        /// <param name="commandType">The commandType.</param>
        /// <param name="dict">The dictionary.</param>
        public ExcelQuery( string fullPath, SQL commandType, IDictionary<string, object> dict )
            : base( fullPath, commandType, dict )
        {
        }

        /// <summary>
        /// Saves the file.
        /// </summary>
        /// <param name="workBook">The work book.</param>
        public void SaveFile( ExcelPackage workBook )
        {
            if( workBook != null )
            {
                try
                {
                    var _dialog = new SaveFileDialog
                    {
                        Filter = "Excel files (*.xlsx)|*.xlsx",
                        FilterIndex = 1
                    };

                    if( _dialog?.ShowDialog( ) == DialogResult.OK )
                    {
                        var _name = _dialog.FileName;
                        workBook.Save( _name );
                        const string _successful = "Save Successful!";
                        var _message = new Message( _successful );
                        _message?.ShowDialog( );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Writes the excel file.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="filePath">The file path.</param>
        public void WriteExcelFile( DataTable table, string filePath )
        {
            if( table?.Columns.Count > 0 
               && !string.IsNullOrEmpty( filePath ) )
            {
                try
                {
                    using var _excelPackage = ReadExcelFile( filePath );
                    var _name = Path.GetFileNameWithoutExtension( filePath );
                    var _excelWorksheet = _excelPackage?.Workbook?.Worksheets?.Add( _name );
                    var _columns = table?.Columns?.Count;
                    var _rows = table?.Rows?.Count;
                    for( var column = 1; column <= _columns; column++ )
                    {
                        if( _excelWorksheet != null )
                        {
                            _excelWorksheet.Cells[ 1, column ].Value =
                                table.Columns[ column - 1 ].ColumnName;
                        }
                    }

                    for( var row = 1; row <= _rows; row++ )
                    {
                        for( var col = 0; col < _columns; col++ )
                        {
                            if( _excelWorksheet != null )
                            {
                                _excelWorksheet.Cells[ row + 1, col + 1 ].Value =
                                    table.Rows[ row - 1 ][ col ];
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
        /// Reads the excel file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        private static ExcelPackage ReadExcelFile( string filePath )
        {
            if( !string.IsNullOrEmpty( filePath ) )
            {
                try
                {
                    var _fileInfo = new FileInfo( filePath );
                    return new ExcelPackage( _fileInfo );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( ExcelPackage );
                }
            }

            return default( ExcelPackage );
        }

        /// <summary>
        /// Gets the excel file.
        /// </summary>
        /// <returns></returns>
        public string GetExcelFile( )
        {
            try
            {
                var _fileName = "";
                var dialog = new OpenFileDialog
                {
                    Title = "Excel File Dialog",
                    InitialDirectory = @"c:\",
                    Filter = "All files (*.*)|*.*|All files (*.*)|*.*",
                    FilterIndex = 2,
                    RestoreDirectory = true
                };

                if( dialog.ShowDialog( ) == DialogResult.OK )
                {
                    _fileName = dialog.FileName;
                }

                return _fileName;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// Imports the Data.
        /// </summary>
        /// <param name="sheetName">Name of the sheet.</param>
        /// <returns></returns>
        public DataTable ImportData( ref string sheetName )
        {
            if( !string.IsNullOrEmpty( sheetName ) )
            {
                try
                {
                    var _dataSet = new DataSet( );
                    var _connection = DataConnection as OleDbConnection;
                    _connection?.Open( );
                    var _sql = $"SELECT * FROM {sheetName}";
                    var _schema = _connection?.GetOleDbSchemaTable( OleDbSchemaGuid.Tables, null );
                    if( _schema?.Columns?.Count > 0
                       && !SheetExists( sheetName, _schema ) )
                    {
                        const string _msg = "Sheet Does Not Exist!";
                        var _message = new Message( _msg );
                        _message?.ShowDialog( );
                    }
                    else
                    {
                        sheetName = _schema?.Rows[ 0 ][ "TABLENAME" ].ToString( );
                    }

                    var _adapter = new OleDbDataAdapter( _sql, _connection );
                    _adapter?.Fill( _dataSet );
                    return _dataSet?.Tables[ 0 ];
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DataTable );
                }
            }

            return default( DataTable );
        }

        private DbConnection GetConnection( )
        {
            throw new NotImplementedException( );
        }

        /// <summary>
        /// CSVs the import.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="sheetName">Name of the sheet.</param>
        /// <returns></returns>
        public DataTable CsvImport( string fileName, ref string sheetName )
        {
            if( !string.IsNullOrEmpty( fileName )
               && !string.IsNullOrEmpty( sheetName ) )
            {
                try
                {
                    var _data = new DataSet( );
                    var _sql = $"SELECT * FROM {sheetName}";
                    var _connectionString = $@"Provider=Microsoft.Jet.OLEDB.4.0;"
                    + $"Data Source={Path.GetDirectoryName( fileName )} "
                    + "Extended Properties='Text;HDR=YES;FMT=Delimited'";

                    var _connection = new OleDbConnection( _connectionString );
                    var _schema = _connection.GetOleDbSchemaTable( OleDbSchemaGuid.Tables, null );
                    if( !string.IsNullOrEmpty( sheetName ) )
                    {
                        if( !SheetExists( sheetName, _schema ) )
                        {
                            var _msg = $"{sheetName} in {fileName} Does Not Exist!";
                            var _message = new Message( _msg );
                            _message?.ShowDialog( );
                        }
                    }
                    else
                    {
                        sheetName = _schema?.Rows[ 0 ][ "TABLENAME" ].ToString( );
                    }

                    var _dataAdapter = new OleDbDataAdapter( _sql, _connection );
                    _dataAdapter.Fill( _data );
                    return _data.Tables[ 0 ];
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DataTable );
                }
            }

            return default( DataTable );
        }

        /// <summary>
        /// Exports to Data grid.
        /// </summary>
        /// <param name="dataGrid">The Data grid.</param>
        private void ExportToDataGrid( DataGridView dataGrid )
        {
            try
            {
                var _filePath = ConnectionBuilder.DbPath;
                var _stream = new FileInfo( _filePath );
                var _application = new ExcelPackage( _stream );
                var _workbook = _application.Workbook;
                var _worksheet = _workbook.Worksheets[ 1 ];
                var _range = _worksheet.SelectedRange;
                var _rows = _range.Rows;
                var _columns = _range.Columns;
                dataGrid.ColumnCount = _columns;
                dataGrid.RowCount = _rows;
                for( var i = 1; i <= _rows; i++ )
                {
                    for( var j = 1; j <= _columns; j++ )
                    {
                        if( _range[ i, j ].Address != null
                           && _range[ i, j ].Value != null )
                        {
                            dataGrid.Rows[ i - 1 ].Cells[ j - 1 ].Value = _range[ i, j ].Address;
                        }
                    }
                }

                Release( _range, _worksheet, _application );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sheets the exists.
        /// </summary>
        /// <param name="sheetName">Name of the sheet.</param>
        /// <param name="dataTable">The Data table.</param>
        /// <returns></returns>
        private bool SheetExists( string sheetName, DataTable dataTable )
        {
            if( !string.IsNullOrEmpty( sheetName )
               && dataTable?.Columns.Count > 0
               && dataTable.Rows.Count > 0 )
            {
                try
                {
                    for( var i = 0; i < dataTable.Rows.Count; i++ )
                    {
                        var _dataRow = dataTable.Rows[ i ];
                        if( sheetName == _dataRow[ "TABLENAME" ].ToString( ) )
                        {
                            return true;
                        }
                    }

                    return false;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return false;
        }

        /// <summary>
        /// Releases the specified range.
        /// </summary>
        /// <param name="range">The range.</param>
        /// <param name="workSheet">The work sheet.</param>
        /// <param name="excel">The excel.</param>
        protected virtual void Release( ExcelRange range, ExcelWorksheet workSheet,
            ExcelPackage excel )
        {
            try
            {
                GC.Collect( );
                GC.WaitForPendingFinalizers( );
                Marshal.ReleaseComObject( range );
                Marshal.ReleaseComObject( workSheet );
                Marshal.ReleaseComObject( excel );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>
        /// true
        /// </c>
        /// to release both managed and unmanaged resources;
        /// <c>
        /// false
        /// </c>
        /// to release only unmanaged resources.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                base.Dispose( disposing );
            }

            IsDisposed = true;
        }
    }
}