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
    using System.Windows.Forms;

    public abstract class BindingBase : BindingSource
    {
        /// <summary>
        /// Gets the data set.
        /// </summary>
        /// <value>
        /// The data set.
        /// </value>
        public virtual DataSet DataSet { get; set; }

        /// <summary>
        /// Gets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public virtual DataTable DataTable { get; set; }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public virtual Source Source { get; set; }

        /// <summary>
        /// Gets or sets the current.
        /// </summary>
        /// <value>
        /// The current.
        /// </value>
        public virtual DataRow Record { get; set; }

        /// <summary>
        /// Gets the index of the current.
        /// </summary>
        /// <value>
        /// The index of the current.
        /// </value>
        public virtual int Index { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public virtual Field Field { get; set; }

        /// <summary>
        /// Gets or sets the data filter.
        /// </summary>
        /// <value>
        /// The data filter.
        /// </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets the data filter.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual IDictionary<string, object> GetDataFilter( )
        {
            try
            {
                return DataFilter?.Any( ) == true
                    ? DataFilter
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );

                return default;
            }
        }

        /// <summary>
        /// Gets the data table.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual DataTable GetDataTable( )
        {
            try
            {
                return DataTable?.Rows?.Count > 0 && DataTable?.Columns?.Count > 0
                    ? DataTable
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );

                return default;
            }
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual IEnumerable<DataRow> GetData( )
        {
            try
            {
                var _dataRows = DataTable?.AsEnumerable( );

                return _dataRows?.Any( ) == true
                    ? _dataRows
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );

                return default;
            }
        }

        /// <summary>
        /// Gets the current row.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual DataRow GetCurrent( )
        {
            try
            {
                return Record?.ItemArray?.Length > 0
                    ? Record
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );

                return default;
            }
        }

        /// <summary>
        /// Gets the index of the current.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual int GetIndex( )
        {
            try
            {
                return Index > 0
                    ? Index
                    : -1;
            }
            catch( Exception ex )
            {
                Fail( ex );

                return default;
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
        protected void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}