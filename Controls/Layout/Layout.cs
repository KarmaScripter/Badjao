// <copyright file = "Layout.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="LayoutBase" />
    public class Layout : LayoutBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Layout"/> class.
        /// </summary>
        public Layout( )
        {
            // Basic Properties
            Size = new Size( 700, 428 );
            Location = new Point( 1, 1 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Enabled = true;
            Visible = true;

            // Backcolor SeriesConfiguration
            BackColor = Color.FromArgb( 15, 15, 15 );
            ForeColor = Color.FromArgb( 141, 139, 138 );
            BackColorState.Disabled = Color.FromArgb( 15, 15, 15 );
            BackColorState.Enabled = Color.FromArgb( 15, 15, 15 );

            // Border SeriesConfiguration
            Border.Color = Color.FromArgb( 15, 15, 15 );
            Border.Thickness = 1;
            Border.HoverColor = Color.SteelBlue;
            Border.HoverVisible = false;
        }

        public Layout( Size size, Point location )
            : base( size, location )
        {
            Size = size;
            Location = Settings.ReLocate( location.X, location.Y );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Layout" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public Layout( Size size, Point location, Control parent )
            : base( size, location, parent )
        {
            Size = new Size( size.Width, size.Height );
            Location = Settings.ReLocate( location.X, location.Y );
            Parent = parent;
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Layout" />
        /// class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public Layout( Control parent )
            : base( parent )
        {
            Parent = parent;
            Parent.Controls.Add( this );
        }
    }
}