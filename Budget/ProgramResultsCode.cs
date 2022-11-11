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
    /// Program Results Codes (PRCs) were established to account for and relate
    /// resources to the Agency's Strategic Plan goals and objectives, national program
    /// offices and responsibilities, and governmental functions. PRCs are created when
    /// the annual EPA Budget is submitted to Congress each February and then formally
    /// established in IFMS with the enactment of EPA's appropriation act. PRCs may be
    /// updated at any time.
    /// </summary>
    /// <seealso cref = "PrcConfig"/>
    /// <seealso cref = "IProgramResultsCode"/>
    /// <seealso cref = "IProgram"/>
    /// <seealso cref = "IDataModel"/>
    /// <seealso cref = "IProgramResultsCode"/>
    /// <seealso cref = "IFund"/>
    /// <seealso cref = "ISource"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class ProgramResultsCode : PrcConfig, IProgramResultsCode
    {
        /// <summary>
        /// The source
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public virtual Source Source { get; set; } = Source.Allocations;

        /// <summary>
        /// Gets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public IAmount Amount { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Gets or sets the Data elements.
        /// </summary>
        /// <value>
        /// The Data elements.
        /// </value>
        public IEnumerable<IElement> Elements { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramResultsCode"/> class.
        /// </summary>
        public ProgramResultsCode( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramResultsCode"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public ProgramResultsCode( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = new Key( Record, PrimaryKey.AllocationsId );
            BudgetLevel = new Element( Record, Field.BudgetLevel );
            BFY = new Element( Record, Field.BFY );
            RpioCode = new Element( Record, Field.RpioCode );
            AhCode = new Element( Record, Field.AhCode );
            FundCode = new Element( Record, Field.FundCode );
            OrgCode = new Element( Record, Field.OrgCode );
            RcCode = new Element( Record, Field.RcCode );
            BocCode = new Element( Record, Field.BocCode );
            AccountCode = new Element( Record, Field.AccountCode );
            ActivityCode = new Element( Record, Field.ActivityCode );
            Amount = new Amount( Record, Numeric.Amount );
            Data = Record?.ToDictionary( );
            Elements = GetElements( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramResultsCode"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public ProgramResultsCode( IDataModel builder )
        {
            Record = builder?.Record;
            ID = new Key( Record, PrimaryKey.AllocationsId );
            BudgetLevel = new Element( Record, Field.BudgetLevel );
            BFY = new Element( Record, Field.BFY );
            RpioCode = new Element( Record, Field.RpioCode );
            AhCode = new Element( Record, Field.AhCode );
            FundCode = new Element( Record, Field.FundCode );
            OrgCode = new Element( Record, Field.OrgCode );
            RcCode = new Element( Record, Field.RcCode );
            BocCode = new Element( Record, Field.BocCode );
            AccountCode = new Element( Record, Field.AccountCode );
            ActivityCode = new Element( Record, Field.ActivityCode );
            Amount = new Amount( Record, Numeric.Amount );
            Data = Record?.ToDictionary( );
            Elements = GetElements( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramResultsCode"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        public ProgramResultsCode( DataRow dataRow )
        {
            Record = dataRow;
            ID = new Key( Record, PrimaryKey.AllocationsId );
            BudgetLevel = new Element( Record, Field.BudgetLevel );
            BFY = new Element( Record, Field.BFY );
            RpioCode = new Element( Record, Field.RpioCode );
            AhCode = new Element( Record, Field.AhCode );
            FundCode = new Element( Record, Field.FundCode );
            OrgCode = new Element( Record, Field.OrgCode );
            RcCode = new Element( Record, Field.RcCode );
            BocCode = new Element( Record, Field.BocCode );
            AccountCode = new Element( Record, Field.AccountCode );
            ActivityCode = new Element( Record, Field.ActivityCode );
            Amount = new Amount( Record, Numeric.Amount );
            Data = Record?.ToDictionary( );
            Elements = GetElements( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ProgramResultsCode"/> class.
        /// </summary>
        /// <param name = "dict" >
        /// </param>
        public ProgramResultsCode( IDictionary<string, object> dict )
        {
            Record = new DataBuilder( Source, dict )?.Record;
            ID = new Key( Record, PrimaryKey.AllocationsId );
            BudgetLevel = new Element( Record, Field.BudgetLevel );
            BFY = new Element( Record, Field.BFY );
            RpioCode = new Element( Record, Field.RpioCode );
            AhCode = new Element( Record, Field.AhCode );
            FundCode = new Element( Record, Field.FundCode );
            OrgCode = new Element( Record, Field.OrgCode );
            RcCode = new Element( Record, Field.RcCode );
            BocCode = new Element( Record, Field.BocCode );
            AccountCode = new Element( Record, Field.AccountCode );
            ActivityCode = new Element( Record, Field.ActivityCode );
            Amount = new Amount( Record, Numeric.Amount );
            Data = Record?.ToDictionary( );
            Elements = GetElements( );
        }

        /// <summary>
        /// Gets the program project.
        /// </summary>
        /// <returns>
        /// </returns>
        public IProgramProject GetProgramProject( )
        {
            try
            {
                var _account = GetAccount( );
                var _dict = new Dictionary<string, object>
                {
                    [ $"{ Field.Code }" ] = _account?.GetProgramProject( )?.Code
                };
                
                var _sqlStatement = new SqlStatement( Source.ProgramProjects, Provider.SQLite, _dict, SQL.SELECT );
                using var _query = new Query(  _sqlStatement );
                return new ProgramProject( _query ) ?? default( ProgramProject );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
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
                return !string.IsNullOrEmpty( GetAccount( ).ToString( ) )
                    ? GetAccount( ).GetProgramArea( )
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the program results code.
        /// </summary>
        /// <returns>
        /// </returns>
        public IProgramResultsCode GetProgramResultsCode( )
        {
            try
            {
                return MemberwiseClone( ) as ProgramResultsCode;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the elements.
        /// </summary>
        /// <returns>
        /// </returns>
        public IEnumerable<IElement> GetElements( )
        {
            try
            {
                var _elements = new List<IElement>
                {
                    BudgetLevel,
                    BFY,
                    RpioCode,
                    FundCode,
                    AhCode,
                    OrgCode,
                    AccountCode,
                    BocCode,
                    RcCode,
                    ActivityCode
                };

                return _elements?.Any( ) == true
                    ? _elements
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
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
        /// Gets the amount.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual IAmount GetAmount( )
        {
            try
            {
                return Amount?.Funding > -1
                    ? Amount
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Source GetSource( )
        {
            try
            {
                return Enum.IsDefined( typeof( Source ), Source )
                    ? Source
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