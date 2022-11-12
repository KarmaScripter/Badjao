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
    [ SuppressMessage( "ReSharper", "PropertyCanBeMadeInitOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
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
        public double Amount { get; set; }

        /// <summary>
        /// Gets or sets the budget level.
        /// </summary>
        /// <value>
        /// The budget level.
        /// </value>
        public override string BudgetLevel { get; set; }

        /// <summary>
        /// Gets or sets the bfy.
        /// </summary>
        /// <value>
        /// The bfy.
        /// </value>
        public override string BFY { get; set; }

        /// <summary>
        /// Gets or sets the fund code.
        /// </summary>
        /// <value>
        /// The fund code.
        /// </value>
        public override string FundCode { get; set; }

        /// <summary>
        /// Gets or sets the rpio code.
        /// </summary>
        /// <value>
        /// The rpio code.
        /// </value>
        public override string RpioCode { get; set; }

        /// <summary>
        /// Gets or sets the ah code.
        /// </summary>
        /// <value>
        /// The ah code.
        /// </value>
        public override string AhCode { get; set; }

        /// <summary>
        /// Gets or sets the org code.
        /// </summary>
        /// <value>
        /// The org code.
        /// </value>
        public override string OrgCode { get; set; }

        /// <summary>
        /// Gets or sets the account code.
        /// </summary>
        /// <value>
        /// The account code.
        /// </value>
        public override string AccountCode { get; set; }

        /// <summary>
        /// Gets or sets the activity code.
        /// </summary>
        /// <value>
        /// The activity code.
        /// </value>
        public override string ActivityCode { get; set; }

        /// <summary>
        /// Gets or sets the rc code.
        /// </summary>
        /// <value>
        /// The rc code.
        /// </value>
        public override string RcCode { get; set; }

        /// <summary>
        /// Gets or sets the boc code.
        /// </summary>
        /// <value>
        /// The boc code.
        /// </value>
        public override string BocCode { get; set; }

        /// <summary>
        /// Gets or sets the activity code.
        /// </summary>
        /// <value>
        /// The activity code.
        /// </value>
        public override string ProgramProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the program area code.
        /// </summary>
        /// <value>
        /// The program area code.
        /// </value>
        public override string ProgramAreaCode { get; set; }

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
            BudgetLevel = Record[ $"{ Field.BudgetLevel }" ].ToString( );
            BFY = Record[ $"{ Field.BFY }" ].ToString( );
            RpioCode = Record[ $"{ Field.RpioCode }" ].ToString( );
            AhCode = Record[ $"{ Field.AhCode }" ].ToString( );
            FundCode = Record[ $"{ Field.FundCode }" ].ToString( );
            OrgCode = Record[ $"{ Field.OrgCode }" ].ToString( );
            RcCode = Record[ $"{ Field.RcCode }" ].ToString( );
            BocCode = Record[ $"{ Field.BocCode }" ].ToString( );
            AccountCode = Record[ $"{ Field.AccountCode }" ].ToString( );
            ActivityCode = Record[ $"{ Field.ActivityCode }" ].ToString( );
            Amount = double.Parse( Record[ $"{ Numeric.Amount }" ].ToString( ) );
            Data = Record?.ToDictionary( );
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
            BudgetLevel = Record?[ $"{ Field.BudgetLevel }" ].ToString( );
            BFY = Record?[ $"{ Field.BFY }" ].ToString( );
            RpioCode = Record?[ $"{ Field.RpioCode }" ].ToString( );
            AhCode = Record?[ $"{ Field.AhCode }" ].ToString( );
            FundCode = Record?[ $"{ Field.FundCode }" ].ToString( );
            OrgCode = Record?[ $"{ Field.OrgCode }" ].ToString( );
            RcCode = Record?[ $"{ Field.RcCode }" ].ToString( );
            BocCode = Record?[ $"{ Field.BocCode }" ].ToString( );
            AccountCode = Record?[ $"{ Field.AccountCode }" ].ToString( );
            ActivityCode = Record?[ $"{ Field.ActivityCode }" ].ToString( );
            Amount = double.Parse( Record[ $"{ Numeric.Amount }" ].ToString( ) );
            Data = Record?.ToDictionary( );
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
            BudgetLevel = dataRow[ $"{ Field.BudgetLevel }" ].ToString( );
            BFY = dataRow[ $"{ Field.BFY }" ].ToString( );
            RpioCode = dataRow[ $"{ Field.RpioCode }" ].ToString( );
            AhCode = dataRow[ $"{ Field.AhCode }" ].ToString( );
            FundCode = dataRow[ $"{ Field.FundCode }" ].ToString( );
            OrgCode = dataRow[ $"{ Field.OrgCode }" ].ToString( );
            RcCode = dataRow[ $"{ Field.RcCode }" ].ToString( );
            BocCode = dataRow[ $"{ Field.BocCode }" ].ToString( );
            AccountCode = dataRow[ $"{ Field.AccountCode }" ].ToString( );
            ActivityCode = dataRow[ $"{ Field.ActivityCode }" ].ToString( );
            Amount = double.Parse( Record[ $"{ Numeric.Amount }" ].ToString( ) );
            Data = Record?.ToDictionary( );
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
            BudgetLevel = Record[ $"{ Field.BudgetLevel }" ].ToString( );
            BFY = Record[ $"{ Field.BFY }" ].ToString( );
            RpioCode = Record[ $"{ Field.RpioCode }" ].ToString( );
            AhCode = Record[ $"{ Field.AhCode }" ].ToString( );
            FundCode = Record[ $"{ Field.FundCode }" ].ToString( );
            OrgCode = Record[ $"{ Field.OrgCode }" ].ToString( );
            RcCode = Record[ $"{ Field.RcCode }" ].ToString( );
            BocCode = Record[ $"{ Field.BocCode }" ].ToString( );
            AccountCode = Record[ $"{ Field.AccountCode }" ].ToString( );
            ActivityCode = Record[ $"{ Field.ActivityCode }" ].ToString( );
            Amount = double.Parse( Record[ $"{ Numeric.Amount }" ].ToString( ) );
            Data = Record?.ToDictionary( );
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