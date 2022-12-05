// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetExecution.IBudgetLevel" />
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class BudgetLevel : IBudgetLevel
    {
        /// <summary>
        /// Gets the level.
        /// </summary>
        /// <value>
        /// The level.
        /// </value>
        public Level Level { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the code.
        /// </summary>
        /// <value>
        /// The code.
        /// </value>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetLevel" /> class.
        /// </summary>
        public BudgetLevel( )
        {
            Level = Level.BudgetObjectClass;
            Code = ( (int)Level ).ToString( );
            Name = Level.ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetLevel" /> class.
        /// </summary>
        /// <param name="budgetLevel">The budgetLevel.</param>
        public BudgetLevel( string budgetLevel )
        {
            Level = GetLevel( budgetLevel );
            Code = ( (int)Level ).ToString( );
            Name = Level.ToString( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetLevel" /> class.
        /// </summary>
        /// <param name="level">The level.</param>
        private BudgetLevel( Level level )
        {
            Level = level;
            Code = ( (int)Level ).ToString( );
            Name = Level.ToString(  );
        }

        /// <summary>
        /// Gets the level number.
        /// </summary>
        /// <returns></returns>
        public int GetNumber( )
        {
            try
            {
                return Enum.IsDefined( typeof( Level ), Level.ToString( ) )
                    ? (int)Enum.Parse( typeof( Level ), Level.ToString( ) )
                    : (int)Level.BudgetObjectClass;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( int );
            }
        }

        /// <summary>
        /// Gets the name of the level.
        /// </summary>
        /// <returns></returns>
        public string GetName( )
        {
            try
            {
                return !string.IsNullOrEmpty( Name )
                    ? Name
                    : default( string );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// Gets the level.
        /// </summary>
        /// <returns></returns>
        public Level GetLevel( )
        {
            try
            {
                return Enum.IsDefined( typeof( Level ), Level )
                    ? Level
                    : Level.Treasury;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( Level );
            }
        }

        /// <summary>
        /// Gets the level.
        /// </summary>
        /// <param name="budgetLevel">The budgetLevel.</param>
        /// <returns></returns>
        private Level GetLevel( string budgetLevel )
        {
            try
            {
                return !string.IsNullOrEmpty( budgetLevel ) && int.Parse( budgetLevel ) < 9
                    && int.Parse( budgetLevel ) > 6
                    && !Enum.IsDefined( typeof( Level ), int.Parse( budgetLevel ) )
                        ? (Level)Enum.Parse( typeof( Level ), budgetLevel )
                        : Level.Treasury;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( Level );
            }
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString( )
        {
            try
            {
                return !string.IsNullOrEmpty( Code )
                    ? Code
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Converts to dictionary.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, object> ToDictionary( )
        {
            if( Enum.IsDefined( typeof( Level ), Level )
               && !string.IsNullOrEmpty( Code )
               && !string.IsNullOrEmpty( Name ) )
            {
                try
                {
                    return new Dictionary<string, object>( )
                    {
                        [ $"{ Level }" ] = Level.ToString( ),
                        [ $"{ Code }" ] = Code,
                        [ $"{ Name }" ] = Name
                    };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
        }

        /// <summary>
        /// Gets the budget level.
        /// </summary>
        /// <returns></returns>
        public BudgetLevel GetBudgetLevel( )
        {
            try
            {
                return (BudgetLevel)MemberwiseClone( );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BudgetLevel );
            }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <returns></returns>
        public int GetId( DataRow dataRow )
        {
            try
            {
                return dataRow != null
                    ? int.Parse( dataRow[ 0 ].ToString(  ) )
                    : -1;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( int );
            }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="primaryKey">The primary key.</param>
        /// <returns></returns>
        public int GetId( DataRow dataRow, PrimaryKey primaryKey )
        {
            try
            {
                return Enum.IsDefined( typeof( PrimaryKey ), primaryKey ) && dataRow != null
                    ? int.Parse( dataRow[ $"{ primaryKey }" ].ToString(  ) )
                    : -1;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( int );
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private protected static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}