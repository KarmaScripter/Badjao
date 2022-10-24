// <copyright file = "DataMetric.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using LinqStatistics;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref = "MetricBase"/>
    [ SuppressMessage( "ReSharper", "WrongIndentSize" ) ]
    public class DataMetric : MetricBase
    {
        /// <summary>
        /// Gets the variance.
        /// </summary>
        /// <value>
        /// The variance.
        /// </value>
        public double Variance { get; set; }

        /// <summary>
        /// Gets the deviation.
        /// </summary>
        /// <value>
        /// The deviation.
        /// </value>
        public double Deviation { get; set; }

        /// <summary>
        /// Gets or sets the values.
        /// </summary>
        /// <value>
        /// The values.
        /// </value>
        public IDictionary<string, double> Values { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref = "DataMetric"/> class.
        /// </summary>
        public DataMetric( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataMetric"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name="numeric">The numeric.</param>
        public DataMetric( BindingSource bindingSource, Numeric numeric = Numeric.Amount )
            : base( bindingSource, numeric )
        {
            Variance = CalculateVariance( Data, Numeric );
            Deviation = CalculateDeviation( Data, Numeric );
            Statistics = CalculateStatistics( );
        }

        public DataMetric( BindingSource bindingSource, IDictionary<string, object> where,
            Numeric numeric = Numeric.Amount )
            : base( bindingSource, where, numeric )
        {
            Variance = CalculateVariance( Data, Numeric );
            Deviation = CalculateDeviation( Data, Numeric );
            Statistics = CalculateStatistics( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataMetric"/> class.
        /// </summary>
        /// <param name="dataTable">The data row.</param>
        /// <param name="numeric">The numeric.</param>
        public DataMetric( DataTable dataTable, Numeric numeric = Numeric.Amount )
            : base( dataTable, numeric )
        {
            Variance = CalculateVariance( Data, Numeric );
            Deviation = CalculateDeviation( Data, Numeric );
            Statistics = CalculateStatistics( );
        }

        public DataMetric( DataTable dataTable, IDictionary<string, object> where,
            Numeric numeric = Numeric.Amount )
            : base( dataTable, where, numeric )
        {
            Variance = CalculateVariance( Data, Numeric );
            Deviation = CalculateDeviation( Data, Numeric );
            Statistics = CalculateStatistics( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "DataMetric"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        public DataMetric( IEnumerable<DataRow> dataRow, Numeric numeric = Numeric.Amount )
            : base( dataRow, numeric )
        {
            Variance = CalculateVariance( Data, Numeric );
            Deviation = CalculateDeviation( Data, Numeric );
            Statistics = CalculateStatistics( );
        }

        public DataMetric( IEnumerable<DataRow> dataRow, IDictionary<string, object> where,
            Numeric numeric = Numeric.Amount )
            : base( dataRow, where, numeric )
        {
            Variance = CalculateVariance( Data, Numeric );
            Deviation = CalculateDeviation( Data, Numeric );
            Statistics = CalculateStatistics( );
        }

        /// <summary>
        /// Calculates the deviation.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        public double CalculateDeviation( IEnumerable<DataRow> dataRow, Numeric numeric )
        {
            if( dataRow?.Any( ) == true
                && dataRow.HasNumeric( )
                && GetCount( dataRow, numeric ) > 30 )
            {
                try
                {
                    var _query = dataRow
                        ?.Where( p => p.Field<decimal>( $"{ numeric }" ) != 0 )
                        ?.StandardDeviation( p => p.Field<decimal>( $"{ numeric }" ) );

                    return _query > 0
                        ? double.Parse( _query.ToString( ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0.0d;
                }
            }

            return default( double );
        }

        /// <summary>
        /// Calculates the variance.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        public double CalculateVariance( IEnumerable<DataRow> dataRow, Numeric numeric )
        {
            if( dataRow?.Any( ) == true
                && dataRow.HasNumeric( )
                && GetCount( dataRow, numeric ) > 30 )
            {
                var _table = dataRow.CopyToDataTable( );
                try
                {
                    var _query = _table?.AsEnumerable( )
                        ?.Where( p => p.Field<decimal>( $"{ numeric }" ) != 0 )
                        ?.Variance( p => p.Field<decimal>( $"{ numeric }" ) );

                    return _query > 0
                        ? double.Parse( _query.ToString( ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0.0d;
                }
            }

            return default( double );
        }

        /// <summary>
        /// Calculates the statistics.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, double> CalculateStatistics( )
        {
            try
            {
                var _stats = new Dictionary<string, double>
                {
                    { "COUNT", Count },
                    { "TOTAL", Total },
                    { "AVERAGE", Average }
                };

                return _stats?.Any( ) == true
                    ? _stats
                    : default( IDictionary<string, double> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, double> );
            }
        }
    }
}