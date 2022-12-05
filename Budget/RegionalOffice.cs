// <copyright file = "RegionalOffice.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.ResourcePlanningOffice" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class RegionalOffice : ResourcePlanningOffice
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionalOffice"/> class.
        /// </summary>
        public RegionalOffice( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionalOffice"/> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public RegionalOffice( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionalOffice"/> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public RegionalOffice( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RegionalOffice"/> class.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        public RegionalOffice( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
