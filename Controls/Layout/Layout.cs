// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Drawing;
    using System.Windows.Forms;
    using MetroSet_UI.Enums;

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
            Style = Style.Custom;
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "BudgetExecution";
            Size = new Size( 700, 428 );
            Location = new Point( 1, 1 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.None;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Enabled = true;
            Visible = true;

            // Back color SeriesConfiguration
            BorderStyle = BorderStyle.None;
            BackColor = Color.Transparent;
            ForeColor = Color.LightGray;
            BorderColor = Color.FromArgb( 0, 120, 212 );
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