// <copyright file = "IBindingModel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;

    public interface IBindingModel
    {
        /// <summary>
        /// Gets or sets the chart handler.
        /// </summary>
        /// <value>
        /// The chart handler.
        /// </value>
        ListChangedEventHandler ChartHandler { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        Source Source { get; set; }

        /// <summary>
        /// Gets or sets the data set.
        /// </summary>
        /// <value>
        /// The data set.
        /// </value>
        DataSet DataSet { get; set; }

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        string TableName { get; set; }

        /// <summary>
        /// Gets or sets the binding list.
        /// </summary>
        /// <value>
        /// The binding list.
        /// </value>
        BindingList<DataRow> BindingList { get; set; }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        BindingSource BindingSource { get; set; }

        object DataSource { get; set; }

        string DataMember { get; set; }

        int Count { get; }

        int XIndex { get; set; }

        string XName { get; set; }

        int[ ] YIndexes { get; set; }

        string[ ] YNames { get; set; }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        IEnumerable<DataRow> Data { get; set; }

        /// <summary>
        /// Gets the binding model.
        /// </summary>
        /// <value>
        /// The binding model.
        /// </value>
        ChartDataBindModel ChartData { get; set; }

        /// <summary>
        /// Gets or sets the axis label model.
        /// </summary>
        /// <value>
        /// The axis label model.
        /// </value>
        ChartDataBindAxisLabelModel AxisLabelModel { get; set; }

        /// <summary>
        /// Gets or sets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        DataMetric DataMetric { get; set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        STAT Stat { get; set; }

        /// <summary>
        /// Gets the series data.
        /// </summary>
        /// <value>
        /// The series data.
        /// </value>
        IDictionary<string, double> SeriesData { get; set; }

        /// <summary>
        /// Gets or sets the series values.
        /// </summary>
        /// <value>
        /// The series values.
        /// </value>
        IEnumerable<double> Values { get; set; }

        /// <summary>
        /// Gets or sets the series categories.
        /// </summary>
        /// <value>
        /// The series categories.
        /// </value>
        IEnumerable<string> Categories { get; set; }

        /// <summary>
        /// Called when [current changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="ListChangedEventArgs" />
        /// instance containing the event data.</param>
        void OnCurrentChanged( object sender, ListChangedEventArgs e );

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        IEnumerable<double> GetSeriesValues( );

        /// <summary>
        /// Gets the source model.
        /// </summary>
        /// <param name="">
        /// 
        /// </param>
        /// <returns>
        /// 
        /// </returns>
        BindingModel GetSeriesModel( );
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns>
        /// 
        /// </returns>
        event ListChangedEventHandler Changed;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">
        /// 
        /// </param>
        /// <returns>
        /// 
        /// </returns>
        double GetX( int index );

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">
        /// 
        /// </param>
        /// <returns>
        /// double[ ]
        /// </returns>
        double[ ] GetY( int index );

        /// <summary>
        ///  
        /// </summary>
        /// <param name="">
        /// 
        /// </param>
        /// <returns>
        /// 
        /// </returns>
        bool GetEmpty( int index );

        /// <summary>
        /// Called when [changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" />
        /// instance containing the event data.</param>
        void OnChanged( object sender, EventArgs e );
    }
}