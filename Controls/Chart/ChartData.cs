// <copyright file = "ChartData.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ChartData
    {
        public ChartData()
        {
        }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        public Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="bindingSource">The bindingsource.</param>
        public void SetDataSource<T1>( T1 bindingSource )
            where T1 : IBindingList
        {
            try
            {
                if( bindingSource is System.Windows.Forms.BindingSource binder
                    && binder?.DataSource != null )
                {
                    try
                    {
                        BindingSource.DataSource = binder.DataSource;
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="bindingList">The bindingsource.</param>
        /// <param name="dict">The dictionary.</param>
        public void SetDataSource<T1, T2>( T1 bindingList, T2 dict )
            where T1 : IBindingList
            where T2 : IDictionary<string, object>
        {
            try
            {
                if( Verify.IsBindable( bindingList )
                    && Verify.IsMap( dict ) )
                {
                    try
                    {
                        var _list = bindingList as System.Windows.Forms.BindingSource;
                        var _filter = string.Empty;

                        foreach( var _kvp in dict )
                        {
                            if( !string.IsNullOrEmpty( _kvp.Key )
                                && Verify.IsRef( _kvp.Value ) )
                            {
                                _filter += $"{_kvp.Key} = {_kvp.Value} AND";
                            }
                        }

                        if( _filter?.Length > 0
                            && _list?.DataSource != null )
                        {
                            BindingSource.DataSource = _list?.DataSource;
                            BindingSource.Filter = _filter?.TrimEnd( " AND".ToCharArray( ) );
                        }
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="data">The data.</param>
        public void SetDataSource<T1>( IEnumerable<T1> data )
            where T1 : IEnumerable<DataRow>
        {
            if( Verify.IsSequence( data ) )
            {
                try
                {
                    BindingSource.DataSource = data?.ToList( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="dict">The dictionary.</param>
        public void SetDataSource<T1>( IEnumerable<T1> data, IDictionary<string, object> dict )
            where T1 : IEnumerable<DataRow>
        {
            if( Verify.IsSequence( data ) )
            {
                try
                {
                    var _filter = string.Empty;

                    foreach( var _kvp in dict )
                    {
                        if( !string.IsNullOrEmpty( _kvp.Key )
                            && _kvp.Value != null )
                        {
                            _filter += $"{_kvp.Key} = {_kvp.Value} AND";
                        }
                    }

                    BindingSource.DataSource = data?.ToList( );
                    BindingSource.Filter = _filter.TrimEnd( " AND".ToCharArray( ) );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <typeparam name="T3">The type of the 3.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The dictionary.</param>
        public void SetDataSource<T1, T2, T3>( IEnumerable<T1> data, T2 field, T3 filter )
            where T1 : IEnumerable<DataRow>
            where T2 : struct
        {
            if( Verify.IsSequence( data )
                && Validate.IsField( field ) )
            {
                try
                {
                    if( !string.IsNullOrEmpty( filter?.ToString( ) ) )
                    {
                        BindingSource.DataSource = data.ToList( );
                        BindingSource.DataMember = field.ToString( );
                        BindingSource.Filter = $"{field} = {filter}";
                    }
                    else
                    {
                        BindingSource.DataSource = data.ToList( );
                        BindingSource.DataMember = field.ToString( );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        public void SetDataSource<T1>( IEnumerable<T1> data, object field = null )
            where T1 : IEnumerable<DataRow>
        {
            if( Verify.IsSequence( data ) )
            {
                try
                {
                    if( !string.IsNullOrEmpty( field?.ToString( ) ) )
                    {
                        BindingSource.DataSource = data.ToList( );
                        BindingSource.DataMember = field?.ToString( );
                    }
                    else
                    {
                        BindingSource.DataSource = data.ToList( );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the bindings.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param>The numeric.</param>
        /// <param name = "dict" > </param>
        public void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 dict )
            where T1 : IEnumerable<DataRow>
            where T2 : IDictionary<string, object>
        {
            if( Verify.IsSequence( data )
                && Verify.IsMap( dict ) )
            {
                try
                {
                    var _filter = string.Empty;

                    foreach( var _kvp in dict )
                    {
                        if( !string.IsNullOrEmpty( _kvp.Key )
                            && _kvp.Value != null )
                        {
                            _filter += $"{_kvp.Key} = {_kvp.Value} AND";
                        }
                    }

                    BindingSource.DataSource = data?.ToList( );
                    BindingSource.Filter = _filter?.TrimEnd( " AND".ToCharArray( ) );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The filter.</param>
        public void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 field, object filter = null )
            where T1 : IEnumerable<DataRow>
            where T2 : struct
        {
            if( Verify.IsSequence( data )
                && Validate.IsField( field ) )
            {
                try
                {
                    if( !string.IsNullOrEmpty( filter?.ToString( ) ) )
                    {
                        BindingSource.DataSource = data.ToList( );
                        BindingSource.DataMember = field.ToString( );
                        BindingSource.Filter = $"{field} = {filter}";
                    }
                    else
                    {
                        BindingSource.DataSource = data.ToList( );
                        BindingSource.DataMember = field.ToString( );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
        protected void Fail( Exception ex )
        {
            using( var _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}