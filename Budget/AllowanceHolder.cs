﻿// <copyright file = "AllowanceHolder.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// Generally, an organized set of activities directed toward a common purpose or
    /// goal that an agency undertakes or proposes to carry out its responsibilities.
    /// Because the term has many uses in practice, it does not have a well-defined,
    /// standard meaning in the legislative process. It is used to describe an agency’s
    /// mission, functions, activities, services, projects, and processes. An Allowance
    /// Holder is also an element within a budget account. For annually appropriated
    /// accounts, the Office of Management and Budget (OMB) and agencies identify PPAs
    /// by reference to committee reports and budget justifications; for permanent
    /// appropriations, OMB and agencies identify Allowance Holders by the program and
    /// financing schedules that the President provides in the “Detailed Budget
    /// Estimates” in the budget submission for the relevant fiscal year. Program
    /// activity structures are intended to provide a meaningful representation of the
    /// operations financed by a specific budget account—usually by project, activity,
    /// or organization. 31 U.S.C. 1514 provides that agency allotments will be
    /// established at the highest practical level. At the EPA, OMB apportions the
    /// appropriated funds to the EPA OB Director as the agency’s single Allowance
    /// Holder. Note there is a separate allotment for every appropriation (Treasury
    /// account symbol) for every fiscal year. The OB Director retains the original
    /// signed apportionment documents on behalf of the agency. This is the agency’s
    /// formal designation regarding “Administrative Subdivisions of Funds.” The agency
    /// does not have sub-allotments. The one restriction on the agency’s allotment is
    /// that it cannot exceed the amount of the apportionment. At the Regional level,
    /// Allowance Holder's further divide the Agency's funding with the Regional
    /// Administrator being identified as the primary regional Allowance Holder.
    /// </summary>
    /// <seealso cref = "IAllowanceHolder"/>
    /// <seealso cref = "IProgram"/>
    /// <seealso cref = "ISource"/>
    /// <seealso cref = "IAllowanceHolder"/>
    /// <seealso cref = "IDataBuilder"/>
    /// <seealso cref = "ISource"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Local" ) ]
    public class AllowanceHolder : Element, IAllowanceHolder, ISource
    {
        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; set; } =  Source.AllowanceHolders;

        /// <summary>
        /// Gets or sets the dict.
        /// </summary>
        /// <value>
        /// The dict.
        /// </value>
        public DataRow Record { get;  } 

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public IDictionary<string, object> Data { get;  } 
        
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "AllowanceHolder"/> class.
        /// </summary>
        public AllowanceHolder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "AllowanceHolder"/> class.
        /// </summary>
        /// <param name = "dataBuilder" >
        /// The dataBuilder.
        /// </param>
        public AllowanceHolder( DataBuilder dataBuilder )
        {
            Record = dataBuilder?.Record;
            ID = new Key( Record, PrimaryKey.AllowanceHoldersId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "AllowanceHolder"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public AllowanceHolder( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = new Key( Record, PrimaryKey.AllowanceHoldersId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "AllowanceHolder"/> class.
        /// </summary>
        /// <param name = "data" >
        /// The Data.
        /// </param>
        public AllowanceHolder( DataRow data )
            : this()
        {
            Record = data;
            ID = new Key( Record, PrimaryKey.AllowanceHoldersId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Data = Record?.ToDictionary();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "AllowanceHolder"/> class.
        /// </summary>
        /// <param name = "ahcode" >
        /// The ahcode.
        /// </param>
        public AllowanceHolder( string ahcode )
        {
            Record = new DataBuilder( Source, SetArgs( ahcode ) )?.Record;
            ID = new Key( Record, PrimaryKey.AllowanceHoldersId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Data = Record?.ToDictionary();
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
                    return new Dictionary<string, object>
                    {
                        [ $"{Field.Code}" ] = code
                    };
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
        public IDictionary<string, object> ToDictionary()
        {
            try
            {
                return ( Data?.Any( ) == true )
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
        /// Gets the allowance holder.
        /// </summary>
        /// <returns>
        /// </returns>
        public IAllowanceHolder GetAllowanceHolder()
        {
            try
            {
                return (AllowanceHolder)MemberwiseClone( );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IAllowanceHolder );
            }
        }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <returns>
        /// </returns>
        public Source GetSource()
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