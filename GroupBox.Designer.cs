// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class GroupBox
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
        if( disposing && ( components != null ) )
        {
            components.Dispose( );
        }
        base.Dispose( disposing );
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent( )
    {
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.Label = new BudgetExecution.Label();
            this.Separator = new MetroSet_UI.Controls.MetroSetDivider();
            this.Panel = new BudgetExecution.Layout();
            this.Table.SuspendLayout();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Table
            // 
            this.Table.ColumnCount = 1;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Controls.Add(this.Label, 0, 0);
            this.Table.Controls.Add(this.Separator, 0, 1);
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(1, 1);
            this.Table.Name = "Table";
            this.Table.RowCount = 2;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.4918F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.50819F));
            this.Table.Size = new System.Drawing.Size(372, 303);
            this.Table.TabIndex = 0;
            // 
            // Label
            // 
            this.Label.BindingSource = null;
            this.Label.DataFilter = null;
            this.Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Label.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label.HoverText = null;
            this.Label.IsDerivedStyle = true;
            this.Label.Location = new System.Drawing.Point(3, 5);
            this.Label.Margin = new System.Windows.Forms.Padding(3);
            this.Label.Name = "Label";
            this.Label.Padding = new System.Windows.Forms.Padding(1);
            this.Label.Size = new System.Drawing.Size(366, 23);
            this.Label.Style = MetroSet_UI.Enums.Style.Custom;
            this.Label.StyleManager = null;
            this.Label.TabIndex = 0;
            this.Label.Text = "label1";
            this.Label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Label.ThemeAuthor = "Narwin";
            this.Label.ThemeName = "MetroLite";
            this.Label.ToolTip = null;
            // 
            // Separator
            // 
            this.Separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.Separator.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Separator.IsDerivedStyle = true;
            this.Separator.Location = new System.Drawing.Point(3, 34);
            this.Separator.Name = "Separator";
            this.Separator.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.Separator.Size = new System.Drawing.Size(366, 4);
            this.Separator.Style = MetroSet_UI.Enums.Style.Custom;
            this.Separator.StyleManager = null;
            this.Separator.TabIndex = 1;
            this.Separator.Text = "metroSetDivider1";
            this.Separator.ThemeAuthor = "Narwin";
            this.Separator.ThemeName = "MetroLite";
            this.Separator.Thickness = 1;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.Transparent;
            this.Panel.BackgroundColor = System.Drawing.Color.White;
            this.Panel.BindingSource = null;
            this.Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.BorderThickness = 1;
            this.Panel.Children = null;
            this.Panel.Controls.Add(this.Table);
            this.Panel.DataFilter = null;
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.ForeColor = System.Drawing.Color.Transparent;
            this.Panel.HoverText = null;
            this.Panel.IsDerivedStyle = true;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.Name = "Panel";
            this.Panel.Padding = new System.Windows.Forms.Padding(1);
            this.Panel.Size = new System.Drawing.Size(376, 307);
            this.Panel.Style = MetroSet_UI.Enums.Style.Light;
            this.Panel.StyleManager = null;
            this.Panel.TabIndex = 1;
            this.Panel.ThemeAuthor = "Terry D. Eppler";
            this.Panel.ThemeName = "BudgetExecution";
            this.Panel.ToolTip = null;
            // 
            // GroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.Panel);
            this.Name = "GroupBox";
            this.Size = new System.Drawing.Size(376, 307);
            this.Table.ResumeLayout(false);
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion
    public Layout Panel;
    public System.Windows.Forms.TableLayoutPanel Table;
    public Label Label;
    public MetroSet_UI.Controls.MetroSetDivider Separator;
}
