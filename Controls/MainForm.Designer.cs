namespace BudgetExecution
{
    partial class MainForm
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
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Selector = new BudgetExecution.Selector();
            this.SuspendLayout();
            // 
            // Selector
            // 
            this.Selector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Selector.CanOverrideStyle = true;
            this.Selector.Font = new System.Drawing.Font("Roboto", 9F);
            this.Selector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.Selector.FunctionalityPath = null;
            this.Selector.HighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.Selector.ImageshadeColor = System.Drawing.Color.Black;
            this.Selector.ImageSize = new System.Drawing.Size(250, 250);
            this.Selector.ImageSlides = true;
            this.Selector.Location = new System.Drawing.Point(206, 163);
            this.Selector.Name = "Selector";
            this.Selector.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Selector.PadX = 0;
            this.Selector.PadY = 0;
            this.Selector.Perspective = 4F;
            this.Selector.ProviderPath = null;
            this.Selector.RotateAlways = false;
            this.Selector.ShowImagePreview = true;
            this.Selector.ShowImageShadow = true;
            this.Selector.Size = new System.Drawing.Size(1006, 401);
            this.Selector.TabIndex = 0;
            this.Selector.ThemeName = "Metro";
            this.Selector.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.Selector.ThemeStyle.Font = new System.Drawing.Font("Roboto", 9F);
            this.Selector.ThemeStyle.ForeColor = System.Drawing.Color.White;
            this.Selector.ThemeStyle.HoverImageBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.Selector.ThemeStyle.HoverImageBorderThickness = 2;
            this.Selector.ThemeStyle.ImageShadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Selector.TouchTransitionSpeed = 1F;
            this.Selector.UseOriginalImageinPreview = true;
            this.Selector.VisualStyle = Syncfusion.Windows.Forms.Tools.CarouselVisualStyle.Metro;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.Red;
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            captionImage1.BackColor = System.Drawing.Color.Transparent;
            captionImage1.Image = global::BudgetExecution.Properties.Resources.Earth;
            captionImage1.Location = new System.Drawing.Point(4, 4);
            captionImage1.Name = "CaptionImage";
            captionImage1.Size = new System.Drawing.Size(22, 22);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(1388, 763);
            this.Controls.Add(this.Selector);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        public Selector Selector;
    }
}