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
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    public class Organization : Element, IOrganization, ISource
    {
        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; set; } = Source.Organizations;

        /// <summary>
        /// Gets the dataRow.
        /// </summary>
        /// <value>
        /// The dataRow.
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
        /// Initializes a new instance of the <see cref = "Organization"/> class.
        /// </summary>
        public Organization( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Organization"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public Organization( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = new Key( Record, PrimaryKey.OrganizationsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Organization"/> class.
        /// </summary>
        /// <param name = "org" >
        /// The org.
        /// </param>
        public Organization( string org )
        {
            Record = new DataBuilder( Source, GetArgs( org ) )?.Record;
            ID = new Key( Record, PrimaryKey.OrganizationsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Organization"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public Organization( IDataModel builder )
        {
            Record = builder?.Record;
            ID = new Key( Record, PrimaryKey.OrganizationsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Organization"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        public Organization( DataRow dataRow )
        {
            Record = dataRow;
            ID = new Key( Record, PrimaryKey.OrganizationsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
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
                    return new Dictionary<string, object> { [ $"{Field.Code}" ] = code };
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

        /// <summary>
        /// Gets the organization.
        /// </summary>
        /// <returns>
        /// </returns>
        public IOrganization GetOrganization( )
        {
            try
            {
                return MemberwiseClone( ) as Organization;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <returns>
        /// </returns>
        public Source GetSource( )
        {
            try
            {
                return Enum.IsDefined( typeof( Source ), Source )
                    ? Source
                    : Source.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Source.NS;
            }
        }
    }
}