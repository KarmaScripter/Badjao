// <copyright file = "BudgetDocument.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class BudgetDocument
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetDocument" /> class.
        /// </summary>
        public BudgetDocument( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetDocument" /> class.
        /// </summary>
        /// <param name="query">The query.</param>
        public BudgetDocument( IQuery query )
        {
            Record = new DataBuilder( query ).Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetDocument" /> class.
        /// </summary>
        /// <param name="builder">The builder.</param>
        public BudgetDocument( IDataModel builder )
        {
            Record = builder.Record;
            Data = Record.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetDocument" /> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        public BudgetDocument( DataRow dataRow )
        {
            Record = dataRow;
            Data = dataRow.ToDictionary( );
        }
    }
}
