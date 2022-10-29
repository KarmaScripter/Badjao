// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;

    public partial class LookupDialog : EditBase
    {
        /// <summary>
        /// Gets the table prefix.
        /// </summary>
        /// <value>
        /// The table prefix.
        /// </value>
        public string TablePrefix { get; } = " Tables : ";

        /// <summary>
        /// Gets the column prefix.
        /// </summary>
        /// <value>
        /// The column prefix.
        /// </value>
        public string ColumnPrefix { get; } = " Columns : ";

        /// <summary>
        /// Gets the value prefix.
        /// </summary>
        /// <value>
        /// The value prefix.
        /// </value>
        public string ValuePrefix { get; } = " Values : ";

        /// <summary>
        /// Initializes a new instance of the <see cref="LookupDialog"/> class.
        /// </summary>
        public LookupDialog( )
        {
            InitializeComponent( );
            GroupBoxes = GetGroupBoxes( );
            RadioButtons = GetRadioButtons( );
            TabControl.TabPanelBackColor = Color.FromArgb( 15, 15, 15 );
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClicked;
            TableListBox.SelectedValueChanged += OnTableListBoxSelectionChanged;
            ColumnListBox.SelectedValueChanged += OnColumnListBoxSelectionChanged;
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                FormFilter = new Dictionary<string, object>
                {
                    { "BFY", "2022" },
                    { "FundCode", "B" }
                };

                DataModel = new DataBuilder( Source.StatusOfFunds, Provider.Access, FormFilter );
                BindingSource.DataSource = DataModel.DataTable;
                SetGroupBoxProperties( );
                SetRadioButtonProperties( );
                PopulateTableListBoxItems( );
                TableGroupBox.Text = TablePrefix + TableListBox.Items.Count;
                ColumnGroupBox.Text = ColumnPrefix;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the table ListBox items.
        /// </summary>
        public void PopulateTableListBoxItems( )
        {
            try
            {
                TableListBox.Items.Clear( );
                var _names = Enum.GetNames( typeof( Source ) );

                foreach( var name in _names )
                {
                    if( name != "NS" )
                    {
                        TableListBox.Items.Add( name );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [table ListBox selection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnTableListBoxSelectionChanged( object sender, EventArgs e )
        {
            try
            {
                FormFilter.Clear( );
                ColumnListBox.Items.Clear( );
                ValueListBox.Items.Clear( );
                ColumnGroupBox.Text = string.Empty;
                ValueGroupBox.Text = string.Empty;
                var _listBox = sender as ListBox;
                var _value = _listBox?.SelectedItem.ToString( );

                if( !string.IsNullOrEmpty( _value ) )
                {
                    var _source = (Source)Enum.Parse( typeof( Source ), _value );
                    DataModel = new DataBuilder( _source, Provider.Access );
                    BindingSource.DataSource = DataModel.DataTable;
                    var _columns = DataModel.GetDataColumns( );

                    foreach( var col in _columns )
                    {
                        ColumnListBox.Items.Add( col.ColumnName );
                    }

                    ColumnGroupBox.Text = ColumnPrefix + ColumnListBox.Items.Count;
                    ValueGroupBox.Text = ValuePrefix;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [column ListBox selection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnColumnListBoxSelectionChanged( object sender, EventArgs e )
        {
            try
            {
                ValueListBox.Items.Clear( );
                var _listBox = sender as ListBox;
                var _column = _listBox?.SelectedItem?.ToString( );
                var _series = DataModel.DataElements;

                if( !string.IsNullOrEmpty( _column ) )
                {
                    foreach( var item in _series[ _column ] )
                    {
                        ValueListBox.Items.Add( item );
                    }
                }

                ValueGroupBox.Text = ValuePrefix + ValueListBox.Items.Count;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}