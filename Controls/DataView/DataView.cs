// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;
    using System.Drawing;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Grid;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DataViewBase" />
    public class DataView : DataViewBase
    {
        /// <summary>Gets or sets the data table.</summary>
        /// <value>The data table.</value>
        public DataTable DataTable { get; set; }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="DataView"/> class.
        /// </summary>
        public DataView( )
        {
            // Control Properties
            ThemesEnabled = true;
            ApplyVisualStyles = true;
            TransparentBackground = false;
            EnableAddNew = true;
            EnableEdit = true;
            CanOverrideStyle = true;
            EnableRemove = true;
            AllowResizeToFit = true;
            ExcelLikeSelectionFrame = true;
            ExcelLikeAlignment = true;
            BackColor = Color.FromArgb( 78, 78, 79 );
            ForeColor = Color.Black;
            Font = new Font( "Roboto", 9, FontStyle.Regular );
            GridOfficeScrollBars = OfficeScrollBars.Office2010;
            Office2010ScrollBarsColorScheme = Office2010ColorScheme.Black;
            ColorStyles = ColorStyles.Office2016DarkGray;
            GridVisualStyles = GridVisualStyles.Metro;
            GridLineColor = Color.Black;
            HorizontalScrollTips = true;
            HorizontalThumbTrack = true;
            VerticalScrollTips = true;
            VerticalThumbTrack = true;
            DefaultGridBorderStyle = GridBorderStyle.Dotted;
            AlphaBlendSelectionColor = Color.SteelBlue;

            // ThemStyle Properties
            ThemeStyle.CellStyle.Font = new Font( "Roboto", 8, FontStyle.Regular );
            ThemeStyle.CellStyle.BackColor = Color.FromArgb( 78, 78, 79 );
            ThemeStyle.CellStyle.TextColor = Color.Black;
            ThemeStyle.CellStyle.BackColor = Color.FromArgb( 78, 78, 79 );
            ThemeStyle.CellStyle.TextColor = Color.LightSteelBlue;
            ThemeStyle.HeaderStyle.HoverTextColor = Color.White;
            ThemeStyle.HeaderStyle.HoverBackColor = Color.SteelBlue;

            // Model Properties
            Model.Rows.DefaultSize = 22;
            Model.ActiveGridView.PdfExport = true;
            Model.Properties.ThemedHeader = false;

            // Style Properties
            Properties.ThemedHeader = true;
            Properties.CenterHorizontal = true;
            Properties.CenterVertical = true;
            Properties.ColHeaders = true;
            Properties.RowHeaders = true;
            Properties.Buttons3D = true;

            // Table Style Properties
            TableStyle.Themed = true;
            TableStyle.WrapText = false;
            TableStyle.HorizontalAlignment = GridHorizontalAlignment.Center;
            TableStyle.AutoFit = AutoFitOptions.Both;
            TableStyle.Font.Facename = "Roboto";
            TableStyle.Font.Size = 8;
            TableStyle.Font.FontStyle = FontStyle.Regular;
            TableStyle.BackColor = Color.FromArgb( 78, 78, 79 );
            TableStyle.TextColor = Color.LightSteelBlue;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataView"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        public DataView( DataTable dataTable )
            : this( )
        {
            DataTable = dataTable;
        }
    }
}