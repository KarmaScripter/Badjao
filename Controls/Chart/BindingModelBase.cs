// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ChartDataBindModel" />
    /// <seealso />
    public abstract class BindingModelBase : ChartDataBindModel
    {
        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public virtual IEnumerable<DataRow> Data { get; set; }

        /// <summary>
        /// Gets the binding model.
        /// </summary>
        /// <value>
        /// The binding model.
        /// </value>
        public virtual ChartDataBindModel ChartData { get; set; }

        /// <summary>
        /// Gets or sets the axis label model.
        /// </summary>
        /// <value>
        /// The axis label model.
        /// </value>
        public virtual ChartDataBindAxisLabelModel AxisLabelModel { get; set; }

        /// <summary>
        /// Gets or sets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        public virtual DataMetric DataMetric { get; set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public virtual STAT Stat { get; set; }

        /// <summary>
        /// Gets the series data.
        /// </summary>
        /// <value>
        /// The series data.
        /// </value>
        public virtual IDictionary<string, double> SeriesData { get; set; }

        /// <summary>
        /// Gets or sets the series values.
        /// </summary>
        /// <value>
        /// The series values.
        /// </value>
        public virtual IEnumerable<double> Values { get; set; }

        /// <summary>
        /// Gets or sets the series categories.
        /// </summary>
        /// <value>
        /// The series categories.
        /// </value>
        public virtual IEnumerable<string> Categories { get; set; }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="BindingModelBase" /> class.
        /// </summary>
        protected BindingModelBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BindingModelBase" /> struct.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        protected BindingModelBase( BindingSource bindingSource )
        {
            ChartData = new ChartDataBindModel( bindingSource );
            Data = ( (DataTable)bindingSource.DataSource ).AsEnumerable( );
            DataSource = Data.CopyToDataTable( );
            AxisLabelModel = new ChartDataBindAxisLabelModel( DataSource );
            DataMetric = new DataMetric( bindingSource );
            SeriesData = DataMetric.CalculateStatistics( );
            Categories = SeriesData.Keys;
            ChartData.Changed += OnChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BindingModelBase"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        protected BindingModelBase( DataTable dataTable )
        {
            ChartData = new ChartDataBindModel( dataTable );
            Data = dataTable.AsEnumerable( );
            DataSource = dataTable;
            AxisLabelModel = new ChartDataBindAxisLabelModel( DataSource );
            DataMetric = new DataMetric( dataTable );
            SeriesData = DataMetric.CalculateStatistics( );
            Categories = SeriesData.Keys;
            ChartData.Changed += OnChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BindingModelBase"/> class.
        /// </summary>
        /// <param name="dataSet">The data table.</param>
        protected BindingModelBase( DataSet dataSet )
        {
            ChartData = new ChartDataBindModel( dataSet );
            Data = dataSet.Tables[ 0 ].AsEnumerable( );
            DataSource = dataSet.Tables[ 0 ];
            AxisLabelModel = new ChartDataBindAxisLabelModel( DataSource );
            DataMetric = new DataMetric( Data );
            SeriesData = DataMetric.CalculateStatistics( );
            Categories = SeriesData.Keys;
            ChartData.Changed += OnChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BindingModelBase"/> class.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        protected BindingModelBase( IEnumerable<DataRow> dataRows )
        {
            ChartData = new ChartDataBindModel( dataRows );
            DataSource = dataRows.CopyToDataTable( );
            AxisLabelModel = new ChartDataBindAxisLabelModel( DataSource );
            DataMetric = new DataMetric( dataRows );
            SeriesData = DataMetric.CalculateStatistics( );
            Categories = SeriesData.Keys;
            ChartData.Changed += OnChanged;
        }

        /// <summary>
        /// Called when [changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public virtual void OnChanged( object sender, EventArgs e )
        {
            if( sender != null
               && e != null )
            {
                try
                {
                    var message = new Message( "NOT YET IMPLEMENTED" );
                    message?.ShowDialog( );
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
        protected void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}