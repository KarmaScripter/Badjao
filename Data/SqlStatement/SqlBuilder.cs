// // <copyright file = "SqlBuilder.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    public class SqlBuilder
    {
        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// The provider
        /// </summary>
        public EXT Extension { get; set; }

        /// <summary>
        /// The command type
        /// </summary>
        public SQL CommandType { get; set; }

        /// <summary>
        /// The file name
        /// </summary>
        public IEnumerable<string> Files { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public string FileName { get; set; }

        /// <summary>
        /// The file name
        /// </summary>
        public string DirectoryPath { get; set; }

        /// <summary>
        /// Gets or sets the command repository.
        /// </summary>
        /// <value>
        /// The command repository.
        /// </value>
        public IDictionary<string, string> Commands { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBuilder"/> class.
        /// </summary>
        public SqlBuilder( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBuilder"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name = "ext" > </param>
        /// <param name="commandType">Type of the command.</param>
        public SqlBuilder( Source source, SQL commandType, EXT ext )
        {
            Source = source;
            CommandType = commandType;
            Extension = ext;
            DirectoryPath = GetSqlDirectoryPath( );
            Files = Directory.GetFiles( DirectoryPath );
            Commands = GetCommands( );
        }

        /// <summary>
        /// Gets the SQL directory path.
        /// </summary>
        /// <returns></returns>
        private string GetSqlDirectoryPath( )
        {
            if( Enum.IsDefined( typeof( EXT ), Extension ) )
            {
                try
                {
                    var _path = ConfigurationManager.AppSettings[ $"{Extension}" ];
                    var _index = _path.LastIndexOf( @"\" );
                    var _size = _path.Length;
                    var _end = _size - _index;
                    var _folder = $@"\{CommandType}";
                    var _remove = _path?.Remove( _index, _end );
                    var _dirpath = _remove + _folder;
                    return Directory.Exists( _dirpath )
                        ? _dirpath
                        : string.Empty;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Gets the command repository.
        /// </summary>
        /// <returns></returns>
        private IDictionary<string, string> GetCommands( )
        {
            if( Enum.IsDefined( typeof( SQL ), CommandType )
               && Files?.Any( ) == true )
            {
                var _repository = new Dictionary<string, string>( );
                foreach( var file in Files )
                {
                    string _output;
                    using( var _stream = File.OpenText( file ) )
                    {
                        _output = _stream.ReadToEnd( );
                    }

                    if( !string.IsNullOrEmpty( _output ) )
                    {
                        var _name = Path.GetFileNameWithoutExtension( file );
                        _repository.Add( _name, _output );
                    }
                }

                return _repository?.Any( ) == true
                    ? _repository
                    : default( IDictionary<string, string> );
            }

            return default( IDictionary<string, string> );
        }

        /// <summary>
        /// Gets the command text.
        /// </summary>
        /// <param name="commandName">Name of the command.</param>
        /// <returns></returns>
        public string GetCommandText( string commandName )
        {
            if( !string.IsNullOrEmpty( commandName )
               && Commands?.Any( ) == true
               && Commands.Keys?.Contains( commandName ) == true )
            {
                try
                {
                    return Commands[ commandName ];
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}