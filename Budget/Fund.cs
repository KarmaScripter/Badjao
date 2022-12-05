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
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
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
        /// Gets the treasury symbol.
        /// </summary>
        /// <value>
        /// The treasury symbol.
        /// </value>
        public string TreasurySymbol { get; set; }

        /// <summary>
        /// Gets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

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
            ID = GetId( Record, PrimaryKey.FundsId );
            Name = Record[ $"{ Field.Name }" ].ToString( );
            Code = Record[ $"{ Field.Code }" ].ToString( );
            Title = Record[ $"{ Field.Title }" ].ToString( );
            TreasurySymbol = Record[ $"{ Field.TreasurySymbol }" ].ToString( );
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
            ID = GetId( Record, PrimaryKey.FundsId );
            Name = Record[ $"{ Field.Name }" ].ToString( );
            Code = Record[ $"{ Field.Code }" ].ToString( );
            Title = Record[ $"{ Field.Title }" ].ToString( );
            TreasurySymbol = Record[ $"{ Field.TreasurySymbol }" ].ToString( );
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
            ID = GetId( Record, PrimaryKey.FundsId );
            Name = Record[ $"{ Field.Name }" ].ToString( );
            Code = Record[ $"{ Field.Code }" ].ToString( );
            Title = Record[ $"{ Field.Title }" ].ToString( );
            TreasurySymbol = Record[ $"{ Field.TreasurySymbol }" ].ToString( );
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
            ID = GetId( Record, PrimaryKey.FundsId );
            Name = Record[ $"{ Field.Name }" ].ToString( );
            Code = Record[ $"{ Field.Code }" ].ToString( );
            Title = Record[ $"{ Field.Title }" ].ToString( );
            TreasurySymbol = Record[ $"{ Field.TreasurySymbol }" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Fund"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The Data.
        /// </param>
        public Fund( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            ID = GetId( dataRow, PrimaryKey.FundsId );
            Name = dataRow[ $"{ Field.Name }" ].ToString( );
            Code = dataRow[ $"{ Field.Code }" ].ToString( );
            Title = dataRow[ $"{ Field.Title }" ].ToString( );
            TreasurySymbol = dataRow[ $"{ Field.TreasurySymbol }" ].ToString( );
            Data = dataRow?.ToDictionary( );
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
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
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
                    : default( Dictionary<string, object> );
            }
            catch( SystemException ex )
            {
                Fail( ex );
                return default( IDictionary<string, object> );
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
                return default( IFund );
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