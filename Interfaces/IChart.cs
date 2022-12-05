// // <copyright file = "IChart.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;

    public interface IChart
    {
        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        /// <value>
        /// The header.
        /// </value>
        ChartTitle Header { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        MetroTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        Field Field { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the stat.
        /// </summary>
        /// <value>
        /// The stat.
        /// </value>
        STAT Stat { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        Source Source { get; set; }

        /// <summary>
        /// Gets or sets the data values.
        /// </summary>
        /// <value>
        /// The data values.
        /// </value>
        IDictionary<string, double> DataValues { get; set; }

        /// <summary>
        /// Gets or sets the data source.
        /// </summary>
        /// <value>
        /// The data source.
        /// </value>
        object DataSource { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        string TableName { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        DataMetric DataMetric { get; set; }

        /// <summary>
        /// Gets the data series.
        /// </summary>
        /// <value>
        /// The data series.
        /// </value>
        ChartSeries DataSeries { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        IBindingModel BindingModel { get; set; }

        /// <summary>
        /// Sets the points.
        /// </summary>
        void SetPoints( );

        /// <summary>
        /// Sets the primary axis titleInfo.
        /// </summary>
        /// <param name="text">The titleInfo.</param>
        /// <param name="font"></param>
        /// <param name="color">The color.</param>
        void SetPrimaryAxisTitle( string text, Font font, Color color );
    }
}