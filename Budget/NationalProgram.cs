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
    using BudgetExecution.Budget;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref = "INationalProgram"/>
    /// <seealso cref = "IProgram"/>
    /// <seealso cref = "ISource"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    public class NationalProgram : Element, INationalProgram, ISource
    {
        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; set; } = Source.NationalPrograms;

        /// <summary>
        /// Gets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public IElement Title { get; set; }

        /// <summary>
        /// Gets the rpio code.
        /// </summary>
        /// <value>
        /// The rpio code.
        /// </value>
        public IElement RpioCode { get; set; }

        /// <summary>
        /// Gets or sets the NPM.
        /// </summary>
        /// <value>
        /// The NPM.
        /// </value>
        public NPM NPM { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref = "NationalProgram"/> class.
        /// </summary>
        public NationalProgram( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "NationalProgram"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public NationalProgram( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = new Key( Record, PrimaryKey.NationalProgramsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            RpioCode = new Element( Record, Field.RpioCode );
            Title = new Element( Record, Field.Title );
            Data = Record?.ToDictionary( );
            NPM = (NPM)Enum.Parse( typeof( NPM ), Code );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "NationalProgram"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public NationalProgram( IDataModel builder )
        {
            Record = builder?.Record;
            ID = new Key( Record, PrimaryKey.NationalProgramsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            RpioCode = new Element( Record, Field.RpioCode );
            Title = new Element( Record, Field.Title );
            Data = Record?.ToDictionary( );
            NPM = (NPM)Enum.Parse( typeof( NPM ), Code );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "NationalProgram"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        public NationalProgram( DataRow dataRow )
        {
            Record = dataRow;
            ID = new Key( Record, PrimaryKey.NationalProgramsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            RpioCode = new Element( Record, Field.RpioCode );
            Title = new Element( Record, Field.Title );
            Data = Record?.ToDictionary( );
            NPM = (NPM)Enum.Parse( typeof( NPM ), Code );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "NationalProgram"/> class.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        public NationalProgram( string code )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            ID = new Key( Record, PrimaryKey.NationalProgramsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            RpioCode = new Element( Record, Field.RpioCode );
            Title = new Element( Record, Field.Title );
            Data = Record?.ToDictionary( );
            NPM = (NPM)Enum.Parse( typeof( NPM ), Code );
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
        /// Gets the rpio code.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetRpioCode( )
        {
            try
            {
                return !string.IsNullOrEmpty( RpioCode?.Value?.ToString( ) )
                    ? RpioCode
                    : Default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Default;
            }
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
        
        /// <summary>
        /// Gets the national program office.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetNationalProgramOffice( )
        {
            try
            {
                return Title ?? default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Default;
            }
        }

        /// <summary>
        /// Gets the national program.
        /// </summary>
        /// <returns>
        /// </returns>
        public INationalProgram GetNationalProgram( )
        {
            try
            {
                return MemberwiseClone( ) as INationalProgram;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }
    }
}