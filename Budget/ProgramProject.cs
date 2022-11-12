// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    public class ProgramProject : DescriptionBase, ISource
    {
        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; set; } = Source.ProgramDescriptions;

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "ProgramProject"/> class.
        /// </summary>
        public ProgramProject( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramProject"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public ProgramProject( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = new Key( Record, PrimaryKey.ProgramProjectsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Title = new Element( Record, Field.Title );
            Definition = new Element( Record, Field.Definition );
            Laws = new Element( Record, Field.Laws );
            ProgramAreaCode = new Element( Record, Field.ProgramAreaCode );
            ProgramAreaName = new Element( Record, Field.ProgramAreaName );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramProject"/> class.
        /// </summary>
        /// <param name = "dataBuilder" >
        /// The dataBuilder.
        /// </param>
        public ProgramProject( IDataModel dataBuilder )
        {
            Record = dataBuilder?.Record;
            ID = new Key( Record, PrimaryKey.ProgramProjectsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Title = new Element( Record, Field.Title );
            Definition = new Element( Record, Field.Definition );
            Laws = new Element( Record, Field.Laws );
            ProgramAreaCode = new Element( Record, Field.ProgramAreaCode );
            ProgramAreaName = new Element( Record, Field.ProgramAreaName );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramProject"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        public ProgramProject( DataRow dataRow )
        {
            Record = dataRow;
            ID = new Key( Record, PrimaryKey.ProgramProjectsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Title = new Element( Record, Field.Title );
            Definition = new Element( Record, Field.Definition );
            Laws = new Element( Record, Field.Laws );
            ProgramAreaCode = new Element( Record, Field.ProgramAreaCode );
            ProgramAreaName = new Element( Record, Field.ProgramAreaName );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramProject"/> class.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        public ProgramProject( string code )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            ID = new Key( Record, PrimaryKey.ProgramProjectsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Title = new Element( Record, Field.Title );
            Definition = new Element( Record, Field.Definition );
            Laws = new Element( Record, Field.Laws );
            ProgramAreaCode = new Element( Record, Field.ProgramAreaCode );
            ProgramAreaName = new Element( Record, Field.ProgramAreaName );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        /// <returns>
        /// </returns>
        private IDictionary<string, object> GetArgs( string code )
        {
            if( !string.IsNullOrEmpty( code ) )
            {
                try
                {
                    return new Dictionary<string, object> { [ $"{ Field.Code }" ] = code };
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
        /// Converts to dictionary.
        /// </summary>
        /// <returns>
        /// </returns>
        public IDictionary<string, object> ToDictionary( )
        {
            try
            {
                return Data?.Any( ) == true
                    ? Data
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }
    }
}