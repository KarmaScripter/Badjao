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
            Name = Record[ $"{ Field.Name }" ].ToString(  );
            Code = Record[ $"{ Field.Code }" ].ToString(  );
            Title = Record[ $"{ Field.Title }" ].ToString( );
            Definition = Record[ $"{ Field.Definition }" ].ToString( );
            Laws = Record[ $"{ Field.Laws }" ].ToString( );
            ProgramAreaCode = Record[ $"{ Field.ProgramAreaCode }" ].ToString( );
            ProgramAreaName = Record[ $"{ Field.ProgramAreaName }" ].ToString( );
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
            Name = Record[ $"{ Field.Name }" ].ToString(  );
            Code = Record[ $"{ Field.Code }" ].ToString(  );
            Title = Record[ $"{ Field.Title }" ].ToString( );
            Definition = Record[ $"{ Field.Definition }" ].ToString( );
            Laws = Record[ $"{ Field.Laws }" ].ToString( );
            ProgramAreaCode = Record[ $"{ Field.ProgramAreaCode }" ].ToString( );
            ProgramAreaName = Record[ $"{ Field.ProgramAreaName }" ].ToString( );
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
            Name = dataRow[ $"{ Field.Name }" ].ToString(  );
            Code = dataRow[ $"{ Field.Code }" ].ToString(  );
            Title = dataRow[ $"{ Field.Title }" ].ToString( );
            Definition = dataRow[ $"{ Field.Definition }" ].ToString( );
            Laws = dataRow[ $"{ Field.Laws }" ].ToString( );
            ProgramAreaCode = dataRow[ $"{ Field.ProgramAreaCode }" ].ToString( );
            ProgramAreaName = dataRow[ $"{ Field.ProgramAreaName }" ].ToString( );
            Data = dataRow?.ToDictionary( );
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
            Name = Record[ $"{ Field.Name }" ].ToString(  );
            Code = Record[ $"{ Field.Code }" ].ToString(  );
            Title = Record[ $"{ Field.Title }" ].ToString( );
            Definition = Record[ $"{ Field.Definition }" ].ToString( );
            Laws = Record[ $"{ Field.Laws }" ].ToString( );
            ProgramAreaCode = Record[ $"{ Field.ProgramAreaCode }" ].ToString( );
            ProgramAreaName = Record[ $"{ Field.ProgramAreaName }" ].ToString( );
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
    }
}