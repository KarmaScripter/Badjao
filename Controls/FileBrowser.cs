// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using System.Linq;
    using static System.Configuration.ConfigurationManager;
    using static System.Environment;
    using static System.IO.Directory;
    using CheckState = MetroSet_UI.Enums.CheckState;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public partial class FileBrowser
    {
        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        /// <value>
        /// The extension.
        /// </value>
        public EXT Extension { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        /// <value>
        /// The extension.
        /// </value>
        public string FileExtension { get; set; }

        /// <summary>
        /// Gets or sets the initial path.
        /// </summary>
        /// <value>
        /// The initial path.
        /// </value>
        public IEnumerable<string> InitialDirPaths { get; set; }

        /// <summary>
        /// Gets or sets the initial path.
        /// </summary>
        /// <value>
        /// The initial path.
        /// </value>
        public IEnumerable<string> FilePaths { get; set; }

        /// <summary>
        /// Gets or sets the check boxes.
        /// </summary>
        /// <value>
        /// The check boxes.
        /// </value>
        public IEnumerable<RadioButton> RadioButtons { get; set; }

        /// <summary>
        /// Gets or sets the selected path.
        /// </summary>
        /// <value>
        /// The selected path.
        /// </value>
        public string SelectedPath { get; set; }

        /// <summary>
        /// Gets or sets the selected file.
        /// </summary>
        /// <value>
        /// The selected file.
        /// </value>
        public string SelectedFile { get; set; }

        /// <summary>Initializes a new instance of the 
        /// <see cref="FileBrowser" /> class.</summary>
        public FileBrowser( )
        {
            InitializeComponent( );
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.LightSteelBlue;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Size = new Size( 700, 480 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackColor = Color.FromArgb( 20, 20, 20 );
            InitialDirPaths = GetInitialDirPaths( );
            RadioButtons = GetRadioButtons( );
            FileExtension = "xlsx";
            Picture.Image = GetImage( );
            FilePaths = GetListViewPaths( );
            FileDialog.DefaultExt = FileExtension;
            FileDialog.InitialDirectory = GetFolderPath( SpecialFolder.DesktopDirectory );
            FileDialog.CheckFileExists = true;
            FileList.BackColor = Color.Transparent;
            CloseButton.Click += OnCloseButtonClicked;
            FileList.SelectedValueChanged += OnPathSelected;
            Load += OnLoaded;
        }

        /// <summary>
        /// Called when [browser loaded].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnLoaded( object sender, EventArgs e )
        {
            if( FilePaths?.Any( ) == true )
            {
                try
                {
                    PopulateListView( );
                    FoundLabel.Text = "Found : " + FilePaths?.Count( );
                    ClearRadioButtons( );
                    SetRadioButtonEvents( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <returns></returns>
        public Image GetImage( )
        {
            if( !string.IsNullOrEmpty( FileExtension ) )
            {
                try
                {
                    var _path = AppSettings[ "Extensions" ];
                    var _files = GetFiles( _path );
                    if( _files?.Any( ) == true )
                    {
                        var _extension = FileExtension.TrimStart( '.' ).ToUpper( );
                        var _file = _files.Where( f => f.Contains( _extension ) )?.First( );
                        using var stream = File.Open( _file, FileMode.Open );
                        var _img = Image.FromStream( stream );
                        return new Bitmap( _img, 22, 22 );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( Bitmap );
                }
            }

            return default( Bitmap );
        }

        /// <summary>
        /// Clears the check boxes.
        /// </summary>
        public void ClearRadioButtons( )
        {
            try
            {
                foreach( var radioButton in RadioButtons )
                {
                    radioButton.CheckedChanged += null;
                    radioButton.CheckState = CheckState.Unchecked;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the RadioButton events.
        /// </summary>
        public void SetRadioButtonEvents( )
        {
            try
            {
                foreach( var radioButton in RadioButtons )
                {
                    radioButton.CheckedChanged += OnRadioButtonSelected;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the ListView file paths.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetListViewPaths( )
        {
            if( InitialDirPaths?.Any( ) == true )
            {
                try
                {
                    var _list = new List<string>( );

                    foreach( var path in InitialDirPaths )
                    {
                        var _first = GetFiles( path )
                            ?.Where( f => f.EndsWith( FileExtension ) )
                            ?.Select( f => Path.GetFullPath( f ) )
                            ?.ToList( );

                        _list.AddRange( _first );
                        var _dirs = GetDirectories( path );

                        foreach( var dir in _dirs )
                        {
                            if( !dir.Contains( "My " ) )
                            {
                                var _second = GetFiles( dir )
                                    ?.Where( s => s.EndsWith( FileExtension ) )
                                    ?.Select( s => Path.GetFullPath( s ) )
                                    ?.ToList( );

                                if( _second?.Any( ) == true )
                                {
                                    _list.AddRange( _second );
                                }

                                var _subdir = GetDirectories( dir );

                                for( var i = 0; i < _subdir.Length; i++ )
                                {
                                    var sub = _subdir[ i ];
                                    if( !string.IsNullOrEmpty( sub ) )
                                    {
                                        var _last = GetFiles( sub )
                                            ?.Where( l => l.EndsWith( FileExtension ) )
                                            ?.Select( l => Path.GetFullPath( l ) )
                                            ?.ToList( );

                                        if( _last?.Any( ) == true )
                                        {
                                            _list.AddRange( _last );
                                        }
                                    }
                                }
                            }
                        }
                    }

                    return _list?.Any( ) == true
                        ? _list
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
        /// Called when [selection].
        /// </summary>
        /// <param name="sender">The sender instance containing the event data.</param>
        public virtual void OnRadioButtonSelected( object sender )
        {
            if( sender is RadioButton _radioButton
               && !string.IsNullOrEmpty( _radioButton.Tag?.ToString( ) ) )
            {
                try
                {
                    FileExtension = _radioButton?.Result;
                    MessageLabel.Text = string.Empty;
                    FoundLabel.Text = string.Empty;
                    var _paths = GetListViewPaths( );
                    PopulateListView( _paths );
                    Picture.Image = GetImage( );
                    FoundLabel.Text = "Found: " + _paths?.ToList( )?.Count ?? "0";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the check boxex.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<RadioButton> GetRadioButtons( )
        {
            try
            {
                var _list = new List<RadioButton>
                {
                    PdfRadioButton,
                    AccessRadioButton,
                    SQLiteRadioButton,
                    SqlCeRadioButton,
                    SqlServerRadioButton,
                    ExcelRadioButton,
                    CsvRadioButton,
                    TextRadioButton,
                    PowerPointRadioButton,
                    WordRadioButton,
                    ExecutableRadioButton,
                    LibraryRadioButton
                };

                return _list?.Any( ) == true
                    ? _list
                    : default( IEnumerable<RadioButton> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the initial paths.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<string> GetInitialDirPaths( )
        {
            try
            {
                var _current = CurrentDirectory;
                var _list = new List<string>
                {
                    GetFolderPath( SpecialFolder.DesktopDirectory ),
                    GetFolderPath( SpecialFolder.Personal ),
                    GetFolderPath( SpecialFolder.Recent ),
                    @"C:\Users\terry\source\repos\Badjao\Resources\Documents",
                    _current
                };

                return _list?.Any( ) == true
                    ? _list
                    : default( IEnumerable<string> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Populates the ListView.
        /// </summary>
        public virtual void PopulateListView( )
        {
            if( FilePaths?.Any( ) == true )
            {
                try
                {
                    foreach( var path in FilePaths )
                    {
                        FileList.Items.Add( path );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Populates the ListView.
        /// </summary>
        /// <param name="filePaths">The file paths.</param>
        public virtual void PopulateListView( IEnumerable<string> filePaths )
        {
            try
            {
                if( filePaths?.Any( ) == true )
                {
                    FileList.Items.Clear( );
                    var _paths = filePaths.ToArray( );
                    for( var i = 0; i < _paths.Length; i++ )
                    {
                        var path = _paths[ i ];
                        if( !string.IsNullOrEmpty( path ) )
                        {
                            FileList?.Items.Add( path );
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
        /// Called when [path selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void OnPathSelected( object sender )
        {
            if( sender is ListBox listBox
               && !string.IsNullOrEmpty( listBox.SelectedItem?.ToString( ) ) )
            {
                try
                {
                    SelectedPath = listBox.SelectedItem?.ToString( );
                    MessageLabel.Text = SelectedPath;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void OnCloseButtonClicked( object sender, EventArgs e )
        {
            if( sender is Button )
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
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The exception.</param>
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}