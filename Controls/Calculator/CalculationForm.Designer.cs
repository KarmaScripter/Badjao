// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>
//
namespace BudgetExecution
{
    partial class CalculationForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculationForm));
            this.Calculator = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
            this.ValueLabel = new BudgetExecution.Label();
            this.SuspendLayout();
            // 
            // Calculator
            // 
            this.Calculator.AccessibleDescription = "Calculator control";
            this.Calculator.AccessibleName = "Calculator Control";
            this.Calculator.BeforeTouchSize = new System.Drawing.Size(408, 371);
            this.Calculator.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.Calculator.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.Calculator.Culture = new System.Globalization.CultureInfo("en-US");
            this.Calculator.DisplayTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Calculator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Calculator.DoubleValue = 0D;
            this.Calculator.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculator.ForeColor = System.Drawing.Color.LightGray;
            this.Calculator.LayoutType = Syncfusion.Windows.Forms.Tools.CalculatorLayoutTypes.Financial;
            this.Calculator.Location = new System.Drawing.Point(0, 43);
            this.Calculator.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Calculator.Name = "Calculator";
            this.Calculator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Calculator.ShowDisplayArea = false;
            this.Calculator.Size = new System.Drawing.Size(408, 371);
            this.Calculator.TabIndex = 0;
            this.Calculator.ThemeName = "Budget Execution";
            this.Calculator.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.Calculator.ThemeStyle.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculator.ThemeStyle.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Calculator.ThemeStyle.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Calculator.ThemeStyle.ToolTipStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Calculator.ThemeStyle.ToolTipStyle.DropShadow = true;
            this.Calculator.ThemeStyle.ToolTipStyle.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculator.ThemeStyle.ToolTipStyle.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Calculator.UseVerticalAndHorizontalSpacing = true;
            this.Calculator.UseVisualStyle = true;
            // 
            // ValueLabel
            // 
            this.ValueLabel.BindingSource = null;
            this.ValueLabel.DataFilter = null;
            this.ValueLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ValueLabel.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValueLabel.HoverText = null;
            this.ValueLabel.IsDerivedStyle = true;
            this.ValueLabel.Location = new System.Drawing.Point(0, 0);
            this.ValueLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Padding = new System.Windows.Forms.Padding(1);
            this.ValueLabel.Size = new System.Drawing.Size(408, 21);
            this.ValueLabel.Style = MetroSet_UI.Enums.Style.Custom;
            this.ValueLabel.StyleManager = null;
            this.ValueLabel.TabIndex = 1;
            this.ValueLabel.Text = "0";
            this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ValueLabel.ThemeAuthor = "Terry D. Eppler";
            this.ValueLabel.ThemeName = "BudgetExecution";
            this.ValueLabel.ToolTip = null;
            // 
            // CalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.Red;
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(408, 414);
            this.Controls.Add(this.ValueLabel);
            this.Controls.Add(this.Calculator);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Name = "CalculationForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public Syncfusion.Windows.Forms.Tools.CalculatorControl Calculator;
        public Label ValueLabel;
    }
}

