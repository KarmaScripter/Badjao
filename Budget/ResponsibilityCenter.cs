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
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Local" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    public class ResponsibilityCenter : Element, IResponsibilityCenter, ISource
    {
        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; set; } = Source.ResponsibilityCenters;

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
        /// Gets the rc.
        /// </summary>
        /// <value>
        /// The rc.
        /// </value>
        public RC RC { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResponsibilityCenter"/> class.
        /// </summary>
        public ResponsibilityCenter( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResponsibilityCenter"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public ResponsibilityCenter( IQuery query )
            : this( )
        {
            Record = new DataBuilder( query )?.Record;
            ID = new Key( Record, PrimaryKey.ResponsibilityCentersId );
            Name = Record[ $"{ Field.Name }" ].ToString(  );
            Code = Record[ $"{ Field.Code }" ].ToString(  );
            Data = Record?.ToDictionary( );
            RC = (RC)Enum.Parse( typeof( RC ), Name );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResponsibilityCenter"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public ResponsibilityCenter( IDataModel builder )
        {
            Record = builder?.Record;
            ID = new Key( Record, PrimaryKey.ResponsibilityCentersId );
            Name = Record[ $"{ Field.Name }" ].ToString(  );
            Code = Record[ $"{ Field.Code }" ].ToString(  );
            Data = Record?.ToDictionary( );
            RC = (RC)Enum.Parse( typeof( RC ), Name );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ResponsibilityCenter"/> class.
        /// </summary>
        /// <param name="data">The Data.</param>
        public ResponsibilityCenter( DataRow data )
            : this( )
        {
            Record = data;
            ID = new Key( Record, PrimaryKey.ResponsibilityCentersId );
            Name = Record[ $"{ Field.Name }" ].ToString(  );
            Code = Record[ $"{ Field.Code }" ].ToString(  );
            Data = Record?.ToDictionary( );
            RC = (RC)Enum.Parse( typeof( RC ), Name );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsibilityCenter"/> class.
        /// </summary>
        /// <param name="rcCode">The rcCode.</param>
        public ResponsibilityCenter( string rcCode )
            : this( )
        {
            Record = new DataBuilder( Source, SetArgs( rcCode ) )?.Record;
            ID = new Key( Record, PrimaryKey.ResponsibilityCentersId );
            Name = Record[ $"{ Field.Name }" ].ToString(  );
            Code = Record[ $"{ Field.Code }" ].ToString(  );
            Data = Record?.ToDictionary( );
            RC = (RC)Enum.Parse( typeof( RC ), Name );
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
        /// Gets the responsibility center.
        /// </summary>
        /// <returns>
        /// </returns>
        public IResponsibilityCenter GetResponsibilityCenter( )
        {
            try
            {
                return MemberwiseClone( ) as IResponsibilityCenter;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IResponsibilityCenter );
            }
        }
    }
}