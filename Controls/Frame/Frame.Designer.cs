// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution;

partial class Frame
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
            this.TextBox = new BudgetExecution.TextBox();
            this.Label = new BudgetExecution.Label();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.Table.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.AutoCompleteCustomSource = null;
            this.TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextBox.BindingSource = null;
            this.TextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.TextBox.DataFilter = null;
            this.TextBox.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TextBox.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TextBox.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.TextBox.HoverText = null;
            this.TextBox.Image = null;
            this.TextBox.IsDerivedStyle = true;
            this.TextBox.Lines = null;
            this.TextBox.Location = new System.Drawing.Point(3, 29);
            this.TextBox.MaxLength = 32767;
            this.TextBox.Multiline = false;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = false;
            this.TextBox.Size = new System.Drawing.Size(118, 24);
            this.TextBox.Style = MetroSet_UI.Enums.Style.Custom;
            this.TextBox.StyleManager = null;
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "textBox1";
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox.ThemeAuthor = "Terry D. Eppler";
            this.TextBox.ThemeName = "BudgetExecution";
            this.TextBox.ToolTip = null;
            this.TextBox.UseSystemPasswordChar = false;
            this.TextBox.WatermarkText = "";
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
            this.Label.Location = new System.Drawing.Point(3, 3);
            this.Label.Margin = new System.Windows.Forms.Padding(3);
            this.Label.Name = "Label";
            this.Label.Padding = new System.Windows.Forms.Padding(1);
            this.Label.Size = new System.Drawing.Size(118, 20);
            this.Label.Style = MetroSet_UI.Enums.Style.Light;
            this.Label.StyleManager = null;
            this.Label.TabIndex = 1;
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label.ThemeAuthor = "Narwin";
            this.Label.ThemeName = "MetroLite";
            this.Label.ToolTip = null;
            // 
            // Table
            // 
            this.Table.BackColor = System.Drawing.Color.Transparent;
            this.Table.ColumnCount = 1;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Controls.Add(this.Label, 0, 0);
            this.Table.Controls.Add(this.TextBox, 0, 1);
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Table.ForeColor = System.Drawing.Color.LightGray;
            this.Table.Location = new System.Drawing.Point(0, 0);
            this.Table.Name = "Table";
            this.Table.RowCount = 2;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.94595F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.05405F));
            this.Table.Size = new System.Drawing.Size(124, 58);
            this.Table.TabIndex = 2;
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.Table);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Name = "Frame";
            this.Size = new System.Drawing.Size(124, 58);
            this.Table.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    public TextBox TextBox;
    public Label Label;
    public System.Windows.Forms.TableLayoutPanel Table;
}
