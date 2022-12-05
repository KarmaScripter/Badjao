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
    /// <seealso cref = "INationalProgram"/>
    /// <seealso cref = "IProgram"/>
    /// <seealso cref = "ISource"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "Performance", "CA1822:Mark members as static" ) ]
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
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets the code.
        /// </summary>
        public override string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public override string Name { get; set; }

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
        public string Title { get; set; }

        /// <summary>
        /// Gets the rpio code.
        /// </summary>
        /// <value>
        /// The rpio code.
        /// </value>
        public string RpioCode { get; set; }

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
            ID = GetId( Record, PrimaryKey.NationalProgramsId );
            Name = Record[ $"{ Field.Name }" ].ToString(  );
            Code = Record[ $"{ Field.Code }" ].ToString(  );
            RpioCode = Record[ $"{ Field.RpioCode }" ].ToString(  );
            Title = Record[ $"{ Field.Title }" ].ToString(  );
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
            ID = GetId( Record, PrimaryKey.NationalProgramsId );
            Name = Record[ $"{ Field.Name }" ].ToString(  );
            Code = Record[ $"{ Field.Code }" ].ToString(  );
            RpioCode = Record[ $"{ Field.RpioCode }" ].ToString(  );
            Title = Record[ $"{ Field.Title }" ].ToString(  );
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
            ID = GetId( Record, PrimaryKey.NationalProgramsId );
            Name = dataRow[ $"{ Field.Name }" ].ToString(  );
            Code = dataRow[ $"{ Field.Code }" ].ToString(  );
            RpioCode = dataRow[ $"{ Field.RpioCode }" ].ToString(  );
            Title = dataRow[ $"{ Field.Title }" ].ToString(  );
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
            ID = GetId( Record, PrimaryKey.NationalProgramsId );
            Name = Record[ $"{ Field.Name }" ].ToString(  );
            Code = Record[ $"{ Field.Code }" ].ToString(  );
            RpioCode = Record[ $"{ Field.RpioCode }" ].ToString(  );
            Title = Record[ $"{ Field.Title }" ].ToString(  );
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
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
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
                    : default( IDictionary<string, object> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, object> );
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
                return default( INationalProgram );
            }
        }

        protected override int GetId( DataRow dataRow )
        {
            try
            {
                return dataRow != null
                    ? int.Parse( dataRow[ 0 ].ToString(  ) )
                    : -1;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( int );
            }
        }

        protected override int GetId( DataRow dataRow, PrimaryKey primaryKey )
        {
            try
            {
                return Enum.IsDefined( typeof( PrimaryKey ), primaryKey ) && dataRow != null
                    ? int.Parse( dataRow[ $"{ primaryKey }" ].ToString(  ) )
                    : -1;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( int );
            }
        }
    }
}