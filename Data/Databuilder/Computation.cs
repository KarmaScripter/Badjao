// <copyright file = "Computation.cs" company = "Terry D. Eppler">
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
    public class Computation : DataModel, IDataFilter
    {
        /// <summary>
        /// Gets the Data.
        /// </summary>
        /// <value>
        /// The Data.
        /// </value>
        public IEnumerable<DataRow> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Computation"/> class.
        /// </summary>
        public Computation( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Computation"/> class.
        /// </summary>
        /// <param name = "data" >
        /// The Data.
        /// </param>
        public Computation( IDataAccess data )
        {
            Data = data.GetData( );
        }
    }
}