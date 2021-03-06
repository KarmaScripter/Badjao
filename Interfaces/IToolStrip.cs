// // <copyright file = "IBudgetToolStrip.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Drawing;

    public interface IToolStrip
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        System.Windows.Forms.BindingSource BindingSource { get; set; }

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
        /// Gets or sets the separator.
        /// </summary>
        /// <value>
        /// The separator.
        /// </value>
        ToolSeparator Separator1 { get; set; }

        /// <summary>
        /// Gets or sets the separator2.
        /// </summary>
        /// <value>
        /// The separator2.
        /// </value>
        ToolSeparator Separator2 { get; set; }

        /// <summary>
        /// Gets or sets the separator3.
        /// </summary>
        /// <value>
        /// The separator3.
        /// </value>
        ToolSeparator Separator3 { get; set; }

        /// <summary>
        /// Gets or sets the separator4.
        /// </summary>
        /// <value>
        /// The separator4.
        /// </value>
        ToolSeparator Separator4 { get; set; }

        /// <summary>
        /// Gets or sets the separator5.
        /// </summary>
        /// <value>
        /// The separator5.
        /// </value>
        ToolSeparator Separator5 { get; set; }

        /// <summary>
        /// Gets or sets the separator6.
        /// </summary>
        /// <value>
        /// The separator6.
        /// </value>
        ToolSeparator Separator6 { get; set; }

        /// <summary>
        /// Gets or sets the separator7.
        /// </summary>
        /// <value>
        /// The separator7.
        /// </value>
        ToolSeparator Separator7 { get; set; }

        /// <summary>
        /// Gets or sets the separator8.
        /// </summary>
        /// <value>
        /// The separator8.
        /// </value>
        ToolSeparator Separator8 { get; set; }

        /// <summary>
        /// Gets or sets the separator9.
        /// </summary>
        /// <value>
        /// The separator9.
        /// </value>
        ToolSeparator Separator9 { get; set; }

        /// <summary>
        /// Gets or sets the separator10.
        /// </summary>
        /// <value>
        /// The separator10.
        /// </value>
        ToolSeparator Separator10 { get; set; }

        /// <summary>
        /// Gets or sets the separator11.
        /// </summary>
        /// <value>
        /// The separator11.
        /// </value>
        ToolSeparator Separator11 { get; set; }

        /// <summary>
        /// Gets or sets the separator12.
        /// </summary>
        /// <value>
        /// The separator12.
        /// </value>
        ToolSeparator Separator12 { get; set; }

        /// <summary>
        /// Gets or sets the separator13.
        /// </summary>
        /// <value>
        /// The separator13.
        /// </value>
        ToolSeparator Separator13 { get; set; }

        /// <summary>
        /// Gets or sets the separator14.
        /// </summary>
        /// <value>
        /// The separator14.
        /// </value>
        ToolSeparator Separator14 { get; set; }

        /// <summary>
        /// Gets or sets the separator15.
        /// </summary>
        /// <value>
        /// The separator15.
        /// </value>
        ToolSeparator Separator15 { get; set; }

        /// <summary>
        /// Gets or sets the separator16.
        /// </summary>
        /// <value>
        /// The separator16.
        /// </value>
        ToolSeparator Separator16 { get; set; }

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

        /// <summary>
        /// Gets or sets the first button.
        /// </summary>
        /// <value>
        /// The first button.
        /// </value>
        ToolStripButton FirstButton { get; set; }

        /// <summary>
        /// Gets or sets the previous button.
        /// </summary>
        /// <value>
        /// The previous button.
        /// </value>
        ToolStripButton PreviousButton { get; set; }

        /// <summary>
        /// Gets or sets the next button.
        /// </summary>
        /// <value>
        /// The next button.
        /// </value>
        ToolStripButton NextButton { get; set; }

        /// <summary>
        /// Gets or sets the last button.
        /// </summary>
        /// <value>
        /// The last button.
        /// </value>
        ToolStripButton LastButton { get; set; }

        /// <summary>
        /// Gets or sets the edit button.
        /// </summary>
        /// <value>
        /// The edit button.
        /// </value>
        ToolStripButton EditButton { get; set; }

        /// <summary>
        /// Gets or sets the add button.
        /// </summary>
        /// <value>
        /// The add button.
        /// </value>
        ToolStripButton AddButton { get; set; }

        /// <summary>
        /// Gets or sets the delete button.
        /// </summary>
        /// <value>
        /// The delete button.
        /// </value>
        ToolStripButton DeleteButton { get; set; }

        /// <summary>
        /// Gets or sets the refresh button.
        /// </summary>
        /// <value>
        /// The refresh button.
        /// </value>
        ToolStripButton RefreshButton { get; set; }

        /// <summary>
        /// Gets or sets the save button.
        /// </summary>
        /// <value>
        /// The save button.
        /// </value>
        ToolStripButton SaveButton { get; set; }

        /// <summary>
        /// Gets or sets the browse button.
        /// </summary>
        /// <value>
        /// The browse button.
        /// </value>
        ToolStripButton BrowseButton { get; set; }

        /// <summary>
        /// Gets or sets the print button.
        /// </summary>
        /// <value>
        /// The print button.
        /// </value>
        ToolStripButton PrintButton { get; set; }

        /// <summary>
        /// Gets or sets the excel button.
        /// </summary>
        /// <value>
        /// The excel button.
        /// </value>
        ToolStripButton ExcelButton { get; set; }

        /// <summary>
        /// Gets or sets the calculator button.
        /// </summary>
        /// <value>
        /// The calculator button.
        /// </value>
        ToolStripButton CalculatorButton { get; set; }
    }
}