// // <copyright file = "IListView.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public interface IListView
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        MetroTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetBorderColor( Color color );

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        void SetHoverBorderColor( Color color );

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="hoverColor">if set to <c>true</c> [hover color].</param>
        void SetBorderConfiguration( bool hoverColor );

        /// <summary>
        /// Sets the hover information.
        /// </summary>
        /// <param name="text">The text.</param>
        void SetHoverText( string text );

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        void SetText( string text );

        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <param name="item">The item.</param>
        void AddItem( string item );

        /// <summary>
        /// Adds the items.
        /// </summary>
        /// <param name="items">The items.</param>
        void AddItems( IEnumerable<string> items );

        /// <summary>
        /// Adds the item.
        /// </summary>
        /// <param name="item">The item.</param>
        void RemoveItem( string item );
    }
}