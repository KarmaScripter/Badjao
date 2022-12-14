// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    public static class BindingSourceExtensions
    {
        /// <summary>
        /// Gets the rows.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <returns></returns>
        public static IEnumerable<DataRow> GetRows( this BindingSource bindingSource )
        {
            if( bindingSource.DataSource != null )
            {
                var _table = bindingSource.DataSource as DataTable;
                return _table?.Rows?.Count > 0
                    ? _table.AsEnumerable( )
                    : default( IEnumerable<DataRow> );
            }

            return default;
        }

        /// <summary>
        /// Gets the data table.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <returns></returns>
        public static DataTable GetDataTable( this BindingSource bindingSource )
        {
            if( bindingSource.DataSource != null )
            {
                switch( bindingSource.DataSource )
                {
                    case DataTable _table:
                    {
                        return _table;
                    }
                    case IEnumerable<DataRow> _data:
                    {
                        return _data.CopyToDataTable( );
                    }
                }
            }

            return default;
        }
    }
}