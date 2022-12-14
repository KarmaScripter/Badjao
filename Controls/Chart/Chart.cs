// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class Chart : ChartControl, IChart
    {
        // Initializes Properties
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="Chart"/> class.
        /// </summary>
        public Chart( )
        {
            //Basic Control Properties
            Size = new Size( 600, 400 );
            ShowToolbar = true;
            ShowToolTips = true;
            ToolBar.Orientation = ChartOrientation.Horizontal;
            ToolBar.ButtonBackColor = Color.FromArgb( 15, 15, 15 );
            ToolBar.Position = ChartDock.Bottom;
            ToolBar.ShowGrip = false;
            ToolBar.ShowBorder = false;
            ShowScrollBars = false;
            EnableMouseRotation = true;
            Padding = new Padding( 1 );
            Margin = new Padding( 3 );
            Anchor = AnchorStyles.Top & AnchorStyles.Left;
            AllowGapForEmptyPoints = true;
            AllowGradientPalette = true;
            AllowUserEditStyles = true;
            PrintColorMode = ChartPrintColorMode.CheckPrinter;
            BackInterior = new BrushInfo( Color.FromArgb( 15, 15, 15 ) );
            BackColor = Color.FromArgb( 20, 20, 20 );

            ChartInterior = new BrushInfo( GradientStyle.PathRectangle, Color.LightSteelBlue,
                Color.FromArgb( 15, 15, 15 ) );

            CalcRegions = true;

            //ChartArea Properties
            ChartArea.AdjustPlotAreaMargins = ChartSetMode.AutoSet;
            ChartArea.AutoScale = true;
            ChartArea.BackInterior = new BrushInfo( Color.FromArgb( 15, 15, 15 ) );
            ChartArea.BorderWidth = 1;
            ChartArea.BorderColor = Color.Transparent;
            ChartArea.BorderStyle = BorderStyle.FixedSingle;
            ChartAreaMargins = new ChartMargins( 3, 3, 3, 3 );

            //ChartSeries Properties
            DropSeriesPoints = false;
            AddRandomSeries = true;
            Series3D = true;
            SeriesHighlight = true;
            SeriesHighlightIndex = -1;
            ShadowWidth = 5;

            ShadowColor = new BrushInfo( GradientStyle.PathRectangle, Color.FromArgb( 15, 15, 15 ),
                Color.Silver );

            Depth = 250;
            ElementsSpacing = 10;
            ColumnDrawMode = ChartColumnDrawMode.InDepthMode;
            ColumnFixedWidth = 20;

            //Chart Appearance Setting
            Palette = ChartColorPalette.Metro;
            Skins = Skins.None;
            RealMode3D = true;
            Rotation = 0.1f;
            Spacing = 5;
            AutoHighlight = true;
            SpacingBetweenPoints = 5;
            SpacingBetweenSeries = 10;
            Style3D = true;
            TextAlignment = StringAlignment.Center;
            TextPosition = ChartTextPosition.Top;
            Tilt = 5;
            ScrollPrecision = 100;
            RadarStyle = ChartRadarAxisStyle.Polygon;

            //Chart Legend Setting;
            ShowLegend = true;
            Legend.Font = new Font( "Roboto", 8 );
            Legend.ItemsSize = new Size( 10, 10 );
            Legend.VisibleCheckBox = true;
            Legend.BackInterior = new BrushInfo( Color.FromArgb( 15, 15, 15 ) );
            Legend.ItemsAlignment = StringAlignment.Center;
            Legend.ItemsTextAligment = VerticalAlignment.Center;
            Legend.Orientation = ChartOrientation.Vertical;
            Legend.FloatingAutoSize = true;
            Legend.ShowSymbol = true;
            Legend.ShowItemsShadow = true;
            Legend.ShowBorder = false;
            Legend.Visible = true;
            Header = new ChartTitle( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chart"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        public Chart( BindingSource bindingSource )
            : this( )
        {
            BindingModel = new BindingModel( bindingSource );
            BindingSource = bindingSource;
            DataSource = BindingModel.DataSource;
            DataSeries = new ChartSeries( bindingSource );
            DataMetric = BindingModel.DataMetric;
            DataValues = BindingModel.SeriesData;
            TableName = ( (DataTable)bindingSource.DataSource ).TableName;
            Header.Text = TableName;
            Text = Header.Text.SplitPascal( );
            Series.Add( DataSeries );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Chart"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name = "dict" > </param>
        public Chart( BindingSource bindingSource, IDictionary<string, object> dict )
            : this( )
        {
            BindingModel = new BindingModel( bindingSource );
            BindingSource = bindingSource;
            DataSource = BindingModel.DataSource;
            DataSeries = new ChartSeries( bindingSource );
            DataMetric = BindingModel.DataMetric;
            DataValues = BindingModel.SeriesData;
            TableName = BindingModel.TableName;
            Header.Text = TableName;
            Text = Header.Text.SplitPascal( );
            Series.Add( DataSeries );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Chart"/> 
        /// class.
        /// </summary>
        /// <param name="dataTable">
        /// The data table.
        /// </param>
        public Chart( DataTable dataTable )
            : this( )
        {
            BindingModel = new BindingModel( dataTable );
            BindingSource.DataSource = dataTable;
            DataSource = BindingModel.DataSource;
            DataSeries = new ChartSeries( dataTable );
            DataMetric = BindingModel.DataMetric;
            DataValues = BindingModel.SeriesData;
            TableName = dataTable?.TableName;
            Header.Text = TableName;
            Text = Header.Text.SplitPascal( );
            Series.Add( DataSeries );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Chart"/>
        /// class.
        /// </summary>
        /// <param name="dataTable">
        /// The data table.
        /// </param>
        /// <param name="dict">
        /// The dictionary.
        /// </param>
        public Chart( DataTable dataTable, IDictionary<string, object> dict )
            : this( )
        {
            BindingModel = new BindingModel( dataTable );
            BindingSource.DataSource = dataTable.Filter( dict );
            DataSource = BindingModel.DataSource;
            BindingModel = new BindingModel( dataTable );
            DataSeries = new ChartSeries( dataTable );
            DataMetric = BindingModel.DataMetric;
            DataValues = BindingModel.SeriesData;
            TableName = dataTable.TableName;
            Header.Text = TableName;
            Text = Header.Text.SplitPascal( );
            Series.Add( DataSeries );
        }

        /// <summary>
        /// Initializes a new instance of the 
        /// <see cref="Chart"/> class.
        /// </summary>
        /// <param name="dataRows">The data rows.
        /// </param>
        public Chart( IEnumerable<DataRow> dataRows )
            : this( )
        {
            BindingModel = new BindingModel( dataRows );
            BindingSource.DataSource = BindingModel.DataSource;
            DataSource = BindingModel.DataSource;
            DataSeries = new ChartSeries( dataRows );
            DataMetric = BindingModel.DataMetric;
            DataValues = BindingModel.SeriesData;
            TableName = BindingModel.TableName;
            Header.Text = TableName;
            Text = Header.Text.SplitPascal( );
            Series.Add( DataSeries );
        }

        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        /// <value>
        /// The header.
        /// </value>
        public ChartTitle Header { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public SmallTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        public Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the stat.
        /// </summary>
        /// <value>
        /// The stat.
        /// </value>
        public STAT Stat { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the data values.
        /// </summary>
        /// <value>
        /// The data values.
        /// </value>
        public IDictionary<string, double> DataValues { get; set; }

        /// <summary>
        /// Gets or sets the data source.
        /// </summary>
        /// <value>
        /// The data source.
        /// </value>
        public object DataSource { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        public DataMetric DataMetric { get; set; }

        /// <summary>
        /// Gets the data series.
        /// </summary>
        /// <value>
        /// The data series.
        /// </value>
        public ChartSeries DataSeries { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IBindingModel BindingModel { get; set; }

        /// <summary>
        /// Sets the points.
        /// </summary>
        public void SetPoints( )
        {
            if( Enum.IsDefined( typeof( ChartSeriesType ), DataSeries.Type )
               && DataValues?.Any( ) == true )
            {
                try
                {
                    if( Series[ 0 ].Points.Count > 0 )
                    {
                        Series[ 0 ].Points.Clear( );
                    }

                    switch( DataSeries.Type )
                    {
                        case ChartSeriesType.Pyramid:
                        case ChartSeriesType.Funnel:
                        case ChartSeriesType.Pie:

                        {
                            foreach( var kvp in DataValues )
                            {
                                DataSeries.Points.Add( kvp.Key, kvp.Value );

                                if( DataSeries.STAT != STAT.Percentage )
                                {
                                    DataSeries.Styles[ 0 ].TextFormat =
                                        $"{kvp.Key} \n {kvp.Value:N01}";
                                }
                                else if( DataSeries.STAT == STAT.Percentage )
                                {
                                    DataSeries.Styles[ 0 ].TextFormat =
                                        $"{kvp.Key} \n {kvp.Value:P}";
                                }
                            }

                            break;
                        }

                        default:

                        {
                            foreach( var kvp in DataValues )
                            {
                                DataSeries.Points.Add( kvp.Key, kvp.Value );
                            }

                            break;
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
        /// Sets the primary axis titleInfo.
        /// </summary>
        /// <param name="text">The titleInfo.</param>
        /// <param name="font"></param>
        /// <param name="color">The color.</param>
        public void SetPrimaryAxisTitle( string text, Font font, Color color )
        {
            try
            {
                PrimaryXAxis.Title = text;
                PrimaryXAxis.TitleColor = color;
                PrimaryXAxis.TitleFont = font;
            }
            catch( Exception ex )
            {
                Fail( ex );
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