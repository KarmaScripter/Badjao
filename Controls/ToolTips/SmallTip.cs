// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Drawing;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;
    using MetroSet_UI.Enums;
    using MetroSet_UI.Components;
    using System;

    public class SmallTip : MetroSetSetToolTip
    {
        /// <summary>
        /// Gets or sets the tip icon.
        /// </summary>
        /// <value>
        /// The tip icon.
        /// </value>
        public virtual ToolTipIcon TipIcon { get; set; } = ToolTipIcon.Info;

        /// <summary>
        /// Gets or sets the tip title.
        /// </summary>
        /// <value>
        /// The tip title.
        /// </value>
        public virtual string TipTitle { get; set; }

        /// <summary>
        /// Gets or sets the tip text.
        /// </summary>
        /// <value>
        /// The tip title.
        /// </value>
        public virtual string TipText { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="SmallTip"/> class.
        /// </summary>
        public SmallTip( )
        {
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Execution";
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
        /// the <see cref="SmallTip"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="text">The text.</param>
        /// <param name = "title" > </param>
        public SmallTip( Control control, string text, string title = "" )
            : this( )
        {
            TipTitle = title;
            TipText = text;
            SetText( control, TipText );
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="SmallTip"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        /// <param name="text">The text.</param>
        /// <param name = "title" > </param>
        public SmallTip( Component component, string text, string title = "" )
            : this( )
        {
            TipTitle = title;
            TipText = text;
            SetText( component, text );
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="SmallTip"/> class.
        /// </summary>
        /// <param name="toolItem">The toolItem.</param>
        public SmallTip( ToolStripItem toolItem )
            : this( )
        {
            SetText( toolItem );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SmallTip"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        public SmallTip( Control control )
            : this( )
        {
            SetText( control );
        }
        /// <summary>
        /// Sets the animation.
        /// </summary>
        /// <param name="animate">if set to <c>true</c> [animate].</param>
        public virtual void SetAnimation( bool animate )
        {
            try
            {
                UseAnimation = animate;
                UseFading = animate;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the automatic delay.
        /// </summary>
        /// <param name="delay">The delay.</param>
        public virtual void SetAutomaticDelay( int delay = 500 )
        {
            if( delay > 0 )
            {
                try
                {
                    AutomaticDelay = delay;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the duration.
        /// </summary>
        /// <param name="time">The time.</param>
        public virtual void ResetDuration( int time = 5000 )
        {
            if( time > 0 )
            {
                try
                {
                    AutoPopDelay = time;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the initial delay.
        /// </summary>
        /// <param name="delay">The delay.</param>
        public virtual void SetInitialDelay( int delay = 500 )
        {
            if( delay > 0 )
            {
                try
                {
                    InitialDelay = delay;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the reshow delay.
        /// </summary>
        /// <param name="reshow">The reshow.</param>
        public virtual void ResetDelay( int reshow = 100 )
        {
            if( reshow > 0 )
            {
                try
                {
                    ReshowDelay = reshow;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public virtual void ReTag( object tag )
        {
            if( tag != null )
            {
                try
                {
                    Tag = tag;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tool tip text.
        /// </summary>
        /// <param name="control">The control.</param>
        public virtual void SetText( Control control )
        {
            if( !string.IsNullOrEmpty( control?.Tag?.ToString( ) ) )
            {
                try
                {
                    RemoveAll( );
                    var _caption = control.Tag.ToString( );
                    SetToolTip( control, _caption );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tool tip text.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="caption">The caption.</param>
        public virtual void SetText( Control control, string caption )
        {
            if( control != null
               && !string.IsNullOrEmpty( caption ) )
            {
                try
                {
                    RemoveAll( );
                    SetToolTip( control, caption );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tool tip text.
        /// </summary>
        /// <param name="item">The item.</param>
        public virtual void SetText( ToolStripItem item )
        {
            if( item.GetCurrentParent( ) != null
               && item != null )
            {
                try
                {
                    Control parent = item.GetCurrentParent( );
                    var caption = item?.Tag?.ToString( );

                    if( !string.IsNullOrEmpty( caption ) )
                    {
                        RemoveAll( );
                        SetText( parent, caption );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tool tip text.
        /// </summary>
        /// <param name="component">The component.</param>
        public virtual void SetText( Component component )
        {
            if( component is Control control )
            {
                try
                {
                    if( !string.IsNullOrEmpty( control?.Tag?.ToString( ) ) )
                    {
                        var caption = control.Tag.ToString( );
                        RemoveAll( );
                        SetToolTip( control, caption );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tool tip text.
        /// </summary>
        /// <param name="component">The component.</param>
        /// <param name="caption">The caption.</param>
        public virtual void SetText( Component component, string caption )
        {
            if( component != null
               && !string.IsNullOrEmpty( caption ) )
            {
                try
                {
                    if( component is Control control )
                    {
                        RemoveAll( );
                        SetToolTip( control, caption );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Clears the text.
        /// </summary>
        public virtual void ClearText( )
        {
            try
            {
                TipText = string.Empty;
                TipTitle = string.Empty;
                RemoveAll( );
            }
            catch( Exception ex )
            {
                Fail( ex );
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