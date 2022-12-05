// <copyright file = "Element.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
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
    /// <seealso cref="IElement" />
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public class Element : DataUnit, IElement
    {
        /// <summary>
        /// Gets the code.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual string Code { get; set; }

        /// <summary>
        /// The initial
        /// </summary>
        public virtual string Initial { get; set; }

        /// <summary>
        /// The default
        /// </summary>
        public static readonly IElement Default = new Element( );

        /// <summary>
        /// Initializes a new instance of the <see cref="Element"/> class.
        /// </summary>
        public Element( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Element"/> class.
        /// </summary>
        /// <param name="kvp">The KVP.</param>
        public Element( KeyValuePair<string, object> kvp )
        {
            Field = (Field)Enum.Parse( typeof( Field ), kvp.Key );
            Name = kvp.Key;
            Value = kvp.Value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Element"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="columnName">The value.</param>
        public Element( string name, string columnName = "" )
        {
            Field = (Field)Enum.Parse( typeof( Field ), name );
            Name = name;
            Value = columnName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Element"/> class.
        /// </summary>
        /// <param name="dataRow">The Data row.</param>
        /// <param name="field">The field.</param>
        public Element( DataRow dataRow, Field field )
        {
            Field = field;
            Name = field.ToString( );
            Value = dataRow[ field.ToString( ) ];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Element"/> class.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <param name="columnName">The value.</param>
        public Element( Field field, string columnName = "" )
        {
            Field = field;
            Name = field.ToString( );
            Value = columnName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Element"/> class.
        /// </summary>
        /// <param name="dataRow">The Data row.</param>
        /// <param name="columnName">The value.</param>
        public Element( DataRow dataRow, string columnName )
        {
            Name = dataRow[ columnName ].ToString( );
            Value = dataRow[ columnName ];
            if( !string.IsNullOrEmpty( Name ) )
            {
                Field = (Field)Enum.Parse( typeof( Field ), Name );
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Element"/> class.
        /// </summary>
        /// <param name="dataRow">The Data row.</param>
        /// <param name="dataColumn">The Data column.</param>
        public Element( DataRow dataRow, DataColumn dataColumn )
        {
            Field = (Field)Enum.Parse( typeof( Field ), dataColumn.ColumnName );
            Name = dataColumn.ColumnName;
            Value = dataRow[ dataColumn ];
        }

        /// <summary>
        /// Determines whether the specified element is match.
        /// </summary>
        /// <param name="dataUnit">The element.</param>
        /// <returns>
        ///   <c>true</c> if the specified element is match; otherwise, <c>false</c>.
        /// </returns>
        public override bool IsMatch( IDataUnit dataUnit )
        {
            if( dataUnit != null )
            {
                try
                {
                    if( dataUnit.Value?.Equals( Value ) == true )
                    {
                        return true;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified primary is match.
        /// </summary>
        /// <param name="primary">The primary.</param>
        /// <param name="secondary">The secondary.</param>
        /// <returns>
        ///   <c>true</c> if the specified primary is match; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsMatch( IElement primary, IElement secondary )
        {
            try
            {
                if( primary.Value.Equals( secondary.Value )
                   && primary.Name.Equals( secondary.Name ) )
                {
                    return true;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
                return false;
            }

            return false;
        }

        /// <summary>
        /// Sets the columnName.
        /// </summary>
        /// <param name = "dataRow" > </param>
        /// <param name = "columnName" > </param>
        protected virtual void SetName( DataRow dataRow, string columnName )
        {
            if( dataRow != null
               && !string.IsNullOrEmpty( columnName )
               && Enum.GetNames( typeof( Field ) )?.Contains( columnName ) == true )
            {
                try
                {
                    var _names = dataRow.Table?.GetColumnNames( );
                    Name = _names?.Contains( columnName ) == true
                        ? columnName
                        : dataRow.Table.TableName;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the columnName.
        /// </summary>
        /// <param name = "field" > </param>
        protected virtual void SetName( Field field )
        {
            if( Enum.IsDefined( typeof( Field ), field ) )
            {
                try
                {
                    Name = Enum.IsDefined( typeof( Field ), field )
                        ? field.ToString( )
                        : string.Empty;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the columnName.
        /// </summary>
        /// <param name = "dataRow" > </param>
        /// <param name = "field" > </param>
        protected virtual void SetName( DataRow dataRow, Field field )
        {
            if( dataRow != null
               && Enum.IsDefined( typeof( Field ), field ) )
            {
                try
                {
                    var _columnNames = dataRow.Table?.GetColumnNames( );
                    Name = _columnNames?.Contains( field.ToString( ) ) == true
                        ? field.ToString( )
                        : dataRow.Table.TableName;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name = "fieldName" > </param>
        protected virtual void SetField( string fieldName )
        {
            if( !string.IsNullOrEmpty( fieldName )
               && Enum.GetNames( typeof( Field ) )?.Contains( fieldName ) == true )
            {
                try
                {
                    var _input = (Field)Enum.Parse( typeof( Field ), fieldName );
                    Field = !Enum.IsDefined( typeof( Field ), _input )
                        ? (Field)Enum.Parse( typeof( Field ), fieldName )
                        : default( Field );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name = "dataRow" > </param>
        /// <param name = "fieldName" > </param>
        protected virtual void SetField( DataRow dataRow, string fieldName )
        {
            if( dataRow != null
               && !string.IsNullOrEmpty( fieldName )
               && Enum.GetNames( typeof( Field ) )?.Contains( fieldName ) == true )
            {
                try
                {
                    var _input = (Field)Enum.Parse( typeof( Field ), fieldName );
                    var _names = dataRow.Table?.GetColumnNames( );
                    if( _names?.Any( ) == true
                       && _names?.Contains( $" {_input}" ) == true )
                    {
                        Field = (Field)Enum.Parse( typeof( Field ), fieldName );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name = "field" > </param>
        protected virtual void SetField( Field field )
        {
            try
            {
                Field = Enum.IsDefined( typeof( Field ), field )
                    ? field
                    : default( Field );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name = "dataRow" > </param>
        /// <param name = "field" > </param>
        protected virtual void SetField( DataRow dataRow, Field field )
        {
            if( dataRow != null
               && dataRow.ItemArray.Length > 0
               && Enum.IsDefined( typeof( Field ), field ) )
            {
                try
                {
                    var _names = dataRow.Table?.GetColumnNames( );
                    Field = _names?.Contains( field.ToString( ) ) == true
                        ? field
                        : default( Field );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name = "value" > </param>
        protected virtual void SetValue( object value )
        {
            try
            {
                if( !string.IsNullOrEmpty( value?.ToString( ) ) )
                {
                    Value = value;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name = "dataRow" > </param>
        /// <param name = "columnName" > </param>
        protected virtual void SetValue( DataRow dataRow, string columnName )
        {
            if( dataRow != null
               && !string.IsNullOrEmpty( columnName )
               && Enum.GetNames( typeof( Field ) ).Contains( columnName ) )
            {
                try
                {
                    var _names = dataRow.Table?.GetColumnNames( );
                    Value = _names?.Contains( columnName ) == true
                        ? dataRow[ columnName ]?.ToString( )
                        : string.Empty;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name = "dataRow" > </param>
        /// <param name = "field" > </param>
        protected virtual void SetValue( DataRow dataRow, Field field )
        {
            if( dataRow != null
               && Enum.IsDefined( typeof( Field ), field ) )
            {
                try
                {
                    var _names = dataRow.Table?.GetColumnNames( );
                    Value = _names?.Contains( field.ToString( ) ) == true
                        ? dataRow[ $"{ field }" ]?.ToString( )
                        : string.Empty;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <returns></returns>
        protected virtual int GetId( DataRow dataRow )
        {
            if( dataRow != null)
            {
                return int.Parse( dataRow[ 0 ].ToString( ) );
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        protected virtual int GetId( DataRow dataRow, PrimaryKey primaryKey )
        {
            if( dataRow != null
               && Enum.IsDefined( typeof( PrimaryKey ), primaryKey ) )
            {
                return int.Parse( dataRow[ $"{ primaryKey }" ].ToString( ) );
            }
            else
            {
                return -1;
            }
        }
    }
}