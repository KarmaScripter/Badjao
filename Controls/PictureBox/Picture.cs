// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public class Picture : PictureBox 
    {
        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public virtual MetroTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public virtual Field Field { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the image list.
        /// </summary>
        /// <value>
        /// The image list.
        /// </value>
        public ImageList ImageList { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Picture" />
        /// class.
        /// </summary>
        public Picture( )
        {
            Size = new Size( 60, 40 );
            Anchor = AnchorStyles.Left | AnchorStyles.Top;
            Location = new Point( 1, 1 );
            BackColor = Color.Transparent;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            SizeMode = PictureBoxSizeMode.StretchImage;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Picture" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public Picture( Size size, Point location )
            : this( )
        {
            Size = size;
            Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="Picture" />
        /// class.
        /// </summary>
        /// <param name="image">The image.</param>
        public Picture( Image image )
            : this( )
        {
        }

        public Picture( string path )
            : this( )
        {
        }
    }
}