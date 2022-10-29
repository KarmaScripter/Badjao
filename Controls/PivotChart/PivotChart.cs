// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using Syncfusion.Windows.Forms.Chart;
    using Syncfusion.Windows.Forms.PivotChart;

    public class PivotChart : PivotChartBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PivotChart"/> class.
        /// </summary>
        public PivotChart( )
        {
            // Basic Control Properties
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.White;
            BackColor = Color.FromArgb( 15, 15, 15 );
            Skins = Skins.Office2016Black;
            ShowLegend = true;
            Size = new Size( 400, 300 );

            CustomPalette = new[ ]
            {
                Color.SteelBlue,
                Color.Red,
                Color.Green
            };

            ChartTypes = PivotChartTypes.Column;
        }
    }
}