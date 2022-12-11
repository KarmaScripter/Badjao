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
            this.Calculator = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
            this.ValueLabel = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.SuspendLayout();
            // 
            // Calculator
            // 
            this.Calculator.AccessibleDescription = "Calculator control";
            this.Calculator.AccessibleName = "Calculator Control";
            this.Calculator.BeforeTouchSize = new System.Drawing.Size(407, 409);
            this.Calculator.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.Calculator.Culture = new System.Globalization.CultureInfo("en-US");
            this.Calculator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Calculator.DoubleValue = 0D;
            this.Calculator.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculator.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Calculator.LayoutType = Syncfusion.Windows.Forms.Tools.CalculatorLayoutTypes.Financial;
            this.Calculator.Location = new System.Drawing.Point(0, 41);
            this.Calculator.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Calculator.Name = "Calculator";
            this.Calculator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Calculator.ShowDisplayArea = false;
            this.Calculator.Size = new System.Drawing.Size(407, 409);
            this.Calculator.TabIndex = 0;
            this.Calculator.ThemeName = "Metro";
            this.Calculator.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.Calculator.ThemeStyle.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculator.ThemeStyle.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Calculator.ThemeStyle.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Calculator.ThemeStyle.ToolTipStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Calculator.ThemeStyle.ToolTipStyle.DropShadow = true;
            this.Calculator.ThemeStyle.ToolTipStyle.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Calculator.ThemeStyle.ToolTipStyle.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Calculator.UseVisualStyle = true;
            // 
            // ValueLabel
            // 
            this.ValueLabel.BeforeTouchSize = new System.Drawing.Size(407, 41);
            this.ValueLabel.BorderAppearance = System.Windows.Forms.BorderStyle.None;
            this.ValueLabel.BorderColor = System.Drawing.Color.Transparent;
            this.ValueLabel.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.ValueLabel.CanOverrideStyle = true;
            this.ValueLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ValueLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValueLabel.Location = new System.Drawing.Point(0, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(407, 41);
            this.ValueLabel.TabIndex = 1;
            this.ValueLabel.Text = "0.0";
            this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ValueLabel.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.ValueLabel.ThemeStyle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValueLabel.ThemeStyle.ForeColor = System.Drawing.Color.LightSteelBlue;
            // 
            // CalculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CaptionFont = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.Calculator);
            this.Controls.Add(this.ValueLabel);
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Name = "CalculationForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public Syncfusion.Windows.Forms.Tools.CalculatorControl Calculator;
        public Syncfusion.Windows.Forms.Tools.GradientLabel ValueLabel;
    }
}

