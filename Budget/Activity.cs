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
    /// Generally, an organized set of activities directed toward a common purpose or
    /// goal that an agency undertakes or proposes to carry out its responsibilities.
    /// Because the term has many uses in practice, it does not have a well-defined,
    /// standard meaning in the legislative process. It is used to describe an agency’s
    /// mission, functions, activities, services, projects, and processes. An element
    /// within a budget account. For annually appropriated accounts, the Office of
    /// Management and Budget (OMB) and agencies identify PPAs by reference to
    /// committee reports and budget justifications; for permanent appropriations, OMB
    /// and agencies identify an ActivityCodes by the program and financing schedules that
    /// the President provides in the “Detailed Budget Estimates” in the budget
    /// submission for the relevant fiscal year. Program activity structures are
    /// intended to provide a meaningful representation of the operations financed by a
    /// specific budget account—usually by project, activity, or organization.
    /// </summary>
    /// <seealso cref = "IActivity"/>
    /// <seealso cref = "IProgram"/>
    /// <seealso cref = "ISource"/>
    /// <seealso cref = "IActivity"/>
    /// <seealso cref = "IDataModel"/>
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Local" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class Activity : Element, IActivity, ISource
    {
        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; } = Source.ActivityCodes;

        /// <summary>
        /// Gets the dataRow.
        /// </summary>
        /// <value>
        /// The dataRow.
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
        /// Initializes a new instance of the <see cref = "Activity"/> class.
        /// </summary>
        private Activity( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Activity"/> class.
        /// </summary>
        /// <param name = "query" >
        /// The query.
        /// </param>
        public Activity( IQuery query )
        {
            Record = new DataBuilder( query )?.Record;
            ID = new Key( Record, PrimaryKey.ActivityCodesId );
            Name = Record[ $"{ Field.ActivityName }" ].ToString( );
            Code = Record[ $"{ Field.ActivityCode }" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Activity"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The builder.
        /// </param>
        public Activity( IDataModel builder )
        {
            Record = builder?.Record;
            ID = new Key( Record, PrimaryKey.ActivityCodesId );
            Name = Record?[ $"{ Field.ActivityName }" ].ToString( );
            Code = Record?[ $"{ Field.ActivityCode }" ].ToString( );
            Data = Record?.ToDictionary( );
        }

        /// <inheritdoc/>
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "T:BudgetExecution.ActivityCodes"/>
        /// class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        public Activity( DataRow dataRow )
            : this( )
        {
            Record = dataRow;
            ID = new Key( Record, PrimaryKey.ActivityCodesId );
            Name = dataRow[ $"{ Field.ActivityName }" ].ToString( );
            Code = dataRow[ $"{ Field.ActivityCode }" ].ToString( );
            Data = dataRow?.ToDictionary( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Activity"/> class.
        /// </summary>
        /// <param name = "code" >
        /// The code.
        /// </param>
        public Activity( string code )
        {
            Record = new DataBuilder( Source, GetArgs( code ) )?.Record;
            ID = new Key( Record, PrimaryKey.ActivityCodesId );
            Name = Record[ $"{ Field.ActivityName }" ].ToString( );
            Code = Record[ $"{ Field.ActivityCode }" ].ToString( );
            Data = Record?.ToDictionary( );
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
                    return default( IDictionary<string, object> );
                }
            }

            return default( IDictionary<string, object> );
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