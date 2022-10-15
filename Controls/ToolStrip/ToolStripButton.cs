// <copyright file = "ToolStripButton.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;
    using System.Drawing;
    using System.IO;

    [Serializable ]
    public class ToolStripButton : ToolButtonBase, IToolStripButton
    {
        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="ToolStripButton"/> class.
        /// </summary>
        public ToolStripButton( )
        {
            Margin = new Padding( 5, 5, 5, 5 );
            Padding = new Padding( 0 );
            DisplayStyle = ToolStripItemDisplayStyle.Image;
            BackColor = Color.FromArgb( 15, 15, 15 );
            ForeColor = Color.LightSteelBlue;
            Font = new Font( "Roboto", 9 );
            AutoToolTip = false;
            MouseHover += OnMouseHover;
            MouseLeave += OnMouseLeave;
            Click += OnClick;
            Text = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance
        /// Mof the <see cref="ToolStripButton"/> class.
        /// </summary>
        /// <param name="toolType">The tool.</param>
        public ToolStripButton( ToolType toolType )
            : this( )
        {
            ToolType = toolType;
            Name = toolType.ToString( );
            HoverText = GetHoverText( toolType );
            Tag = HoverText;
            Image = GetImage( toolType );
            Click += OnClick;
        }

        /// <summary>
        /// Called when [mouse over].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the
        ///     event data.</param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            try
            {
                var _button = sender as ToolStripButton;
                if( _button != null
                    && !string.IsNullOrEmpty( HoverText ) )
                {
                    _button.Tag = HoverText;
                    var tip = new MetroTip( _button );
                    ToolTip = tip;
                }
                else
                {
                    if( !string.IsNullOrEmpty( Tag?.ToString( ) ) )
                    {
                        var _tool = new MetroTip( _button );
                        ToolTip = _tool;
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [mouse leave].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the
        ///     event data.</param>
        public void OnMouseLeave( object sender, EventArgs e )
        {
            try
            {
                if( ToolTip?.Active == true )
                {
                    ToolTip.RemoveAll( );
                    ToolTip = null;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the
        ///     event data.</param>
        public virtual void OnClick( object sender, EventArgs e )
        {
            if( sender is ToolStripButton _button )
            {
                try
                {
                    switch( _button?.ToolType )
                    {
                        case ToolType.FirstButton:
                        {
                            BindingSource?.MoveFirst( );
                            break;
                        }
                        case ToolType.PreviousButton:
                        {
                            BindingSource?.MovePrevious( );
                            break;
                        }
                        case ToolType.NextButton:
                        {
                            BindingSource?.MoveNext( );
                            break;
                        }
                        case ToolType.LastButton:
                        {
                            BindingSource?.MoveLast( );
                            break;
                        }
                        case ToolType.ExcelButton:
                        {
                            using var _excelForm = new ExcelForm( );
                            _excelForm?.ShowDialog( );
                            break;
                        }
                        case ToolType.PdfButton:
                        {
                            using var _message = new PdfForm( );
                            _message?.ShowDialog( );
                            break;
                        }
                        case ToolType.PrintButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog( );
                            break;
                        }
                        case ToolType.AddRecordButton:
                        {
                            using var _dataConfig = new EditDialog( _button.ToolType );
                            _dataConfig.BindingSource = BindingSource;
                            _dataConfig?.ShowDialog( );
                            break;
                        }
                        case ToolType.AddButton:
                        {
                            using var _dataConfig = new EditDialog( _button.ToolType );
                            _dataConfig.BindingSource = BindingSource;
                            _dataConfig?.ShowDialog( );
                            break;
                        }
                        case ToolType.AddTableButton:
                        case ToolType.AddDatabaseButton:
                        case ToolType.AddColumnButton:
                        {
                            using var _dataConfig =
                                new DefinitionDialog( _button.ToolType, BindingSource );

                            _dataConfig.BindingSource = BindingSource;
                            _dataConfig?.ShowDialog( );
                            break;
                        }
                        case ToolType.EditColumnButton:
                        {
                            using var _dataConfig =
                                new DefinitionDialog( _button.ToolType, BindingSource );

                            _dataConfig.BindingSource = BindingSource;
                            _dataConfig?.ShowDialog( );
                            break;
                        }
                        case ToolType.DeleteColumnButton:
                        {
                            using var _dataConfig =
                                new DefinitionDialog( _button.ToolType, BindingSource );

                            _dataConfig.BindingSource = BindingSource;
                            _dataConfig?.ShowDialog( );
                            break;
                        }
                        case ToolType.DeleteTableButton:
                        {
                            using var _dataConfig =
                                new DefinitionDialog( _button.ToolType, BindingSource );

                            _dataConfig.BindingSource = BindingSource;
                            _dataConfig?.ShowDialog( );
                            break;
                        }
                        case ToolType.DeleteDatabaseButton:
                        {
                            using var _dataConfig =
                                new DefinitionDialog( _button.ToolType, BindingSource );

                            _dataConfig.BindingSource = BindingSource;
                            _dataConfig?.ShowDialog( );
                            break;
                        }
                        case ToolType.DeleteRecordButton:
                        {
                            using var _dataConfig =
                                new EditDialog( _button.ToolType, BindingSource );

                            _dataConfig?.ShowDialog( );
                            break;
                        }
                        case ToolType.DeleteButton:
                        {
                            using var _dataConfig =
                                new EditDialog( _button.ToolType, BindingSource );

                            _dataConfig?.ShowDialog( );
                            break;
                        }
                        case ToolType.RefreshButton:
                        {
                            using var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog( );
                            break;
                        }
                        case ToolType.ExitButton:
                        {
                            var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog( );
                            break;
                        }
                        case ToolType.ExportButton:
                        {
                            var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog( );
                            break;
                        }
                        case ToolType.ImportButton:
                        {
                            var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog( );
                            break;
                        }
                        case ToolType.FilterDataButton:
                        {
                            using var _dataConfig = new LookupDialog( );
                            _dataConfig.BindingSource = BindingSource;
                            _dataConfig?.ShowDialog( );
                            break;
                        }
                        case ToolType.EditSqlButton:
                        {
                            using var _dataConfig =
                                new EditDialog( _button.ToolType, BindingSource );

                            _dataConfig.Current = BindingSource.GetCurrentDataRow( );
                            _dataConfig.ShowDialog( );
                            break;
                        }
                        case ToolType.EditButton:
                        {
                            using var _dataConfig =
                                new EditDialog( _button.ToolType, BindingSource );

                            _dataConfig.Current = BindingSource.GetCurrentDataRow( );
                            _dataConfig.ShowDialog( );
                            break;
                        }
                        case ToolType.EditRecordButton:
                        {
                            using var _dataConfig =
                                new EditDialog( _button.ToolType, BindingSource );

                            _dataConfig.Current = BindingSource.GetCurrentDataRow( );
                            _dataConfig?.ShowDialog( );
                            break;
                        }
                        case ToolType.CopyButton:
                        {
                            using var _dataConfig =
                                new EditDialog( _button.ToolType, BindingSource );

                            _dataConfig.Current = BindingSource.GetCurrentDataRow( );
                            _dataConfig?.ShowDialog( );
                            break;
                        }
                        case ToolType.UpdateButton:
                        {
                            using var _dataConfig =
                                new EditDialog( _button.ToolType, BindingSource );

                            _dataConfig.Current = BindingSource.GetCurrentDataRow( );
                            _dataConfig?.ShowDialog( );
                            break;
                        }
                        case ToolType.InsertButton:
                        {
                            using var _dataConfig =
                                new EditDialog( _button.ToolType, BindingSource );

                            _dataConfig.Current = BindingSource.GetCurrentDataRow( );
                            _dataConfig?.ShowDialog( );
                            break;
                        }
                        case ToolType.CalculatorButton:
                        {
                            using var _calculator = new CalculationForm( );
                            _calculator?.ShowDialog( );
                            break;
                        }
                        case ToolType.CalendarButton:
                        {
                            using var _form = new CalendarForm( );
                            _form?.ShowDialog( );
                            break;
                        }
                        case ToolType.BrowseButton:
                        {
                            using var _browser = new FileBrowser( );
                            _browser?.ShowDialog( );
                            break;
                        }
                        case ToolType.HomeButton:
                        {
                            using var _form = new MainForm( );
                            _form?.ShowDialog( );
                            break;
                        }
                        case ToolType.ChartButton:
                        {
                            if( BindingSource?.DataSource != null )
                            {
                                using var _chartForm = new ChartForm( );
                                _chartForm.BindingSource = BindingSource;
                                _chartForm?.ShowDialog( );
                            }
                            else if( BindingSource == null )
                            {
                                using var _form = new ChartForm( );
                                _form?.ShowDialog( );
                            }

                            break;
                        }
                        default:
                        {
                            var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog( );
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
        /// Sets the image.
        /// </summary>
        public void SetImage( )
        {
            if( Enum.IsDefined( typeof( ToolType ), ToolType ) )
            {
                try
                {
                    var _path = ConfigurationManager.AppSettings[ "ToolStrip" ] + $"{ToolType}.png";
                    using var _stream = File.Open( _path, FileMode.Open );
                    if( _stream != null )
                    {
                        var _image = Image.FromStream( _stream );
                        Image = _image;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the button image.
        /// </summary>
        /// <returns></returns>
        public Image GetImage( ToolType toolType )
        {
            if( Enum.IsDefined( typeof( ToolType ), toolType ) )
            {
                try
                {
                    var _path = ConfigurationManager.AppSettings[ "ToolStrip" ] + $"{toolType}.png";
                    using var _stream = File.Open( _path, FileMode.Open );
                    if( _stream != null )
                    {
                        var _image = Image.FromStream( _stream );
                        return _image != null
                            ? _image
                            : default( Image );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( Image );
                }
            }

            return default( Image );
        }
    }
}