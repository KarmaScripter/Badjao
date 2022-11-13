// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;

    public class ToolSeparator : ToolStripSeparator
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "ToolStripLabel"/>
        /// class.
        /// </summary>
        public ToolSeparator( )
        {
            Margin = new Padding( 1, 1, 1, 1 );
            Padding = new Padding( 1, 1, 1, 1 );
            ForeColor = Color.Black;
            Font = new Font( "Roboto", 8 );
            Width = 1;
            Height = 42;
        }

        /// <summary>
        /// Sets the width.
        /// </summary>
        /// <param name="width">The width.</param>
        public void SetWidth( int width = 3 )
        {
            if( width > 0
               && width < 10 )
            {
                try
                {
                    Width = width;
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
        private static void Fail( Exception ex )
        {
            using var _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}