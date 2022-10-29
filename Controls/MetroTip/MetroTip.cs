// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Drawing;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;
    using MetroSet_UI.Design;

    public class MetroTip : MetroTipBase
    {
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="MetroTip"/> class.
        /// </summary>
        public MetroTip( )
        {
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Execution";
            Style = Style.Custom;
            BackColor = Color.FromArgb( 5, 5, 5 );
            BorderColor = SystemColors.Highlight;
            ForeColor = Color.White;
            UseAnimation = true;
            UseFading = true;
            AutomaticDelay = 500;
            InitialDelay = 500;
            AutoPopDelay = 5000;
            ReshowDelay = 100;
            TipIcon = ToolTipIcon.Info;
        }

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="MetroTip"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="text">The text.</param>
        /// <param name = "title" > </param>
        public MetroTip( Control control, string text, string title = "" )
            : this( )
        {
            TipTitle = title;
            TipText = text;
            SetToolTipText( control, TipText );
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="MetroTip"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        /// <param name="text">The text.</param>
        /// <param name = "title" > </param>
        public MetroTip( Component component, string text, string title = "" )
            : this( )
        {
            TipTitle = title;
            TipText = text;
            SetToolTipText( component, text );
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="MetroTip"/> class.
        /// </summary>
        /// <param name="toolItem">The toolItem.</param>
        public MetroTip( ToolStripItem toolItem )
            : this( )
        {
            SetToolTipText( toolItem );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetroTip"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        public MetroTip( Control control )
            : this( )
        {
            SetToolTipText( control );
        }
    }
}