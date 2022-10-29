// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ICommandBuilder" />
    public class CommandBuilder : CommandBase, ICommandBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBuilder"/> class.
        /// </summary>
        public CommandBuilder( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBuilder"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        /// <param name="commandType">Type of the command.</param>
        public CommandBuilder( Source source, Provider provider, string sqlText,
            SQL commandType )
            : base( source, provider, sqlText, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBuilder"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where">The dictionary.</param>
        /// <param name = "commandType" > </param>
        public CommandBuilder( Source source, Provider provider, IDictionary<string, object> where,
            SQL commandType = SQL.SELECTALL )
            : base( source, provider, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBuilder"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="updates">The updates.</param>
        /// <param name="where">The criteria.</param>
        /// <param name = "commandType" > </param>
        public CommandBuilder( Source source, Provider provider,
            IDictionary<string, object> updates, IDictionary<string, object> where,
            SQL commandType = SQL.UPDATE )
            : base( source, provider, updates, where, commandType )
        {
        }

        public CommandBuilder( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
            : base( source, provider, columns, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandBuilder"/> class.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        public CommandBuilder( ISqlStatement sqlStatement )
            : base( sqlStatement )
        {
        }
    }
}