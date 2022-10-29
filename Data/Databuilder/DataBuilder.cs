// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary> </summary>
    /// <seealso cref = "DataModel" />
    [ SuppressMessage( "ReSharper", "ClassCanBeSealed.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class DataBuilder : DataModel, IDataModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "DataBuilder" />
        /// class.
        /// </summary>
        public DataBuilder( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "DataBuilder" />
        /// class.
        /// </summary>
        /// <param name = "source" > The source. </param>
        /// <param name = "provider" > The provider. </param>
        public DataBuilder( Source source, Provider provider = Provider.Access )
            : base( source, provider )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "DataBuilder" />
        /// class.
        /// </summary>
        /// <param name = "source" > The source. </param>
        /// <param name = "provider" > The provider. </param>
        /// <param name = "where" > The arguments. </param>
        public DataBuilder( Source source, Provider provider, IDictionary<string, object> where )
            : base( source, provider, where )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "DataBuilder" />
        /// class.
        /// </summary>
        /// <param name = "source" > The source. </param>
        /// <param name = "dict" > The dictionary. </param>
        public DataBuilder( Source source, IDictionary<string, object> dict )
            : base( source, dict )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataBuilder"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="updates">The updates.</param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public DataBuilder( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
            : base( source, provider, updates, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataBuilder"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The criteria.</param>
        /// <param name="commandType">Type of the command.</param>
        public DataBuilder( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
            : base( source, provider, columns, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataBuilder"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        public DataBuilder( Source source, Provider provider, string sqlText )
            : base( source, provider, sqlText )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "DataBuilder" />
        /// class.
        /// </summary>
        /// <param name = "query" > The query. </param>
        public DataBuilder( IQuery query )
            : base( query )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataBuilder"/> class.
        /// </summary>
        /// <param name="fullPath">The full path.</param>
        /// <param name="sqlText">The SQL text.</param>
        /// <param name="commandType">Type of the command.</param>
        public DataBuilder( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
            : base( fullPath, sqlText, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "DataBuilder" />
        /// class.
        /// </summary>
        /// <param name = "row" > The row. </param>
        public DataBuilder( DataRow row )
        {
            Record = row;
        }

        /// <summary>
        /// Filters the data.
        /// </summary>
        /// <param name="where">The dictionary.</param>
        /// <returns></returns>
        public IEnumerable<DataRow> FilterData( IDictionary<string, object> where )
        {
            if( where?.Any( ) == true
               && DataTable?.Rows?.Count > 0 )
            {
                try
                {
                    var _criteria = where.ToCriteria( );
                    var _data = DataTable.Select( _criteria );

                    return _data?.Length > 0
                        ? _data
                        : default( IEnumerable<DataRow> );
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
        /// Filters the dataRows.
        /// </summary>
        /// <param name="dataRows">The dataRows.</param>
        /// <param name="name">The field.</param>
        /// <param name="value">The filter.</param>
        /// <returns></returns>
        public static IEnumerable<DataRow> FilterData( IEnumerable<DataRow> dataRows, string name,
            string value )
        {
            if( dataRows?.Any( ) == true
               && !string.IsNullOrEmpty( name )
               && !string.IsNullOrEmpty( value ) )
            {
                try
                {
                    var _query = dataRows
                        ?.Where( p => p.Field<string>( name ).Equals( value ) )
                        ?.Select( p => p );

                    return _query?.Any( ) == true
                        ? _query.ToArray( )
                        : default;
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
        /// Gets the series.
        /// </summary>
        /// <param name="dataRows">The dataRows.</param>
        /// <param name="name">The field.</param>
        /// <param name="value">The filter.</param>
        /// <returns></returns>
        public static IDictionary<string, IEnumerable<string>> CreateSeries( IEnumerable<DataRow> dataRows, 
            string name, string value )
        {
            if( dataRows?.Any( ) == true
               && !string.IsNullOrEmpty( name )
               && !string.IsNullOrEmpty( value ) )
            {
                try
                {
                    var _dataTable = dataRows.CopyToDataTable( );
                    var _columns = _dataTable?.Columns;
                    var _dictionary = new Dictionary<string, IEnumerable<string>>( );
                    var _values = GetValues( dataRows, name, value );

                    if( _values?.Any( ) == true )
                    {
                        for( var i = 0; i < _columns?.Count; i++ )
                        {
                            var _columnName = _columns[ i ].ColumnName;
                            if( !string.IsNullOrEmpty( _columnName )
                               && _columns[ i ]?.DataType == typeof( string ) )
                            {
                                _dictionary.Add( _columns[ i ].ColumnName, _values );
                            }
                        }

                        return _dictionary?.Any( ) == true
                            ? _dictionary
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

            return default;
        }
    }
}