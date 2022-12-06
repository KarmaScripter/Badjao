// // <copyright file = "ISqlStatement.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public interface ISqlStatement
    {
        /// <summary>
        /// The extension
        /// </summary>
        EXT Extension { get; set; }

        /// <summary>
        /// The source
        /// </summary>
        Source Source { get; set; }

        /// <summary>
        /// The provider
        /// </summary>
        Provider Provider { get; set; }

        /// <summary>
        /// The command type
        /// </summary>
        SQL CommandType { get; set; }

        /// <summary>
        /// Gets or sets the command text.
        /// </summary>
        /// <value>
        /// The command text.
        /// </value>
        string CommandText { get; set; }

        /// <summary>
        /// The arguments
        /// </summary>
        IDictionary<string, object> Criteria { get; set; }

        /// <summary>
        /// Gets or sets the updates.
        /// </summary>
        /// <value>
        /// The updates.
        /// </value>
        IDictionary<string, object> Updates { get; set; }

        /// <summary>
        /// Gets or sets the columns.
        /// </summary>
        /// <value>
        /// The columns.
        /// </value>
        IEnumerable<string> Columns { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        string TableName { get; set; }

        /// <summary>
        /// The provider path
        /// </summary>
        string DbPath { get; set; }

        /// <summary>
        /// The file name
        /// </summary>
        string FileName { get; set; }

        /// <summary>
        /// Gets the update statement.
        /// </summary>
        /// <returns></returns>
        string GetUpdateQueryText( );

        /// <summary>
        /// Gets the insert statement.
        /// </summary>
        /// <returns></returns>
        string GetInsertQueryText( );

        /// <summary>
        /// Gets the delete statement.
        /// </summary>
        /// <returns></returns>
        string GetDeleteQueryText( );

        /// <summary>
        /// Gets the command text.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns></returns>
        string GetCommandText( IDictionary<string, object> dict, SQL commandType = SQL.SELECT );

        /// <summary>
        /// Gets the command text.
        /// </summary>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns></returns>
        string GetCommandText( IEnumerable<string> columns, IDictionary<string, object> where,
            SQL commandType = SQL.SELECT );

        /// <summary>
        /// Gets the command text.
        /// </summary>
        /// <param name = "updates" > </param>
        /// <param name = "where" > </param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns></returns>
        string GetCommandText( IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE );

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        string ToString( );

        /// <summary>
        /// Sets the select statement.
        /// </summary>
        string GetSelectStatement( );

        /// <summary>
        /// Sets the select statement.
        /// </summary>
        /// <param name="where">The dictionary.</param>
        string CreateSelectStatement( IDictionary<string, object> where );

        /// <summary>
        /// Gets the select statement.
        /// </summary>
        /// <param name="columnNames">The column names.</param>
        /// <param name="where">The dictionary.</param>
        /// <returns></returns>
        string CreateSelectStatement( IEnumerable<string> columnNames,
            IDictionary<string, object> where );

        /// <summary>
        /// Sets the update statement.
        /// </summary>
        /// <param name="updates">The dictionary.</param>
        /// <param name = "where" > </param>
        string CreateUpdateStatement( IDictionary<string, object> updates,
            IDictionary<string, object> where );

        /// <summary>
        /// Sets the insert statement.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        string CreateInsertStatement( IDictionary<string, object> dict );

        /// <summary>
        /// Sets the delete statement.
        /// </summary>
        /// <param name="where">The dictionary.</param>
        string CreateDeleteStatement( IDictionary<string, object> where );
    }
}