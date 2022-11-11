﻿// <copyright file = "AccountBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
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
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Global" ) ]
    public abstract class AccountBase : Element
    {
        /// <summary>
        /// Gets the Data.
        /// </summary>
        /// <value>
        /// The Data.
        /// </value>
        public DataRow Record { get; set; }
        
        /// <summary>
        /// Gets the NPM code.
        /// </summary>
        /// <value>
        /// The NPM code.
        /// </value>
        public IElement NpmCode { get; set; }
        
        /// <summary>
        /// Gets the program project code.
        /// </summary>
        /// <value>
        /// The program project code.
        /// </value>
        public IElement ProgramProjectCode { get; set; }

        /// <summary>
        /// Gets the program area code.
        /// </summary>
        /// <value>
        /// The program area code.
        /// </value>
        public IElement ProgramAreaCode { get; set; }

        /// <summary>
        /// Gets the goal code.
        /// </summary>
        /// <value>
        /// The goal code.
        /// </value>
        public IElement GoalCode { get; set; }

        /// <summary>
        /// Gets the objective code.
        /// </summary>
        /// <value>
        /// The objective code.
        /// </value>
        public IElement ObjectiveCode { get; set; }

        /// <summary>
        /// Gets the activity code.
        /// </summary>
        /// <value>
        /// The activity code.
        /// </value>
        public IElement ActivityCode { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public IDictionary<string, object> Data { get; set; }
        
        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        /// <returns>
        /// </returns>
        private protected IDictionary<string, object> GetArgs( string code )
        {
            if( !string.IsNullOrEmpty( code ) )
            {
                try
                {
                    return new Dictionary<string, object>
                    {
                        [ $"{ Field.Code }" ] = code
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
        /// Gets the account identifier.
        /// </summary>
        /// <returns>
        /// </returns>
        public IKey GetId()
        {
            try
            {
                return ID.Index > 0
                    ? ID
                    : default( IKey );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IKey );
            }
        }
    }
}