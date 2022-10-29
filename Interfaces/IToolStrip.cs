// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    public interface IToolStrip
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        Field Field { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets the buttons.
        /// </summary>
        /// <value>
        /// The buttons.
        /// </value>
        IDictionary<string, ToolStripButton> Buttons { get; }

        /// <summary>
        /// Gets or sets the size of the image.
        /// </summary>
        /// <value>
        /// The size of the image.
        /// </value>
        Size ImageSize { get; set; }

        /// <summary>
        /// Gets or sets the size of the image scaling.
        /// </summary>
        /// <value>
        /// The size of the image scaling.
        /// </value>
        Size ImageScalingSize { get; set; }

        /// <summary>
        /// Gets or sets the tool strip ComboBox.
        /// </summary>
        /// <value>
        /// The tool strip ComboBox.
        /// </value>
        ToolStripDropDown DropDown { get; set; }

        /// <summary>
        /// Gets or sets the tool strip text box.
        /// </summary>
        /// <value>
        /// The tool strip text box.
        /// </value>
        ToolStripTextBox TextBox { get; set; }
    }
}