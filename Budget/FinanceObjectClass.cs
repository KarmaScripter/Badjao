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
    /// <seealso cref="IFinanceObjectClass" />
    /// <seealso cref="IProgram" />
    /// <seealso cref="ISource" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Local" ) ]
    [ SuppressMessage( "ReSharper", "UnassignedReadonlyField" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class FinanceObjectClass : Element, IFinanceObjectClass, ISource
    {
        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; } = Source.FinanceObjectClasses;

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
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
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Gets or sets the category.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public BOC Category { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceObjectClass"/> class.
        /// </summary>
        public FinanceObjectClass( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceObjectClass"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public FinanceObjectClass( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = GetId( Record, PrimaryKey.FinanceObjectClassesId );
            Name = Record[ $"{ Field.Name }" ].ToString( );
            Code = Record[ $"{ Field.Code }" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceObjectClass"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public FinanceObjectClass( IDataModel builder )
        {
            Record = builder?.Record;
            ID = GetId( Record, PrimaryKey.FinanceObjectClassesId );
            Name = Record[ $"{ Field.Name }" ].ToString( );
            Code = Record[ $"{ Field.Code }" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceObjectClass"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public FinanceObjectClass( DataRow dataRow )
        {
            Record = dataRow;
            ID = GetId( Record, PrimaryKey.FinanceObjectClassesId );
            Name = dataRow[ $"{ Field.Name }" ].ToString( );
            Code = dataRow[ $"{ Field.Code }" ].ToString( );
            Data = dataRow?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinanceObjectClass"/> class.
        /// </summary>
        /// <param name="focCode">The foc code.</param>
        public FinanceObjectClass( string focCode )
        {
            Record = new DataBuilder( Source, GetArgs( focCode ) )?.Record;
            ID = GetId( Record, PrimaryKey.FinanceObjectClassesId );
            Name = Record[ $"{ Field.Name }" ].ToString( );
            Code = Record[ $"{ Field.Code }" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <param name="code">The code.</param>
        /// <returns></returns>
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
        /// <returns></returns>
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
        /// Gets the finance object class.
        /// </summary>
        /// <returns></returns>
        public IFinanceObjectClass GetFinanceObjectClass( )
        {
            try
            {
                return MemberwiseClone( ) as FinanceObjectClass;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( FinanceObjectClass );
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