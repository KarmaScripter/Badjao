// // <copyright file = "EnumerableExtensions.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using BudgetExecution;
    using OfficeOpenXml;
    using TableStyles = OfficeOpenXml.Table.TableStyles;

    public static class EnumerableExtensions
    {
        /// <summary>
        /// Determines whether this instance has numeric.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <returns>
        ///   <c>true</c> if the specified dataRow has numeric; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasNumeric( this IEnumerable<DataRow> dataRow )
        {
            if( dataRow?.Any( ) == true )
            {
                try
                {
                    var _row = dataRow?.First( );
                    var _dictionary = _row?.ToDictionary( );
                    var _array = _dictionary?.Keys.ToArray( );
                    var _names = Enum.GetNames( typeof( Numeric ) );
                    if( _array != null )
                    {
                        foreach( var k in _array )
                        {
                            if( _names?.Contains( k ) == true )
                            {
                                return true;
                            }
                        }
                    }

                    return false;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( bool );
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether [has primary key].
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <returns>
        ///   <c>true</c> if [has primary key] [the specified dataRow]; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasPrimaryKey( this IEnumerable<DataRow> dataRow )
        {
            if( dataRow?.Any( ) == true )
            {
                try
                {
                    var _row = dataRow?.First( );
                    var _dict = _row?.ToDictionary( );
                    var _key = _dict?.Keys.ToArray( );
                    var _names = Enum.GetNames( typeof( PrimaryKey ) );
                    if( _key != null )
                    {
                        foreach( var k in _key )
                        {
                            if( !string.IsNullOrEmpty( k )
                               && _names?.Contains( k ) == true )
                            {
                                return true;
                            }
                        }
                    }

                    return false;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( bool );
                }
            }

            return false;
        }

        /// <summary>
        /// Gets the primary key values.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <returns></returns>
        public static IEnumerable<int> GetPrimaryKeyValues( this IEnumerable<DataRow> dataRow )
        {
            if( dataRow?.Any( ) == true
               && dataRow.HasPrimaryKey( ) )
            {
                try
                {
                    var _list = new List<int>( );
                    foreach( var _row in dataRow )
                    {
                        if( _row?.ItemArray[ 0 ] != null )
                        {
                            _list?.Add( int.Parse( _row.ItemArray[ 0 ]?.ToString( ) ) );
                        }
                    }

                    return _list?.Any( ) == true
                        ? _list.ToArray( )
                        : default( int[ ] );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<int> );
                }
            }

            return default( IEnumerable<int> );
        }

        /// <summary>
        /// Converts IEnumerable to BindingList.
        /// </summary>
        /// <param name="dataRows">The IEnumerable</param>
        /// <returns></returns>
        public static BindingList<DataRow> ToBindingList( this IEnumerable<DataRow> dataRows )
        {
            if( dataRows?.Any( ) == true )
            {
                try
                {
                    var _list = new BindingList<DataRow>( );
                    foreach( var item in dataRows )
                    {
                        _list.Add( item );
                    }

                    return _list?.Any( ) == true
                        ? _list
                        : default( BindingList<DataRow> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( BindingList<DataRow> );
                }
            }

            return default( BindingList<DataRow> );
        }

        /// <summary>
        /// Filters the specified columnName.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <param name="columnName">The columnName.</param>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        public static IEnumerable<DataRow> Filter( this IEnumerable<DataRow> dataRow,
            string columnName, string filter )
        {
            if( dataRow?.Any( ) == true
               && !string.IsNullOrEmpty( columnName )
               && !string.IsNullOrEmpty( filter ) )
            {
                try
                {
                    var _row = dataRow?.First( );
                    var _dictionary = _row.ToDictionary( );
                    var _array = _dictionary.Keys.ToArray( );
                    if( _array?.Contains( columnName ) == true )
                    {
                        var _select = dataRow?.Where( p => p.Field<string>( columnName ) == filter )
                            ?.Select( p => p );

                        return _select?.Any( ) == true
                            ? _select
                            : default( IEnumerable<DataRow> );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DataRow> );
                }
            }

            return default( IEnumerable<DataRow> );
        }

        /// <summary>
        /// Filters the specified dictionary.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        public static IEnumerable<DataRow> Filter( this IEnumerable<DataRow> dataRow,
            IDictionary<string, object> dict )
        {
            if( dataRow?.Any( ) == true
               && dict?.Any( ) == true )
            {
                try
                {
                    var _table = dataRow.CopyToDataTable( );
                    var _rows = _table?.Select( dict.ToCriteria( ) );
                    return _rows?.Any( ) == true
                        ? _rows
                        : default( IEnumerable<DataRow> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DataRow> );
                }
            }

            return default( IEnumerable<DataRow> );
        }

        /// <summary>
        /// Filters the specified column.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <param name="column">The column.</param>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        public static IEnumerable<DataRow> Filter( this IEnumerable<DataRow> dataRow,
            DataColumn column, string filter )
        {
            if( dataRow?.Any( ) == true
               && column != null
               && !string.IsNullOrEmpty( filter ) )
            {
                try
                {
                    var _row = dataRow?.First( );
                    var _columns = _row?.Table?.Columns;
                    if( _columns?.Contains( column?.ColumnName ) == true )
                    {
                        var _enumerable = dataRow
                            ?.Where( p => p.Field<string>( column.ColumnName ).Equals( filter ) )
                            ?.Select( p => p );

                        return _enumerable?.Any( ) == true
                            ? _enumerable.ToArray( )
                            : default( DataRow[ ] );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DataRow> );
                }
            }

            return default( IEnumerable<DataRow> );
        }

        /// <summary>
        /// Filters the specified field.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The filter.</param>
        /// <returns></returns>
        public static IEnumerable<DataRow> Filter( this IEnumerable<DataRow> dataRow, Field field,
            string filter )
        {
            if( dataRow?.Any( ) == true
               && Enum.IsDefined( typeof( Field ), field )
               && !string.IsNullOrEmpty( filter ) )
            {
                try
                {
                    var _row = dataRow?.First( );
                    var _columns = _row?.Table?.Columns;
                    if( _columns?.Contains( field.ToString( ) ) == true )
                    {
                        var _enumerable = dataRow
                            ?.Where( p => p.Field<string>( field.ToString( ) ).Equals( filter ) )
                            ?.Select( p => p );

                        return _enumerable?.Any( ) == true
                            ? _enumerable.ToArray( )
                            : default( DataRow[ ] );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DataRow> );
                }
            }

            return default( IEnumerable<DataRow> );
        }

        /// <summary>
        /// Converts to excel.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type">The dataRow.</param>
        /// <param name="path">The path.</param>
        /// <param name = "style" > </param>
        /// <exception cref="Exception">
        /// Invalid file path.
        /// or
        /// Invalid file path.
        /// or
        /// No dataRow to export.
        /// </exception>
        public static ExcelPackage ToExcel<T>( this IEnumerable<T> type, string path,
            TableStyles style = TableStyles.Light1 )
        {
            if( string.IsNullOrEmpty( path )
               && type?.Any( ) == true
               && Enum.IsDefined( typeof( TableStyles ), style ) )
            {
                throw new ArgumentException( "Verify Path" );
            }

            try
            {
                using var _excel = new ExcelPackage( new FileInfo( path ) );
                var _workbook = _excel.Workbook;
                var _worksheet = _workbook.Worksheets[ 0 ];
                var _range = _worksheet.Cells;
                _range?.LoadFromCollection( type, true, style );
                return _excel;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ExcelPackage );
            }
        }

        /// <summary>
        /// Slices the specified start.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type">The dataRow.</param>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <returns></returns>
        public static IEnumerable<T> LazySlice<T>( this IEnumerable<T> type, int start, int end )
        {
            if( type?.Any( ) == true
               && start > 0
               && end > 0 )
            {
                var _index = 0;
                foreach( var item in type )
                {
                    if( _index >= end )
                    {
                        yield break;
                    }

                    if( _index >= start )
                    {
                        yield return item;
                    }

                    ++_index;
                }
            }
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