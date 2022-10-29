//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public partial class EditBase : MetroForm
    {
        /// <summary>
        /// Initializes a new instance 
        /// of the <see cref="EditBase"/> class.
        /// </summary>
        public EditBase( )
        {
            InitializeComponent( );
            Text = string.Empty;
        }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public virtual Source Source { get; set; }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public virtual Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the type of the command.
        /// </summary>
        /// <value>
        /// The type of the command.
        /// </value>
        public virtual SQL CommandType { get; set; }

        /// <summary>
        /// Gets or sets the type of the tool.
        /// </summary>
        /// <value>
        /// The type of the tool.
        /// </value>
        public virtual ToolType ToolType { get; set; }

        /// <summary>
        /// Gets or sets the current tab.
        /// </summary>
        /// <value>
        /// The current tab.
        /// </value>
        public virtual TabPageAdv ActiveTab { get; set; }

        /// <summary>
        /// Gets or sets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public virtual DataBuilder DataModel { get; set; }

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public virtual DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the columns.
        /// </summary>
        /// <value>
        /// The columns.
        /// </value>
        public virtual IEnumerable<string> Columns { get; set; }

        /// <summary>
        /// Gets or sets the selected column.
        /// </summary>
        /// <value>
        /// The selected column.
        /// </value>
        public virtual string SelectedColumn { get; set; }

        /// <summary>
        /// Gets or sets the selected table.
        /// </summary>
        /// <value>
        /// The selected table.
        /// </value>
        public virtual string SelectedTable { get; set; }

        /// <summary>
        /// Gets or sets the form filter.
        /// </summary>
        /// <value>
        /// The form filter.
        /// </value>
        public virtual IDictionary<string, object> FormFilter { get; set; }

        /// <summary>
        /// Gets or sets the group boxes.
        /// </summary>
        /// <value>
        /// The group boxes.
        /// </value>
        public virtual IDictionary<string, GroupBox> GroupBoxes { get; set; }

        /// <summary>
        /// Gets or sets the list boxes.
        /// </summary>
        /// <value>
        /// The list boxes.
        /// </value>
        public virtual IDictionary<string, ListBox> ListBoxes { get; set; }

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        /// <value>
        /// The labels.
        /// </value>
        public virtual IEnumerable<Label> Labels { get; set; }

        /// <summary>
        /// Gets or sets the tab pages.
        /// </summary>
        /// <value>
        /// The tab pages.
        /// </value>
        public virtual IDictionary<string, TabPageAdv> TabPages { get; set; }

        /// <summary>
        /// Gets or sets the radio buttons.
        /// </summary>
        /// <value>
        /// The radio buttons.
        /// </value>
        public virtual IDictionary<string, RadioButton> RadioButtons { get; set; }

        /// <summary>
        /// Gets or sets the combo boxes.
        /// </summary>
        /// <value>
        /// The combo boxes.
        /// </value>
        public virtual IDictionary<string, ComboBox> ComboBoxes { get; set; }

        /// <summary>
        /// Gets or sets the text boxes.
        /// </summary>
        /// <value>
        /// The text boxes.
        /// </value>
        public virtual IEnumerable<TextBox> TextBoxes { get; set; }

        /// <summary>
        /// Gets or sets the sqlite data types.
        /// </summary>
        /// <value>
        /// The sqlite data types.
        /// </value>
        public virtual IEnumerable<string> DataTypes { get; set; }

        /// <summary>
        /// Gets the data types.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        public virtual IEnumerable<string> GetDataTypes( Provider provider )
        {
            if( Enum.IsDefined( typeof( Provider ), provider ) )
            {
                try
                {
                    var _query = "SELECT DISTINCT SchemaTypes.TypeName" + " FROM SchemaTypes"
                        + $" WHERE SchemaTypes.Provider = '{provider}'";

                    var _model = new DataBuilder( Source.SchemaTypes, Provider.Access, _query );
                    var _data = _model.DataTable.GetUniqueFieldValues( "TypeName" );

                    return _data?.Length > 0
                        ? _data
                        : default( IEnumerable<string> );
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
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void OnCloseButtonClicked( object sender, EventArgs e )
        {
            try
            {
                Close( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the table ListBox items.
        /// </summary>
        /// <param name="listBox">The list box.</param>
        public virtual void PopulateTableListBoxItems( ListBox listBox )
        {
            try
            {
                var _names = Enum.GetNames( typeof( Source ) );

                if( listBox?.Items.Count > 0 )
                {
                    listBox.Items.Clear( );

                    foreach( var name in _names )
                    {
                        if( name != "NS" )
                        {
                            listBox?.Items.Add( name );
                        }
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the group box properties.
        /// </summary>
        public virtual void SetGroupBoxProperties( )
        {
            if( GroupBoxes?.Values?.Any( ) == true )
            {
                try
                {
                    foreach( var _groupBox in GroupBoxes.Values )
                    {
                        _groupBox.SeparatorColor = Color.FromArgb( 64, 64, 64 );
                        _groupBox.Separate = true;
                        _groupBox.Separator = true;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the RadioButton properties.
        /// </summary>
        public virtual void SetRadioButtonProperties( )
        {
            if( RadioButtons?.Values?.Any( ) == true )
            {
                try
                {
                    foreach( var _radioButton in RadioButtons.Values )
                    {
                        _radioButton.ForeColor = Color.FromArgb( 0, 120, 212 );
                        _radioButton.CheckSignColor = Color.LimeGreen;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the radio buttons.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, RadioButton> GetRadioButtons( )
        {
            if( TabPages?.Count > 0 )
            {
                try
                {
                    var _buttons = new Dictionary<string, RadioButton>( );

                    foreach( var _tabPage in TabPages.Values )
                    {
                        if( _tabPage is TabPageAdv _tab )
                        {
                            foreach( var _control in _tab.Controls )
                            {
                                if( _control is GroupBox _group )
                                {
                                    foreach( var _item in _group.Controls )
                                    {
                                        if( _item is RadioButton _radioButton )
                                        {
                                            _buttons.Add( _radioButton.Name, _radioButton );
                                        }
                                    }
                                }
                            }
                        }
                    }

                    return _buttons?.Any( ) == true
                        ? _buttons
                        : default( IDictionary<string, RadioButton> );
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
        /// Gets the combo boxes.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, ComboBox> GetComboBoxes( )
        {
            if( TabPages?.Count > 0 )
            {
                try
                {
                    var _buttons = new Dictionary<string, ComboBox>( );

                    foreach( var _tabPage in TabPages.Values )
                    {
                        if( _tabPage is TabPageAdv _tab )
                        {
                            foreach( Control _control in _tab.Controls )
                            {
                                if( _control.Controls.Count > 0 )
                                {
                                    foreach( Control _subControl in _control.Controls )
                                    {
                                        if( _subControl is ComboBox _comboBox )
                                        {
                                            _buttons.Add( _comboBox.Name, _comboBox );
                                        }
                                    }
                                }
                            }
                        }
                    }

                    return _buttons?.Any( ) == true
                        ? _buttons
                        : default( IDictionary<string, ComboBox> );
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
        /// Gets the group boxes.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, GroupBox> GetGroupBoxes( )
        {
            if( TabPages?.Count > 0 )
            {
                try
                {
                    var _groupBoxes = new Dictionary<string, GroupBox>( );

                    foreach( var _tabPage in TabPages.Values )
                    {
                        foreach( var _control in _tabPage.Controls )
                        {
                            if( _control is GroupBox _groupBox )
                            {
                                _groupBoxes.Add( _groupBox.Name, _groupBox );
                            }
                        }
                    }

                    return _groupBoxes?.Any( ) == true
                        ? _groupBoxes
                        : default( IDictionary<string, GroupBox> );
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
        /// Gets the list boxes.
        /// </summary>
        /// <returns></returns>
        public virtual IDictionary<string, ListBox> GetListBoxes( )
        {
            if( TabPages?.Count > 0 )
            {
                try
                {
                    var _listBoxes = new Dictionary<string, ListBox>( );

                    foreach( var _tabPage in TabPages.Values )
                    {
                        if( _tabPage?.Controls?.Count > 0 )
                        {
                            foreach( var _control in _tabPage.Controls )
                            {
                                if( _control is ListBox _listBox )
                                {
                                    _listBoxes.Add( _listBox.Name, _listBox );
                                }
                            }
                        }
                    }

                    return _listBoxes?.Any( ) == true
                        ? _listBoxes
                        : default( IDictionary<string, ListBox> );
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
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}