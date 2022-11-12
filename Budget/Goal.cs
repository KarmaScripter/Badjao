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
    using BudgetExecution.Budget;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref = "IGoal"/>
    /// <seealso cref = "IProgram"/>
    /// <seealso cref = "ISource"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public class Goal : Element, IGoal, ISource
    {
        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; set; } = Source.Goals;

        /// <summary>
        /// Gets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public IDictionary<string, object> Data { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Goal"/> class.
        /// </summary>
        public Goal( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Goal"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public Goal( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = new Key( Record, PrimaryKey.GoalsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Goal"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public Goal( IDataModel builder )
        {
            Record = builder?.Record;
            ID = new Key( Record, PrimaryKey.GoalsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "Goal"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        public Goal( DataRow dataRow )
        {
            Record = dataRow;
            ID = new Key( Record, PrimaryKey.GoalsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Goal"/> class.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        public Goal( string code )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            ID = new Key( Record, PrimaryKey.GoalsId );
            Name = new Element( Record, Field.Name ).Name;
            Code = new Element( Record, Field.Code ).Code;
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Converts to dictionary.
        /// </summary>
        /// <returns>
        /// </returns>
        public IDictionary<string, object> ToDictionary( )
        {
            try
            {
                return Data?.Any( ) == true
                    ? Data
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        /// <returns>
        /// </returns>
        private IDictionary<string, object> GetArgs( string code )
        {
            if( !string.IsNullOrEmpty( code ) )
            {
                try
                {
                    return new Dictionary<string, object> { [ $"{Field.Code}" ] = code };
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name = "goal" >
        /// The goal.
        /// </param>
        /// <returns>
        /// </returns>
        public IDictionary<string, object> GetArgs( int goal )
        {
            if( goal > 0
               && goal < 5 )
            {
                try
                {
                    return new Dictionary<string, object> { [ "Code" ] = goal.ToString( ) };
                }
                catch( SystemException ex )
                {
                    Fail( ex );
                    return default;
                }
            }

            return default;
        }

        /// <summary>
        /// Gets the goal.
        /// </summary>
        /// <returns>
        /// </returns>
        public IGoal GetGoal( )
        {
            try
            {
                return MemberwiseClone( ) as Goal;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default;
            }
        }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <returns>
        /// </returns>
        public Source GetSource( )
        {
            try
            {
                return Enum.IsDefined( typeof( Source ), Source )
                    ? Source
                    : Source.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Source.NS;
            }
        }
    }
}