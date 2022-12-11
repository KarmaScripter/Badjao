﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using MetroSet_UI.Enums;
    using VisualPlus.Enumerators;

    public class ListBox : ListBoxBase
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public override BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public override MetroTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public override string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public override IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="ListBox"/> class.
        /// </summary>
        public ListBox( )
        {
            // Basic Properties
            Size = new Size( 200, 100 );
            Location = new Point( 1, 1 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.LightGray;
            Enabled = true;
            Visible = true;
            Text = string.Empty;
            Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // BackColor SeriesConfiguration
            Style = Style.Custom;
            BackColor = Color.FromArgb( 40, 40, 40 );
            ShowBorder = false;
            BorderColor = Color.FromArgb( 65, 65, 65 );
            HoveredItemBackColor = Color.FromArgb( 50, 93, 129 );
            HoveredItemColor = Color.White;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "BudgetExecution";
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ListBox" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public ListBox( Size size, Point location )
            : this( )
        {
            Size = size;
            Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ListBox" />
        /// class.
        /// </summary>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public ListBox( Point location, Control parent = null )
            : this( )
        {
            Location = location;

            if( parent != null )
            {
                Parent = parent;
                Parent.Controls.Add( this );
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ListBox" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="parent">The parent.</param>
        public ListBox( Size size, Control parent = null )
            : this( )
        {
            Size = size;

            if( parent != null )
            {
                Parent = parent;
                Parent.Controls.Add( this );
            }
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ListBox" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public ListBox( Size size, Point location, Control parent )
            : this( )
        {
            Size = size;
            Location = location;
            Parent = parent;
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ListBox" />
        /// class.
        /// </summary>
        /// <param name="title">The title.</param>
        public ListBox( string title )
            : this( )
        {
            Text = title;
        }

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetBorderColor( Color color )
        {
            if( color != Color.Empty )
            {
                try
                {
                    BorderColor = color;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [visible].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnVisible( object sender, EventArgs e )
        {
            try
            {
                ItemHeight = 30;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Adds the control item.
        /// </summary>
        /// <param name = "items" > </param>
        public void AddItems( IEnumerable<object> items )
        {
            if( items?.Count( ) > -1 )
            {
                try
                {
                    foreach( var _item in items )
                    {
                        Items.Add( _item );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Adds the control item.
        /// </summary>
        /// <returns></returns>
        public void AddItem( object item )
        {
            if( !string.IsNullOrEmpty( item?.ToString( ) ) )
            {
                try
                {
                    Items.Add( item );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the hover information.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetHoverText( string text )
        {
            if( !string.IsNullOrEmpty( text ) )
            {
                try
                {
                    var _ = new MetroTip( this, text );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public void SetText( string text )
        {
            if( !string.IsNullOrEmpty( text ) )
            {
                try
                {
                    Text = text;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
    }
}