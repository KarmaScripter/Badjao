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
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
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
        /// Initializes a new instance of the
        /// <see cref = "AllowanceHolder"/> class.
        /// </summary>
        public AllowanceHolder( )
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
            ID = GetId( Record, PrimaryKey.AllowanceHoldersId );
            Name = Record?[ $"{ Field.ActivityName }" ].ToString( );
            Code = Record?[ $"{ Field.ActivityCode }" ].ToString( );
            Data = Record?.ToDictionary( );
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
            ID = GetId( Record, PrimaryKey.AllowanceHoldersId );
            Name = Record[ $"{ Field.ActivityName }" ].ToString( );
            Code = Record[ $"{ Field.ActivityCode }" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "AllowanceHolder"/> class.
        /// </summary>
        /// <param name = "data" >
        /// The Data.
        /// </param>
        public AllowanceHolder( DataRow data )
            : this( )
        {
            Record = data;
            ID = GetId( Record, PrimaryKey.AllowanceHoldersId );
            Name = Record[ $"{ Field.ActivityName }" ].ToString( );
            Code = Record[ $"{ Field.ActivityCode }" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "AllowanceHolder"/> class.
        /// </summary>
        /// <param name = "ahCode" >
        /// The ahcode.
        /// </param>
        public AllowanceHolder( string ahCode )
        {
            Record = new DataBuilder( Source, SetArgs( ahCode ) )?.Record;
            ID = GetId( Record, PrimaryKey.AllowanceHoldersId );
            Name = Record[ $"{ Field.ActivityName }" ].ToString( );
            Code = Record[ $"{ Field.ActivityCode }" ].ToString( );
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