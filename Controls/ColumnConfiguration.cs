//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref = "MetroForm"/>
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
    public partial class ColumnConfiguration : MetroForm
    {
        /// <summary>
        /// Sets Basic Properties Initializes a new instance of the
        /// <see cref = "ColumnConfiguration"/> class.
        /// </summary>
        public ColumnConfiguration( )
        {
            InitializeComponent( );
            Enabled = true;
            Visible = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ColumnConfiguration"/> class.
        /// </summary>
        /// <param name = "dataGrid" >
        /// The DGV.
        /// </param>
        public ColumnConfiguration( DataGridView dataGrid )
            : this( )
        {
            Grid = dataGrid;
            PopUp = new System.Windows.Forms.ToolStripDropDown( );
            ColumnListBox.CheckOnClick = true;
            ColumnListBox.ItemCheck += OnListItemChecked;
        }

        /// <summary>
        /// Gets the grid.
        /// </summary>
        /// <value>
        /// The grid.
        /// </value>
        public DataGridView Grid { get; }

        /// <summary>
        /// Gets or sets the column names.
        /// </summary>
        /// <value>
        /// The column names.
        /// </value>
        public IEnumerable<string> ColumnNames { get; set; }

        /// <summary>
        /// Gets the pop up.
        /// </summary>
        /// <value>
        /// The pop up.
        /// </value>
        public System.Windows.Forms.ToolStripDropDown PopUp { get; }

        /// <summary>
        /// Gets or sets the host.
        /// </summary>
        /// <value>
        /// The host.
        /// </value>
        public ToolStripControlHost Host { get; set; }

        /// <summary>
        /// Called when [datagrid right click].
        /// </summary>
        /// <param name = "sender" >
        /// The sender.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "DataGridViewCellMouseEventArgs"/> instance containing the
        /// event data.
        /// </param>
        public void OnDataGridRightClick( object sender, DataGridViewCellMouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right
               && Grid?.Columns != null )
            {
                try
                {
                    ColumnListBox?.Items?.Clear( );

                    foreach( DataGridViewColumn c in Grid?.Columns )
                    {
                        ColumnListBox?.Items.Add( c.HeaderText, c.Visible );
                    }

                    var _columnConfiguration = new ColumnConfiguration( Grid )
                    {
                        Location = Grid.PointToScreen( new Point( e.X, e.Y ) )
                    };

                    _columnConfiguration?.ShowDialog( );
                    _columnConfiguration.TopMost = true;
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
        protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }

        /// <summary>
        /// Gets the control host.
        /// </summary>
        /// <param name = "listBox" >
        /// The listbox.
        /// </param>
        /// <returns>
        /// </returns>
        private ToolStripControlHost GetControlHost( Control listBox )
        {
            if( listBox != null )
            {
                try
                {
                    var _controlHost = new ToolStripControlHost( this )
                    {
                        AutoSize = true,
                        Margin = Padding.Empty,
                        Padding = Padding.Empty
                    };

                    return _controlHost;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Called when [data grid item checked].
        /// </summary>
        /// <param name = "sender" >
        /// The sender.
        /// </param>
        /// <param name = "e" >
        /// The <see cref = "ItemCheckEventArgs"/> instance containing the event data.
        /// </param>
        private void OnListItemChecked( object sender, ItemCheckEventArgs e )
        {
            if( e != null )
            {
                try
                {
                    Grid.Columns[ e.Index ].Visible = e.NewValue == CheckState.Checked;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}