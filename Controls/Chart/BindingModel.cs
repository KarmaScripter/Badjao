// <copyright file = "BindingModel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="IBindingModel" />
    public class BindingModel : BindingModelBase, IBindingModel
    {
        /// <summary>
        /// Gets or sets the chart handler.
        /// </summary>
        /// <value>
        /// The chart handler.
        /// </value>
        public ListChangedEventHandler ChartHandler { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the data set.
        /// </summary>
        /// <value>
        /// The data set.
        /// </value>
        public DataSet DataSet { get; set; }

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the binding list.
        /// </summary>
        /// <value>
        /// The binding list.
        /// </value>
        public BindingList<DataRow> BindingList { get; set; }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BindingModel" />
        /// class.
        /// </summary>
        public BindingModel( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BindingModel" />
        /// class.
        /// </summary>
        public BindingModel( BindingSource bindingSource )
        {
            Source = (Source)Enum.Parse( typeof( Source ),
                ( (DataTable)bindingSource.DataSource ).TableName );

            BindingSource = bindingSource;
            DataSource = (DataTable)bindingSource.DataSource;
            DataTable = (DataTable)bindingSource.DataSource;
            DataSet = ( (DataTable)bindingSource.DataSource ).DataSet;
            Data = ( (DataTable)bindingSource.DataSource ).AsEnumerable( );
            AxisLabelModel = new ChartDataBindAxisLabelModel( DataSource );
            BindingList = Data.ToBindingList( );
            BindingSource.DataSource = BindingList;
            TableName = Source.ToString( );
            DataMember = TableName;
            Record = bindingSource.GetCurrentDataRow( );
            DataSource = bindingSource;
            DataMetric = new DataMetric( bindingSource );
            SeriesData = DataMetric.CalculateStatistics( );
            Categories = SeriesData.Keys;
            YNames = Categories.ToArray( );
            Values = GetSeriesValues( );
            ChartData.Changed += OnChanged;
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BindingModel"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        public BindingModel( DataTable dataTable )
        {
            BindingSource = new BindingSource
            {
                DataSource = dataTable
            };

            Data = dataTable.AsEnumerable( );
            BindingList = Data.ToBindingList( );
            Source = (Source)Enum.Parse( typeof( Source ), dataTable.TableName );
            DataTable = dataTable;
            TableName = dataTable.TableName;
            DataSource = dataTable;
            DataSet = dataTable.DataSet;
            Record = BindingSource.GetCurrentDataRow( );
            DataMetric = new DataMetric( DataTable );
            SeriesData = DataMetric.CalculateStatistics( );
            Categories = SeriesData.Keys;
            Values = GetSeriesValues( );
            ChartData.Changed += OnChanged;
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BindingModel" />
        /// class.
        /// </summary>
        /// <param name = "dataSet" >
        /// </param>
        /// <param name = "tableName" > 
        /// </param>
        public BindingModel( DataSet dataSet, string tableName )
        {
            TableName = tableName;
            BindingSource = new BindingSource
            {
                DataSource = dataSet,
                DataMember = tableName
            };

            DataTable = dataSet.Tables[ tableName ];
            DataSource = BindingSource.DataSource;
            DataMember = tableName;
            DataSet = dataSet;
            Data = dataSet.Tables[ tableName ].AsEnumerable( );
            Record = BindingSource.GetCurrentDataRow( );
            DataMetric = new DataMetric( DataTable );
            SeriesData = DataMetric.CalculateStatistics( );
            Categories = SeriesData.Keys;
            Values = GetSeriesValues( );
            ChartData.Changed += OnChanged;
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BindingModel"/> class.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        public BindingModel( IEnumerable<DataRow> dataRows )
        {
            BindingSource = new BindingSource
            {
                DataSource = dataRows.CopyToDataTable( )
            };

            Data = dataRows;
            BindingList = dataRows.ToBindingList( );
            Source = (Source)Enum.Parse( typeof( Source ), DataTable?.TableName );
            DataTable = dataRows.CopyToDataTable( );
            TableName = Source.ToString( );
            DataSource = DataTable.ToBindingList( );
            DataSet = DataTable.DataSet;
            Record = BindingSource.GetCurrentDataRow( );
            DataMetric = new DataMetric( dataRows );
            SeriesData = DataMetric.CalculateStatistics( );
            Categories = SeriesData.Keys;
            Values = GetSeriesValues( );
            ChartData.Changed += OnChanged;
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Called when [current changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="ListChangedEventArgs" />
        /// instance containing the event data.</param>
        public void OnCurrentChanged( object sender, ListChangedEventArgs e )
        {
            if( sender != null
                && e != null )
            {
                try
                {
                    var _message = new Message( "NOT YET IMPLEMENTED" );
                    _message?.ShowDialog( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<double> GetSeriesValues( )
        {
            try
            {
                var _values = SeriesData?.Values?.Select( v => v );
                return _values?.Any( ) == true
                    ? _values.ToArray( )
                    : default( double[ ] );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<double> );
            }
        }

        /// <summary>
        /// Gets the source model.
        /// </summary>
        /// <returns></returns>
        public BindingModel GetSeriesModel( )
        {
            try
            {
                return (BindingModel)MemberwiseClone( );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BindingModel );
            }
        }
    }
}