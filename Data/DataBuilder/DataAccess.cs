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

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DataConfig" />
    /// <seealso cref="ISource" />
    /// <seealso cref="IProvider" />
    [ SuppressMessage( "ReSharper", "ImplicitlyCapturedClosure" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    public abstract class DataAccess : DataConfig, ISource, IProvider
    {
        /// <summary>
        /// Gets the Data.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DataRow> GetData( )
        {
            try
            {
                var _dataTable = GetDataTable( );
                var _data = _dataTable?.AsEnumerable( );

                return _data?.Any( ) == true
                    ? _data
                    : default( IEnumerable<DataRow> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<DataRow> );
            }
        }

        /// <summary>
        /// Gets the Data table.
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable( )
        {
            try
            {
                var _dataSet = new DataSet(  );
                var _dataTable = new DataTable( $"{Source}" );
                _dataSet.Tables.Add( _dataTable );
                var _adapter = Query?.GetAdapter( );
                _adapter?.Fill( _dataSet, _dataTable?.TableName );
                SetColumnCaptions( _dataTable );

                return _dataTable?.Rows?.Count > 0
                    ? _dataTable
                    : default( DataTable );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( DataTable );
            }
        }

        /// <summary>
        /// Gets the Data set.
        /// </summary>
        /// <returns></returns>
        public DataSet GetDataSet( )
        {
            if( Enum.IsDefined( typeof( Source ), Source ) )
            {
                try
                {
                    var _dataSet = new DataSet(  );
                    var _table = new DataTable( $"{Source}" );
                    _dataSet.Tables.Add( _table );

                    using( var _adapter = Query?.GetAdapter(  ) )
                    {
                        _adapter?.Fill( _dataSet, _table?.TableName );
                        SetColumnCaptions( _table );

                        return _table?.Rows?.Count > 0
                            ? _dataSet
                            : default( DataSet );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DataSet );
                }
            }

            return default( DataSet );
        }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <returns></returns>
        public Source GetSource( )
        {
            try
            {
                return Validate.IsSource( Source )
                    ? Source
                    : Source.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Source.NS;
            }
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        public Provider GetProvider( )
        {
            try
            {
                return Validate.IsProvider( Provider )
                    ? Provider
                    : Provider.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Provider.NS;
            }
        }

        /// <summary>
        /// Gets the record.
        /// </summary>
        /// <returns></returns>
        public DataRow GetRecord( )
        {
            try
            {
                return Verify.IsRow( Record )
                    ? Record
                    : default( DataRow );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( DataRow );
            }
        }

        /// <summary>
        /// Sets the column captions.
        /// </summary>
        /// <param name="dataTable">The Data table.</param>
        public void SetColumnCaptions( DataTable dataTable )
        {
            if( dataTable != null  )
            {
                try
                {
                    foreach( DataColumn column in dataTable.Columns )
                    {
                        switch( column?.ColumnName?.Length )
                        {
                            case 5:
                            {
                                var _caption = column.ColumnName.ToUpper( );
                                column.Caption = _caption;
                                continue;
                            }
                            default:
                            {
                                if ( column != null )
                                {
                                    column.Caption = column.ColumnName.SplitPascal(   );
                                }

                                break;
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
        /// Gets the column schema.
        /// </summary>
        /// <returns></returns>
        public DataColumnCollection GetColumnSchema( )
        {
            try
            {
                var _table = GetDataTable( );
                SetColumnCaptions( _table );

                var _dataSet = new DataSet
                {
                    DataSetName = $"{Source}"
                };

                var _dataTable = new DataTable( $"{ Source }" )
                {
                    TableName = $"{Source}"
                };

                _dataSet.Tables.Add( _dataTable );

                using( var _adapter = Query?.GetAdapter(  ) )
                {
                    _adapter?.Fill( _dataSet, _dataTable.TableName );
                    SetColumnCaptions( _dataTable );

                    return _table.Columns.Count > 0
                        ? _table.Columns
                        : default( DataColumnCollection );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( DataColumnCollection );
            }
        }

        /// <summary>
        /// Gets the primary indexes.
        /// </summary>
        /// <param name="dataRows">The Data rows.</param>
        /// <returns></returns>
        public IEnumerable<int> GetPrimaryIndexes( IEnumerable<DataRow> dataRows )
        {
            if( Verify.IsSequence( dataRows )
                && dataRows?.HasPrimaryKey( ) == true )
            {
                try
                {
                    var _table = dataRows?.CopyToDataTable( );
                    var _values = _table?.GetPrimaryKeyValues( );

                    return _values?.Any( ) == true
                        ? _values.ToArray( )
                        : default( IEnumerable<int> );
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
        /// Gets the column ordinals.
        /// </summary>
        /// <param name="dataColumns">The Data columns.</param>
        /// <returns></returns>
        public IEnumerable<int> GetColumnOrdinals( IEnumerable<DataColumn> dataColumns )
        {
            if( Verify.IsSequence( dataColumns ) )
            {
                try
                {
                    var _list = dataColumns.ToList( );
                    var _values = new List<int>( );

                    if( _list?.Any( ) == true )
                    {
                        foreach( var column in _list )
                        {
                            _values.Add( column.Ordinal );
                        }
                    }

                    return _values?.Any( ) == true
                        ? _values.ToArray( )
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
    }
}