//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System;
    using System.Configuration;
    using System.Drawing;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    public class ToolFactory
    {
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="ToolFactory"/> class.
        /// </summary>
        public ToolFactory( )
        {
        }

        /// <summary>
        /// Gets or sets the image directory.
        /// </summary>
        /// <value>
        /// The image directory.
        /// </value>
        public static string ImageDirectory { get; } =
            ConfigurationManager.AppSettings[ "ToolStrip" ];

        public static ToolSeparator CreateSeparator( )
        {
            try
            {
                var _separator = new ToolSeparator( );
                return _separator;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the first record button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateFirstButton( )
        {
            try
            {
                var _filename = ImageDirectory + "FirstButton.png";

                var _firstButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ),
                    HoverText = "First Record",
                    ToolType = ToolType.FirstButton
                };

                return _firstButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the previous record button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreatePreviousButton( )
        {
            try
            {
                var _filename = ImageDirectory + "PreviousButton.png";

                var _previousButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ),
                    HoverText = "Previous Record",
                    ToolType = ToolType.PreviousButton
                };

                return _previousButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the next record button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateNextButton( )
        {
            try
            {
                var _filename = ImageDirectory + "NextButton.png";

                var _nextButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ),
                    HoverText = "Next Record",
                    ToolType = ToolType.NextButton
                };

                return _nextButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the last record button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateLastButton( )
        {
            try
            {
                var _filename = ImageDirectory + "LastButton.png";

                var _lastButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ),
                    HoverText = "Last Record",
                    ToolType = ToolType.LastButton
                };

                return _lastButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the edit record button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateEditButton( )
        {
            try
            {
                var _filename = ImageDirectory + "EditButton.png";

                var _editButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ),
                    HoverText = "Edit Record",
                    ToolType = ToolType.EditButton
                };

                return _editButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the add record button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateAddButton( )
        {
            try
            {
                var _filename = ImageDirectory + "AddButton.png";

                var _addButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ),
                    HoverText = "Add Record",
                    ToolType = ToolType.AddButton
                };

                return _addButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the delete record button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateDeleteButton( )
        {
            try
            {
                var _filename = ImageDirectory + "DeleteButton.png";

                var _deleteButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ),
                    HoverText = "Delete Record",
                    ToolType = ToolType.DeleteButton
                };

                return _deleteButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the refresh data button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateRefreshButton( )
        {
            try
            {
                var _filename = ImageDirectory + "RefreshButton.png";

                var _refreshButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ),
                    HoverText = "Refresh Data",
                    ToolType = ToolType.RefreshButton
                };

                return _refreshButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the save changes button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateSaveButton( )
        {
            try
            {
                var _filename = ImageDirectory + "SaveButton.png";

                var _saveButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ),
                    HoverText = "Save Changes",
                    ToolType = ToolType.SaveButton
                };

                return _saveButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the print data button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreatePrintButton( )
        {
            try
            {
                var _filename = ImageDirectory + "PrintButton.png";

                var _printButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ),
                    HoverText = "Print Data",
                    ToolType = ToolType.PrintButton
                };

                return _printButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the excel export button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateExcelButton( )
        {
            try
            {
                var _filename = ImageDirectory + "ExcelButton.png";

                var _excelButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ),
                    HoverText = "Export to Excel",
                    ToolType = ToolType.ExcelButton
                };

                return _excelButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the calculator button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateCalculatorButton( )
        {
            try
            {
                var _filename = ImageDirectory + "CalculatorButton.png";

                var _calculatorButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ),
                    HoverText = "Launch Calculator",
                    ToolType = ToolType.CalculatorButton
                };

                return _calculatorButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the print data button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateHomeButton( )
        {
            try
            {
                var _filename = ImageDirectory + "HomeButton.png";

                var _homeButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ),
                    HoverText = "Main Menu",
                    ToolType = ToolType.HomeButton
                };

                return _homeButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the label.
        /// </summary>
        /// <returns>
        /// </returns>
        public static ToolStripLabel CreateLabel( )
        {
            try
            {
                var _label = new ToolStripLabel( );
                return _label;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the ComboBox.
        /// </summary>
        /// <returns>
        /// </returns>
        public static ToolStripComboBoxEx CreateComboBox( )
        {
            try
            {
                var _comboBox = new ToolStripComboBoxEx( );
                return _comboBox;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the text box.
        /// </summary>
        /// <returns>
        /// </returns>
        public static ToolStripProgressBar CreateProgressBar( )
        {
            try
            {
                var _progress = new ToolStripProgressBar( );
                return _progress;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Creates the text box.
        /// </summary>
        /// <returns>
        /// </returns>
        public static ToolStripTextBox CreateTextBox( )
        {
            try
            {
                var _textBox = new ToolStripTextBox( );
                return _textBox;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}