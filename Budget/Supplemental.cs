// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Immutable;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// Budget authority provided in an appropriations act in addition to regular or
    /// continuing appropriations already provided. Supplemental appropriations
    /// generally are made to cover emergencies, such as disaster relief, or other
    /// needs deemed too urgent to be postponed until the enactment of next year's
    /// regular appropriations act.
    /// </summary>
    /// <seealso cref = "ProgramResultsCode"/>
    /// <seealso cref = "IProgram"/>
    /// <seealso cref = "ISupplemental"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Global" ) ]
    public abstract class Supplemental : ProgramResultsCode
    {
        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public override Source Source { get; set; } =  Source.StatusOfSupplementalFunding;

        /// <summary>
        /// Gets or sets the ProgramResultCodes identifier.
        /// </summary>
        /// <value>
        /// The ProgramResultCodes identifier.
        /// </value>
        public override int ID { get; set; }

        /// <summary>
        /// Gets the code.
        /// </summary>
        public override string Code { get; set; }

        public override string Name { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the boc.
        /// </summary>
        /// <value>
        /// The boc.
        /// </value>
        public string BOC { get; set; }

        /// <summary>
        /// Gets the Data builder.
        /// </summary>
        /// <returns>
        /// </returns>
        public IDataModel GetBuilder( )
        {
            try
            {
                return ( Data?.Any( ) == true )
                    ? new DataBuilder( Source, Data )
                    : default( DataBuilder );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDataModel );
            }
        }
    }
}