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
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Local" ) ]
    public class Fund : Element, IFund, ISource
    {
        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; set; } = Source.Funds;

        /// <summary>
        /// Gets the Data.
        /// </summary>
        /// <value>
        /// The Data.
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
        /// Gets the treasury symbol.
        /// </summary>
        /// <value>
        /// The treasury symbol.
        /// </value>
        public IElement TreasurySymbol { get; set; }

        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public IElement Title { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Fund"/> class.
        /// </summary>
        public Fund( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Fund"/> class.
        /// </summary>
        /// <param name = "fundCode" >
        /// The fundCode.
        /// </param>
        public Fund( FundCode fundCode )
        {
            Record = new DataBuilder( Source, GetArgs( fundCode ) )?.Record;
            ID = new Key( Record, PrimaryKey.FundsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Title = new Element( Record, Field.Title );
            TreasurySymbol = new Element( Record, Field.TreasurySymbol );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Fund"/> class.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        public Fund( string code )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            ID = new Key( Record, PrimaryKey.FundsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Title = new Element( Record, Field.Title );
            TreasurySymbol = new Element( Record, Field.TreasurySymbol );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Fund"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public Fund( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = new Key( Record, PrimaryKey.FundsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Title = new Element( Record, Field.Title );
            TreasurySymbol = new Element( Record, Field.TreasurySymbol );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Fund"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public Fund( IDataModel builder )
        {
            Record = builder?.Record;
            ID = new Key( Record, PrimaryKey.FundsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Title = new Element( Record, Field.Title );
            TreasurySymbol = new Element( Record, Field.TreasurySymbol );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Fund"/> class.
        /// </summary>
        /// <param name = "data" >
        /// The Data.
        /// </param>
        public Fund( DataRow data )
            : this( )
        {
            Record = data;
            ID = new Key( Record, PrimaryKey.FundsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Title = new Element( Record, Field.Title );
            TreasurySymbol = new Element( Record, Field.TreasurySymbol );
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

        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name = "fundCode" >
        /// The fundCode.
        /// </param>
        /// <returns>
        /// </returns>
        private IDictionary<string, object> GetArgs( string fundCode )
        {
            if( !string.IsNullOrEmpty( fundCode )
               && fundCode.Length < 5 )
            {
                try
                {
                    return new Dictionary<string, object> { [ Field.Code.ToString( ) ] = fundCode };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return new Dictionary<string, object> { [ Field.Name.ToString( ) ] = fundCode };
                }
            }

            if( !string.IsNullOrEmpty( fundCode )
               && fundCode.Length > 5 )
            {
                try
                {
                    return new Dictionary<string, object> { [ Field.Name.ToString( ) ] = fundCode };
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
        /// Sets the arguments.
        /// </summary>
        /// <param name = "fundCode" >
        /// The fundCode.
        /// </param>
        /// <returns>
        /// </returns>
        private IDictionary<string, object> GetArgs( FundCode fundCode )
        {
            try
            {
                return Enum.IsDefined( typeof( FundCode ), fundCode )
                    ? new Dictionary<string, object> { [ "FundCode" ] = fundCode.ToString( ) }
                    : default;
            }
            catch( SystemException ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the fund title.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetTitle( )
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
        /// Gets the treasury symbol.
        /// </summary>
        /// <returns>
        /// </returns>
        public IElement GetTreasurySymbol( )
        {
            try
            {
                return TreasurySymbol ?? default( IElement );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Default;
            }
        }

        /// <summary>
        /// Gets the fund.
        /// </summary>
        /// <returns>
        /// </returns>
        public IFund GetFund( )
        {
            try
            {
                return MemberwiseClone( ) as Fund;
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