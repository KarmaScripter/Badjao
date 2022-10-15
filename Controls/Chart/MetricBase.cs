// <copyright file = "MetricBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    public abstract class MetricBase
    {
        /// <summary>
        /// Gets the source.
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public string TableName { get; set; }

        /// <summary>
        /// The numeric
        /// </summary>
        public Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the data member.
        /// </summary>
        /// <value>
        /// The data member.
        /// </value>
        public string DataMember { get; set; }

        /// <summary>
        /// The dataRow
        /// </summary>
        public IEnumerable<DataRow> Data { get; set; }

        /// <summary>
        /// The count
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// The total
        /// </summary>
        public double Total { get; set; }

        /// <summary>
        /// The average
        /// </summary>
        public double Average { get; set; }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        /// <value>
        /// The categories.
        /// </value>
        public IEnumerable<string> Categories { get; set; }

        /// <summary>
        /// Gets or sets the amounts.
        /// </summary>
        /// <value>
        /// The amounts.
        /// </value>
        public IDictionary<string, double> Amounts { get; set; }

        /// <summary>
        /// The statistics
        /// </summary>
        public IDictionary<string, double> Statistics { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricBase"/> class.
        /// </summary>
        protected MetricBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricBase"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name="numeric">The numeric.</param>
        protected MetricBase( BindingSource bindingSource, Numeric numeric = Numeric.Amount )
        {
            Data = ( (DataTable)bindingSource.DataSource ).AsEnumerable( );
            TableName = ( (DataTable)bindingSource.DataSource ).TableName;
            Source = (Source)Enum.Parse( typeof( Source ), TableName );
            Numeric = numeric;
            Total = CalculateTotal( Data, numeric );
            Count = GetCount( Data, numeric );
            Average = CalculateAverage( Data, numeric );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricBase"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name="where">The dictionary.</param>
        /// <param name="numeric">The numeric.</param>
        protected MetricBase( BindingSource bindingSource, IDictionary<string, object> where,
            Numeric numeric = Numeric.Amount )
        {
            Data = ( (DataTable)bindingSource.DataSource ).Select( where.ToCriteria( ) );
            TableName = ( (DataTable)bindingSource.DataSource ).TableName;
            Source = (Source)Enum.Parse( typeof( Source ), TableName );
            Numeric = numeric;
            Total = CalculateTotal( Data, numeric );
            Count = GetCount( Data, numeric );
            Average = CalculateAverage( Data, numeric );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricBase"/> class.
        /// </summary>
        /// <param name="dataTable">The data row.</param>
        /// <param name="numeric">The numeric.</param>
        protected MetricBase( DataTable dataTable, Numeric numeric = Numeric.Amount )
        {
            Data = dataTable.AsEnumerable( );
            TableName = dataTable.TableName;
            Source = (Source)Enum.Parse( typeof( Source ), dataTable.TableName );
            Numeric = numeric;
            Count = Data.Count( );
            Total = CalculateTotal( Data, numeric );
            Average = CalculateAverage( Data, numeric );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricBase"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <param name="where">The dictionary.</param>
        /// <param name="numeric">The numeric.</param>
        protected MetricBase( DataTable dataTable, IDictionary<string, object> where,
            Numeric numeric = Numeric.Amount )
        {
            Data = dataTable.Select( where.ToCriteria( ) );
            TableName = dataTable.TableName;
            Source = (Source)Enum.Parse( typeof( Source ), dataTable.TableName );
            Numeric = numeric;
            Count = Data.Count( );
            Total = CalculateTotal( Data, numeric );
            Average = CalculateAverage( Data, numeric );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricBase"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="numeric">The numeric.</param>
        protected MetricBase( IEnumerable<DataRow> dataRow, Numeric numeric = Numeric.Amount )
        {
            Data = dataRow;
            TableName = dataRow.CopyToDataTable( ).TableName;
            Source = (Source)Enum.Parse( typeof( Source ), dataRow.CopyToDataTable( ).TableName );
            Numeric = numeric;
            Count = dataRow.Count( );
            Total = CalculateTotal( dataRow, numeric );
            Average = CalculateAverage( dataRow, numeric );
        }

        protected MetricBase( IEnumerable<DataRow> dataRow, IDictionary<string, object> where,
            Numeric numeric = Numeric.Amount )
        {
            Numeric = numeric;
            Data = dataRow.Filter( where );
            TableName = dataRow.CopyToDataTable( ).TableName;
            Source = (Source)Enum.Parse( typeof( Source ), dataRow.CopyToDataTable( ).TableName );
            Count = Data.Count( );
            Total = CalculateTotal( Data, Numeric );
            Average = CalculateAverage( Data, Numeric );
        }

        /// <summary>
        /// Gets the codes.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name = "dataMember" > </param>
        /// <returns></returns>
        public static IEnumerable<string> GetUniqueValues( IEnumerable<DataRow> dataRow,
            string dataMember )
        {
            if( dataRow?.Any( ) == true
                && !string.IsNullOrEmpty( dataMember ) )
            {
                try
                {
                    var _columns = dataRow.CopyToDataTable( ).GetColumnNames( );
                    if( _columns?.Contains( dataMember ) == true )
                    {
                        var _query = dataRow?.Select( p => p.Field<string>( dataMember ) )
                            ?.Distinct( )?.ToArray( );

                        return _query?.Any( ) == true
                            ? _query
                            : default( IEnumerable<string> );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<string> );
                }
            }

            return default( IEnumerable<string> );
        }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public int GetCount( IEnumerable<DataRow> dataRow, Numeric numeric = Numeric.Amount )
        {
            if( dataRow?.Any( ) == true )
            {
                try
                {
                    var _select = dataRow?.Where( p => p.Field<decimal>( $"{numeric}" ) != 0 )
                        ?.Select( p => p );

                    return _select?.Any( ) == true
                        ? _select.Count( )
                        : default( int );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0;
                }
            }

            return 0;
        }

        /// <summary>
        /// Calculates the totals.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public double CalculateTotal( IEnumerable<DataRow> dataRow,
            Numeric numeric = Numeric.Amount )
        {
            if( dataRow?.Any( ) == true )
            {
                try
                {
                    var _select = dataRow.Select( p => p.Field<decimal>( $"{numeric}" ) ).Sum( );
                    return _select > 0
                        ? double.Parse( _select.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default( double );
        }

        /// <summary>
        /// Calculates the average.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        protected double CalculateAverage( IEnumerable<DataRow> dataRow,
            Numeric numeric = Numeric.Amount )
        {
            if( dataRow?.Any( ) == true
                && Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                try
                {
                    var _query = dataRow.Where( p => p.Field<decimal>( $"{numeric}" ) != 0 )
                        ?.Select( p => p.Field<decimal>( $"{numeric}" ) )?.Average( );

                    return _query > 0
                        ? double.Parse( _query?.ToString( "N1" ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0.0d;
                }
            }

            return 0.0d;
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