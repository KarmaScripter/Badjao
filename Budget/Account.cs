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

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public class Account : AccountBase, IAccount, ISource
    {
        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; set; } = Source.Accounts;

        /// <summary>
        /// Initializes a new instance of the <see cref = "Account"/> class.
        /// </summary>
        public Account( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Account"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public Account( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = new Key( Record, PrimaryKey.AccountsId );
            Code = new Element( Record, Field.Code ).Code;
            NpmCode = new Element( Record, Field.NpmCode );
            ProgramProjectCode = new Element( Record, Field.ProgramProjectCode );
            ProgramAreaCode = new Element( Record, Field.ProgramAreaCode );
            GoalCode = new Element( Record, Field.GoalCode );
            ObjectiveCode = new Element( Record, Field.ObjectiveCode );
            ActivityCode = new Element( Record, Field.ActivityCode );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Account"/> class.
        /// </summary>
        /// <param name = "dataBuilder" >
        /// The dataBuilder.
        /// </param>
        public Account( IDataModel dataBuilder )
        {
            Record = dataBuilder?.Record;
            ID = new Key( Record, PrimaryKey.AccountsId );
            Code = new Element( Record, Field.Code ).Code;
            NpmCode = new Element( Record, Field.NpmCode );
            ProgramProjectCode = new Element( Record, Field.ProgramProjectCode );
            ProgramAreaCode = new Element( Record, Field.ProgramAreaCode );
            GoalCode = new Element( Record, Field.GoalCode );
            ObjectiveCode = new Element( Record, Field.ObjectiveCode );
            ActivityCode = new Element( Record, Field.ActivityCode );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Account"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        public Account( DataRow dataRow )
        {
            Record = dataRow;
            ID = new Key( Record, PrimaryKey.AccountsId );
            Code = new Element( Record, Field.Code ).Code;
            NpmCode = new Element( Record, Field.NpmCode );
            ProgramProjectCode = new Element( Record, Field.ProgramProjectCode );
            ProgramAreaCode = new Element( Record, Field.ProgramAreaCode );
            GoalCode = new Element( Record, Field.GoalCode );
            ObjectiveCode = new Element( Record, Field.ObjectiveCode );
            ActivityCode = new Element( Record, Field.ActivityCode );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Account"/> class.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        public Account( string code )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            ID = new Key( Record, PrimaryKey.AccountsId );
            Code = new Element( Record, Field.Code ).Code;
            NpmCode = new Element( Record, Field.NpmCode );
            ProgramProjectCode = new Element( Record, Field.ProgramProjectCode );
            ProgramAreaCode = new Element( Record, Field.ProgramAreaCode );
            GoalCode = new Element( Record, Field.GoalCode );
            ObjectiveCode = new Element( Record, Field.ObjectiveCode );
            ActivityCode = new Element( Record, Field.ActivityCode );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Gets the account.
        /// </summary>
        /// <returns>
        /// </returns>
        public IAccount GetAccount( )
        {
            try
            {
                return (Account)MemberwiseClone( );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IAccount );
            }
        }

        /// <summary>
        /// Gets the activity
        /// </summary>
        /// <returns>
        /// </returns>
        public IActivity GetActivity( )
        {
            if( !string.IsNullOrEmpty( ActivityCode?.Value.ToString( ) ) )
            {
                try
                {
                    var _dictionary = new Dictionary<string, object>
                    {
                        [ $"{Field.ActivityCode}" ] = ActivityCode.Value
                    };

                    var _connection =
                        new ConnectionBuilder( Source.ActivityCodes, Provider.SQLite );

                    var _statement = new SqlStatement( Source.Goals, Provider.SQLite, _dictionary,
                        SQL.SELECT );

                    using var _query = new Query( _statement );
                    return new Activity( _query ) ?? default( Activity );
                }
                catch( SystemException ex )
                {
                    Fail( ex );
                    return default( IActivity );
                }
            }

            return default( IActivity );
        }

        /// <summary>
        /// Gets the national program code.
        /// </summary>
        /// <returns>
        /// </returns>
        public INationalProgram GetNationalProgram( )
        {
            try
            {
                var _dictionary = new Dictionary<string, object>
                {
                    [ $"{Field.NpmCode}" ] = NpmCode
                };

                var _connection = new ConnectionBuilder( Source.NationalPrograms, Provider.SQLite );
                var _statement = new SqlStatement( Source.Goals, Provider.SQLite, _dictionary,
                    SQL.SELECT );

                using var _query = new Query( _statement );
                return new NationalProgram( _query ) ?? default( NationalProgram );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( INationalProgram );
            }
        }

        /// <summary>
        /// Gets the goal code.
        /// </summary>
        /// <returns>
        /// </returns>
        public IGoal GetGoal( )
        {
            try
            {
                var _dictionary = new Dictionary<string, object> { [ $"{Field.Code}" ] = GoalCode };
                var _connection = new ConnectionBuilder( Source.Goals, Provider.SQLite );
                var _statement = new SqlStatement( Source.Goals, Provider.SQLite, _dictionary,
                    SQL.SELECT );

                using var _query = new Query( _statement );
                return new Goal( _query ) ?? default( Goal );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IGoal );
            }
        }

        /// <summary>
        /// Gets the objective code.
        /// </summary>
        /// <returns>
        /// </returns>
        public IObjective GetObjective( )
        {
            try
            {
                var _dictionary = new Dictionary<string, object>
                {
                    [ $"{Field.Code}" ] = ObjectiveCode
                };

                var _statement = new SqlStatement( Source.Objectives, Provider.SQLite, _dictionary,
                    SQL.SELECT );

                using var _query = new Query( _statement );
                return new Objective( _query ) ?? default( Objective );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IObjective );
            }
        }

        /// <summary>
        /// Gets the program project code.
        /// </summary>
        /// <returns>
        /// </returns>
        public IProgramProject GetProgramProject( )
        {
            try
            {
                var _dictionary = new Dictionary<string, object>
                {
                    [ $"{Field.Code}" ] = ProgramProjectCode
                };

                var _statement = new SqlStatement( Source.ProgramProjects, Provider.SQLite,
                    _dictionary, SQL.SELECT );

                using var _query = new Query( _statement );
                return new ProgramProject( _query ) ?? default( ProgramProject );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IProgramProject );
            }
        }

        /// <summary>
        /// Gets the program area code.
        /// </summary>
        /// <returns>
        /// </returns>
        public IProgramArea GetProgramArea( )
        {
            try
            {
                var _dictionary = new Dictionary<string, object>
                {
                    [ $"{Field.Code}" ] = ProgramAreaCode
                };

                var _statement = new SqlStatement( Source.ProgramAreas, Provider.SQLite,
                    _dictionary, SQL.SELECT );

                using var _query = new Query( _statement );
                return new ProgramArea( _query ) ?? default( ProgramArea );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IProgramArea );
            }
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
                    : default( IDictionary<string, object> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, object> );
            }
        }
    }
}