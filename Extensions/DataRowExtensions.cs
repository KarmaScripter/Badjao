// // <copyright file = "DataRowExtensions.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Data.SqlServerCe;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using BudgetExecution;

    /// <summary>
    /// 
    /// </summary>
    public static class DataRowExtensions
    {
        /// <summary>
        /// Converts to sql db parameters.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        /// <exception cref="InvalidEnumArgumentException">
        /// provider</exception>
        public static IEnumerable<DbParameter> ToSqlDbParameters( this DataRow dataRow,
            Provider provider )
        {
            if( dataRow != null
               && dataRow.ItemArray.Length > 0
               && Enum.IsDefined( typeof( Provider ), provider ) )
            {
                try
                {
                    {
                        var _table = dataRow.Table;
                        var _columns = _table?.Columns;
                        var _values = dataRow.ItemArray;
                        switch( provider )
                        {
                            case Provider.SQLite:
                            {
                                var _sqlite = new List<SQLiteParameter>( );
                                for( var i = 0; i < _columns?.Count; i++ )
                                {
                                    var _parameter = new SQLiteParameter
                                    {
                                        SourceColumn = _columns[ i ].ColumnName,
                                        Value = _values[ i ]
                                    };

                                    _sqlite.Add( _parameter );
                                }

                                return _sqlite?.Any( ) == true
                                    ? _sqlite as IEnumerable<DbParameter>
                                    : default( IList<DbParameter> );
                            }

                            case Provider.SqlCe:
                            {
                                var _sqlce = new List<SqlCeParameter>( );
                                for( var i = 0; i < _columns?.Count; i++ )
                                {
                                    var _parameter = new SqlCeParameter
                                    {
                                        SourceColumn = _columns[ i ].ColumnName,
                                        Value = _values[ i ]
                                    };

                                    _sqlce.Add( _parameter );
                                }

                                return _sqlce?.Any( ) == true
                                    ? _sqlce as IEnumerable<DbParameter>
                                    : default( IList<DbParameter> );
                            }

                            case Provider.OleDb:
                            case Provider.Excel:
                            case Provider.Access:
                            {
                                var _oledb = new List<OleDbParameter>( );
                                for( var i = 0; i < _columns?.Count; i++ )
                                {
                                    var parameter = new OleDbParameter
                                    {
                                        SourceColumn = _columns[ i ].ColumnName,
                                        Value = _values[ i ]
                                    };

                                    _oledb.Add( parameter );
                                }

                                return _oledb.Any( )
                                    ? _oledb as IEnumerable<DbParameter>
                                    : default( IList<DbParameter> );
                            }

                            case Provider.SqlServer:
                            {
                                var _sqlserver = new List<SqlParameter>( );
                                for( var i = 0; i < _columns?.Count; i++ )
                                {
                                    var _parameter = new SqlParameter
                                    {
                                        SourceColumn = _columns[ i ].ColumnName,
                                        Value = _values[ i ]
                                    };

                                    _sqlserver.Add( _parameter );
                                }

                                return _sqlserver?.Any( ) == true
                                    ? _sqlserver as IEnumerable<DbParameter>
                                    : default( List<DbParameter> );
                            }
                        }

                        return default( IEnumerable<DbParameter> );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DbParameter> );
                }
            }

            return default( IEnumerable<DbParameter> );
        }

        /// <summary>
        /// Converts to dictionary.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <returns></returns>
        public static IDictionary<string, object> ToDictionary( this DataRow dataRow )
        {
            try
            {
                if( dataRow?.ItemArray.Length > 0 )
                {
                    var _dictionary = new Dictionary<string, object>( );
                    var _table = dataRow?.Table;
                    var _column = _table?.Columns;
                    var _items = dataRow?.ItemArray;
                    for( var i = 0; i < _column?.Count; i++ )
                    {
                        if( !string.IsNullOrEmpty( _column[ i ]?.ColumnName ) )
                        {
                            _dictionary?.Add( _column[ i ].ColumnName,
                                _items[ i ] ?? default( object ) );
                        }
                    }

                    return _dictionary?.Keys?.Count > 0
                        ? _dictionary
                        : default( Dictionary<string, object> );
                }

                return default( IDictionary<string, object> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, object> );
            }
        }

        /// <summary>
        /// Gets the bytes.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="field">The field.</param>
        /// <returns></returns>
        public static IEnumerable<byte> GetBytes( this DataRow dataRow, string field )
        {
            try
            {
                return dataRow[ field ] as byte[ ];
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<byte> );
            }
        }

        /// <summary>
        /// Gets the field.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="field">The field.</param>
        /// <returns></returns>
        public static string GetField( this DataRow dataRow, Field field )
        {
            if( dataRow != null
               && dataRow.ItemArray.Length > 0
               && Enum.IsDefined( typeof( Field ), field ) )
            {
                var _columns = dataRow.Table?.GetColumnNames( );
                if( _columns?.Any( ) == true
                   && _columns.Contains( $"{field}" ) )
                {
                    try
                    {
                        return dataRow[ $"{field}" ].ToString( );
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                        return default( string );
                    }
                }
            }

            return default( string );
        }

        /// <summary>
        /// Gets the numeric.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public static double GetNumeric( this DataRow dataRow, Numeric numeric )
        {
            if( dataRow != null
               && dataRow.ItemArray.Length > 0
               && Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                var _columns = dataRow.Table?.GetColumnNames( );
                if( _columns?.Any( ) == true
                   && _columns.Contains( $"{numeric}" ) )
                {
                    try
                    {
                        return double.Parse( dataRow[ $"{numeric}" ].ToString( ) );
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                        return 0.0;
                    }
                }
            }

            return 0.0;
        }

        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="field">The field.</param>
        /// <returns></returns>
        public static DateTime GetDate( this DataRow dataRow, Field field )
        {
            if( dataRow != null
               && dataRow.ItemArray.Length > 0
               && Enum.IsDefined( typeof( Field ), field ) )
            {
                var _columns = dataRow.Table?.GetColumnNames( );
                if( _columns != null
                   && _columns?.Any( ) == true & _columns.Contains( $"{field}" ) )
                {
                    try
                    {
                        return DateTime.Parse( dataRow[ $"{field}" ].ToString( ) );
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                        return default( DateTime );
                    }
                }
            }

            return default( DateTime );
        }

        /// <summary>
        /// Determines whether this instance has numeric.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <returns>
        ///   <c>true</c> if the specified data row has numeric; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasNumeric( this DataRow dataRow )
        {
            if( dataRow != null
               && dataRow.ItemArray.Length > 0 )
            {
                try
                {
                    var _colums = dataRow.Table?.GetColumnNames( );
                    var _names = Enum.GetNames( typeof( Numeric ) );
                    for( var i = 1; i < _colums?.Length; i++ )
                    {
                        if( _names.Contains( _colums[ i ] ) )
                        {
                            return true;
                        }

                        if( !_names.Contains( _colums[ i ] ) )
                        {
                            return false;
                        }
                    }
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
        /// <param name="row">The row.</param>
        /// <returns>
        ///   <c>true</c> if [has primary key] [the specified row]; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasPrimaryKey( this DataRow row )
        {
            if( row?.ItemArray?.Length > 0 )
            {
                try
                {
                    var _dictionary = row.ToDictionary( );
                    var _key = _dictionary.Keys?.ToArray( );
                    var _names = Enum.GetNames( typeof( PrimaryKey ) );
                    var _count = 0;
                    for( var i = 1; i < _key.Length; i++ )
                    {
                        var name = _key[ i ];
                        if( _names.Contains( name ) )
                        {
                            _count++;
                        }
                    }

                    return _count > 0;
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
        /// Gets the primary key.
        /// </summary>
        /// <param name="row">The row.</param>
        /// <returns></returns>
        public static IDictionary<string, object> GetPrimaryKey( this DataRow row )
        {
            if( row?.ItemArray?.Length > 0 )
            {
                try
                {
                    var _dictionary = row.ToDictionary( );
                    var _key = _dictionary.Keys?.ToArray( );
                    var _names = Enum.GetNames( typeof( PrimaryKey ) );
                    for( var i = 1; i < _key?.Length; i++ )
                    {
                        var _name = _key[ i ];
                        if( _names.Contains( _name ) )
                        {
                            return new Dictionary<string, object>
                            {
                                [ _name ] = int.Parse( _dictionary[ _name ].ToString( ) )
                            };
                        }

                        if( !_names.Contains( _name ) )
                        {
                            return default( IDictionary<string, object> );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
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