// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;

    /// <summary>
    /// 
    /// </summary>
    public interface ICommandFactory
    {
        /// <summary>
        /// The command builder
        /// </summary>
        ICommandBuilder Command { get; }

        /// <summary>
        /// Gets the connection builder.
        /// </summary>
        /// <value>
        /// The connection builder.
        /// </value>
        IConnectionBuilder ConnectionBuilder { get; }

        /// <summary>
        /// Gets the SQL statement.
        /// </summary>
        /// <value>
        /// The SQL statement.
        /// </value>
        ISqlStatement SqlStatement { get; set; }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        Source Source { get; set; }

        /// <summary>
        /// Gets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        Provider Provider { get; set; }

        /// <summary>
        /// Gets the create table command.
        /// </summary>
        /// <param name="tableName">Name of the table.</param>
        /// <param name="dataColumns">The Data columns.</param>
        /// <returns></returns>
        DbCommand GetCreateTableCommand( string tableName, IEnumerable<DataColumn> dataColumns );

        /// <summary>
        /// Gets the create view command.
        /// </summary>
        /// <param name="viewName">Name of the view.</param>
        /// <param name="dataColumns">The Data columns.</param>
        /// <returns></returns>
        DbCommand GetCreateViewCommand( string viewName, IEnumerable<DataColumn> dataColumns );

        /// <summary>
        /// Gets the drop table command.
        /// </summary>
        /// <param name="dataTable">The Data table.</param>
        /// <returns></returns>
        DbCommand GetDropTableCommand( DataTable dataTable );

        /// <summary>
        /// Gets the alter command.
        /// </summary>
        /// <param name="dataTable">The Data table.</param>
        /// <param name="dataColumn">The Data column.</param>
        /// <returns></returns>
        DbCommand GetAddColumnCommand( DataTable dataTable, DataColumn dataColumn );

        /// <summary>
        /// Gets the alter command.
        /// </summary>
        /// <param name="dataTable">The Data table.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        DbCommand GetRenameTableCommand( DataTable dataTable, string name );

        /// <summary>
        /// Gets the select command.
        /// </summary>
        /// <returns></returns>
        string GetSelectCommand( );

        /// <summary>
        /// Gets the insert command.
        /// </summary>
        /// <returns></returns>
        string GetInsertCommand( );

        /// <summary>
        /// Gets the update command.
        /// </summary>
        /// <returns></returns>
        string GetUpdateCommand( );

        /// <summary>
        /// Gets the delete command.
        /// </summary>
        /// <returns></returns>
        string GetDeleteCommand( );
    }
}