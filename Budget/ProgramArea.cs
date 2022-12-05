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
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class ProgramArea : Element, IProgramArea, ISource
    {
        /// <summary>
        /// Gets the dataRow.
        /// </summary>
        /// <value>
        /// The dataRow.
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
        /// The source
        /// </summary>
        public Source Source { get; set; } = Source.ProgramAreas;

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramArea"/> class.
        /// </summary>
        public ProgramArea( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramArea"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public ProgramArea( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = GetId( Record, PrimaryKey.ProgramAreasId );
            Name = Record[ $"{ Field.Name }" ].ToString( );
            Code = Record[ $"{ Field.Code }" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramArea"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public ProgramArea( IDataModel builder )
        {
            Record = builder?.Record;
            ID = GetId( Record, PrimaryKey.ProgramAreasId );
            Name = Record[ $"{ Field.Name }" ].ToString( );
            Code = Record[ $"{ Field.Code }" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramArea"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        public ProgramArea( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            ID = GetId( dataRow, PrimaryKey.ProgramAreasId );
            Name = dataRow[ $"{ Field.Name }" ].ToString( );
            Code = dataRow[ $"{ Field.Code }" ].ToString( );
            Data = dataRow?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramArea"/> class.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        public ProgramArea( string code )
        {
            Record = new DataBuilder( Source, SetArgs( code ) )?.Record;
            ID = GetId( Record, PrimaryKey.ProgramAreasId );
            Name = Record[ $"{ Field.Name }" ].ToString( );
            Code = Record[ $"{ Field.Code }" ].ToString( );
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
        private IDictionary<string, object> SetArgs( string code )
        {
            if( !string.IsNullOrEmpty( code ) )
            {
                try
                {
                    return new Dictionary<string, object> { [ $"{Field.Code}" ] = code };
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
        /// Gets the program area.
        /// </summary>
        /// <returns>
        /// </returns>
        public IProgramArea GetProgramArea( )
        {
            try
            {
                return MemberwiseClone( ) as ProgramArea;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ProgramArea );
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