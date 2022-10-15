// <copyright file = "Heading.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    public class Heading : Grid
    {
        /// <summary>
        /// Gets or sets the span.
        /// </summary>
        /// <value>
        /// The span.
        /// </value>
        public int Span { get; set; }

        /// <summary>
        /// Gets or sets from.
        /// </summary>
        /// <value>
        /// From.
        /// </value>
        public (int Row, int Column) Anchor { get; set; }

        /// <summary>
        /// Gets or sets the caption.
        /// </summary>
        /// <value>
        /// The caption.
        /// </value>
        public IDictionary<int, string> Caption { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Heading"/> class.
        /// </summary>
        public Heading( )
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="grid"></param>
        public Heading( IGrid grid )
        {
            Worksheet = grid.GetWorksheet( );
            Range = grid.GetRange( );
            Address = grid.GetAddress( );
            From = ( Range.Start.Row, Range.Start.Column );
            To = ( Range.Start.Row, Range.End.Column );
            Anchor = ( From.Row, From.Column );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Heading"/> class.
        /// </summary>
        /// <param name="grid">The grid.</param>
        /// <param name="caption">The caption.</param>
        public Heading( IGrid grid, IDictionary<int, string> caption )
            : this( grid )
        {
            Caption = caption;
            Span = Range.Columns;
        }

        /// <summary>
        /// Gets the span.
        /// </summary>
        /// <returns></returns>
        public int GetSpan( )
        {
            try
            {
                return Span > 0
                    ? Span
                    : 0;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0;
            }
        }

        /// <summary>
        /// Gets the anchor.
        /// </summary>
        /// <returns></returns>
        public (int Row, int Column) GetAnchor( )
        {
            try
            {
                return Anchor.Row > 0 && Anchor.Column > 0
                    ? Anchor
                    : ( 0, 0 );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return ( 0, 0 );
            }
        }

        /// <summary>
        /// Gets the caption.
        /// </summary>
        /// <returns></returns>
        public IDictionary<int, string> GetCaption( )
        {
            try
            {
                return Caption?.Any( ) == true
                    ? Caption
                    : default( IDictionary<int, string> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<int, string> );
            }
        }
    }
}