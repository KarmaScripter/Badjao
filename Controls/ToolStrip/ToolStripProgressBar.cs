//  <copyright file=" <File Name> .cs" company="Terry D. Eppler">
//  Copyright (c) Terry Eppler. All rights reserved.
//  </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;

    public class ToolStripProgressBar : ToolStripProgressBase
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "ToolStripLabel"/>
        /// class.
        /// </summary>
        public ToolStripProgressBar( )
        {
            Margin = new Padding( 5, 5, 5, 5 );
            Size = new Size( 200, 22 );
            ForeColor = SystemColors.Highlight;
            BackColor = SystemColors.Control;
            Font = new Font( "Roboto", 9 );
            Visible = true;
            Enabled = true;
            Name = "ProgressBar";
            Maximum = 100;
            Minimum = 1;
            Tag = Name;
            ToolTipText = Tag.ToString( );
            HoverText = ToolTipText;
            Style = ProgressBarStyle.Blocks;
            Step = 10;
            MouseHover += OnMouseHover;
        }

        /// <summary>
        /// Increases the specified increment.
        /// </summary>
        /// <param name="increment">The increment.</param>
        public void IncreaseBy( int increment )
        {
            if( increment > 0 )
            {
                try
                {
                    Increment( increment );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Increases the specified increment.
        /// </summary>
        public void ProgressByStep( int step = 10 )
        {
            try
            {
                Step = step;
                PerformStep( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        public void SetField( Field field )
        {
            try
            {
                Field = Enum.IsDefined( typeof( Field ), field )
                    ? field
                    : default;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void ReTag( object tag )
        {
            try
            {
                Tag = tag != null
                    ? tag
                    : null;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the hover text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetHoverText( string text )
        {
            try
            {
                HoverText = string.IsNullOrEmpty( text )
                    ? text
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [mouse hover].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            if( sender is ToolStripProgressBar progress
               && progress != null )
            {
                try
                {
                    var _text = progress?.HoverText;

                    if( !string.IsNullOrEmpty( _text ) )
                    {
                        var _ = new MetroTip( this, _text );
                    }
                    else
                    {
                        if( !string.IsNullOrEmpty( Tag?.ToString( ) )
                           && !string.IsNullOrEmpty( Tag.ToString( ) ) )
                        {
                            var _ = new MetroTip( progress, Tag?.ToString( )?.SplitPascal( ) );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}