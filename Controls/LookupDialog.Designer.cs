namespace BudgetExecution 
{
    partial class LookupDialog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookupDialog));
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TabControl = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.LookupTabPage = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.TableGroupBox = new BudgetExecution.GroupBox();
            this.TableListBox = new BudgetExecution.ListBox();
            this.ToolTip = new BudgetExecution.MetroTip();
            this.ValueGroupBox = new BudgetExecution.GroupBox();
            this.ValueListBox = new BudgetExecution.ListBox();
            this.ColumnGroupBox = new BudgetExecution.GroupBox();
            this.ColumnListBox = new BudgetExecution.ListBox();
            this.ProviderGroupBox = new BudgetExecution.GroupBox();
            this.AccessRadioButton = new BudgetExecution.RadioButton();
            this.SqlServerRadioButton = new BudgetExecution.RadioButton();
            this.SqliteRadioButton = new BudgetExecution.RadioButton();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.groupBox7 = new BudgetExecution.GroupBox();
            this.listBox5 = new BudgetExecution.ListBox();
            this.listBox6 = new BudgetExecution.ListBox();
            this.groupBox8 = new BudgetExecution.GroupBox();
            this.visualComboBox3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.visualLabel3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel5 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualTextBox3 = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
            this.SelectButton = new BudgetExecution.Button();
            this.RefreshButton = new BudgetExecution.Button();
            this.CloseButton = new BudgetExecution.Button();
            this.groupBox2 = new BudgetExecution.GroupBox();
            this.groupBox3 = new BudgetExecution.GroupBox();
            this.groupBox4 = new BudgetExecution.GroupBox();
            this.groupBox9 = new BudgetExecution.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).BeginInit();
            this.TabControl.SuspendLayout();
            this.LookupTabPage.SuspendLayout();
            this.TableGroupBox.SuspendLayout();
            this.ValueGroupBox.SuspendLayout();
            this.ColumnGroupBox.SuspendLayout();
            this.ProviderGroupBox.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.BeforeTouchSize = new System.Drawing.Size(1368, 488);
            this.TabControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabControl.CanOverrideStyle = true;
            this.TabControl.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.Controls.Add(this.LookupTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabControl.FixedSingleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.FocusOnTabClick = false;
            this.TabControl.InactiveCloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.InactiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.ItemSize = new System.Drawing.Size(158, 23);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.Size = new System.Drawing.Size(1368, 488);
            this.TabControl.TabIndex = 8;
            this.TabControl.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabControl.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.TabControl.ThemeName = "TabRendererMetro";
            this.TabControl.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TabControl.ThemeStyle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TabControl.ThemeStyle.DisabledTabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TabControl.ThemeStyle.EditableTabStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TabControl.ThemeStyle.EditableTabStyle.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.TabControl.ThemeStyle.PrimitiveButtonStyle.DisabledNextPageImage = null;
            this.TabControl.ThemeStyle.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveCloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveCloseButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TabControl.ThemeStyle.TabStyle.ActiveForeColor = System.Drawing.Color.White;
            this.TabControl.ThemeStyle.TabStyle.InactiveBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            // 
            // LookupTabPage
            // 
            this.LookupTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LookupTabPage.Controls.Add(this.TableGroupBox);
            this.LookupTabPage.Controls.Add(this.ValueGroupBox);
            this.LookupTabPage.Controls.Add(this.ColumnGroupBox);
            this.LookupTabPage.Controls.Add(this.ProviderGroupBox);
            this.LookupTabPage.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.LookupTabPage.Image = null;
            this.LookupTabPage.ImageSize = new System.Drawing.Size(12, 12);
            this.LookupTabPage.Location = new System.Drawing.Point(0, 22);
            this.LookupTabPage.Name = "LookupTabPage";
            this.LookupTabPage.ShowCloseButton = true;
            this.LookupTabPage.Size = new System.Drawing.Size(1368, 466);
            this.LookupTabPage.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LookupTabPage.TabForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.LookupTabPage.TabIndex = 2;
            this.LookupTabPage.Text = "  Look Up";
            this.LookupTabPage.ThemesEnabled = false;
            // 
            // TableGroupBox
            // 
            this.TableGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TableGroupBox.BindingSource = null;
            this.TableGroupBox.Controls.Add(this.TableListBox);
            this.TableGroupBox.DataFilter = null;
            this.TableGroupBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableGroupBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.TableGroupBox.HeaderText = null;
            this.TableGroupBox.HoverText = null;
            this.TableGroupBox.Location = new System.Drawing.Point(712, 44);
            this.TableGroupBox.Name = "TableGroupBox";
            this.TableGroupBox.Padding = new System.Windows.Forms.Padding(1);
            this.TableGroupBox.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TableGroupBox.Size = new System.Drawing.Size(417, 189);
            this.TableGroupBox.TabIndex = 4;
            this.TableGroupBox.Text = "  Tables";
            this.TableGroupBox.ToolTip = null;
            // 
            // TableListBox
            // 
            this.TableListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TableListBox.BindingSource = null;
            this.TableListBox.DataFilter = null;
            this.TableListBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TableListBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.TableListBox.HoverText = null;
            this.TableListBox.ItemHeight = 30;
            this.TableListBox.Location = new System.Drawing.Point(15, 38);
            this.TableListBox.Name = "TableListBox";
            this.TableListBox.Padding = new System.Windows.Forms.Padding(1);
            this.TableListBox.Size = new System.Drawing.Size(388, 139);
            this.TableListBox.TabIndex = 1;
            this.TableListBox.Text = "Tables";
            this.TableListBox.ToolTip = this.ToolTip;
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ToolTip.BindingSource = null;
            this.ToolTip.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ToolTip.ForeColor = System.Drawing.Color.White;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.Name = null;
            this.ToolTip.OwnerDraw = true;
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.StyleManager = null;
            this.ToolTip.ThemeAuthor = "Terry D. Eppler";
            this.ToolTip.ThemeName = "Budget Execution";
            this.ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.TipText = null;
            this.ToolTip.TipTitle = null;
            // 
            // ValueGroupBox
            // 
            this.ValueGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ValueGroupBox.BindingSource = null;
            this.ValueGroupBox.Controls.Add(this.ValueListBox);
            this.ValueGroupBox.DataFilter = null;
            this.ValueGroupBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValueGroupBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ValueGroupBox.HeaderText = null;
            this.ValueGroupBox.HoverText = null;
            this.ValueGroupBox.Location = new System.Drawing.Point(712, 259);
            this.ValueGroupBox.Name = "ValueGroupBox";
            this.ValueGroupBox.Padding = new System.Windows.Forms.Padding(1);
            this.ValueGroupBox.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ValueGroupBox.Size = new System.Drawing.Size(417, 186);
            this.ValueGroupBox.TabIndex = 3;
            this.ValueGroupBox.Text = "  Values";
            this.ValueGroupBox.ToolTip = null;
            // 
            // ValueListBox
            // 
            this.ValueListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ValueListBox.BindingSource = null;
            this.ValueListBox.DataFilter = null;
            this.ValueListBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ValueListBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ValueListBox.HoverText = null;
            this.ValueListBox.ItemHeight = 30;
            this.ValueListBox.Location = new System.Drawing.Point(15, 38);
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.Padding = new System.Windows.Forms.Padding(1);
            this.ValueListBox.Size = new System.Drawing.Size(388, 139);
            this.ValueListBox.TabIndex = 2;
            this.ValueListBox.Text = "listBox1";
            this.ValueListBox.ToolTip = this.ToolTip;
            // 
            // ColumnGroupBox
            // 
            this.ColumnGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ColumnGroupBox.BindingSource = null;
            this.ColumnGroupBox.Controls.Add(this.ColumnListBox);
            this.ColumnGroupBox.DataFilter = null;
            this.ColumnGroupBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColumnGroupBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ColumnGroupBox.HeaderText = null;
            this.ColumnGroupBox.HoverText = null;
            this.ColumnGroupBox.Location = new System.Drawing.Point(177, 259);
            this.ColumnGroupBox.Name = "ColumnGroupBox";
            this.ColumnGroupBox.Padding = new System.Windows.Forms.Padding(1);
            this.ColumnGroupBox.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ColumnGroupBox.Size = new System.Drawing.Size(380, 186);
            this.ColumnGroupBox.TabIndex = 2;
            this.ColumnGroupBox.Text = "  Columns";
            this.ColumnGroupBox.ToolTip = null;
            // 
            // ColumnListBox
            // 
            this.ColumnListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ColumnListBox.BindingSource = null;
            this.ColumnListBox.DataFilter = null;
            this.ColumnListBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColumnListBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ColumnListBox.HoverText = null;
            this.ColumnListBox.ItemHeight = 30;
            this.ColumnListBox.Location = new System.Drawing.Point(20, 38);
            this.ColumnListBox.Name = "ColumnListBox";
            this.ColumnListBox.Padding = new System.Windows.Forms.Padding(1);
            this.ColumnListBox.Size = new System.Drawing.Size(348, 139);
            this.ColumnListBox.TabIndex = 2;
            this.ColumnListBox.Text = "listBox1";
            this.ColumnListBox.ToolTip = this.ToolTip;
            // 
            // ProviderGroupBox
            // 
            this.ProviderGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ProviderGroupBox.BindingSource = null;
            this.ProviderGroupBox.Controls.Add(this.AccessRadioButton);
            this.ProviderGroupBox.Controls.Add(this.SqlServerRadioButton);
            this.ProviderGroupBox.Controls.Add(this.SqliteRadioButton);
            this.ProviderGroupBox.DataFilter = null;
            this.ProviderGroupBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProviderGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProviderGroupBox.HeaderText = "";
            this.ProviderGroupBox.HoverText = null;
            this.ProviderGroupBox.Location = new System.Drawing.Point(180, 44);
            this.ProviderGroupBox.Name = "ProviderGroupBox";
            this.ProviderGroupBox.Padding = new System.Windows.Forms.Padding(1);
            this.ProviderGroupBox.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProviderGroupBox.Size = new System.Drawing.Size(377, 189);
            this.ProviderGroupBox.TabIndex = 0;
            this.ProviderGroupBox.Text = "  Connection";
            this.ProviderGroupBox.ToolTip = null;
            // 
            // AccessRadioButton
            // 
            this.AccessRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.AccessRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.AccessRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.AccessRadioButton.Checked = false;
            this.AccessRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AccessRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.AccessRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.AccessRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccessRadioButton.Group = 1;
            this.AccessRadioButton.HoverText = null;
            this.AccessRadioButton.Location = new System.Drawing.Point(135, 146);
            this.AccessRadioButton.Name = "AccessRadioButton";
            this.AccessRadioButton.Result = null;
            this.AccessRadioButton.Size = new System.Drawing.Size(125, 17);
            this.AccessRadioButton.StyleManager = null;
            this.AccessRadioButton.TabIndex = 3;
            this.AccessRadioButton.Text = "    MS Access";
            this.AccessRadioButton.ThemeAuthor = "Narwin";
            this.AccessRadioButton.ThemeName = "MetroDark";
            this.AccessRadioButton.ToolTip = this.ToolTip;
            // 
            // SqlServerRadioButton
            // 
            this.SqlServerRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.SqlServerRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SqlServerRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.SqlServerRadioButton.Checked = false;
            this.SqlServerRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SqlServerRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.SqlServerRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.SqlServerRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SqlServerRadioButton.Group = 1;
            this.SqlServerRadioButton.HoverText = null;
            this.SqlServerRadioButton.Location = new System.Drawing.Point(135, 99);
            this.SqlServerRadioButton.Name = "SqlServerRadioButton";
            this.SqlServerRadioButton.Result = null;
            this.SqlServerRadioButton.Size = new System.Drawing.Size(125, 17);
            this.SqlServerRadioButton.StyleManager = null;
            this.SqlServerRadioButton.TabIndex = 2;
            this.SqlServerRadioButton.Text = "    SQL Server";
            this.SqlServerRadioButton.ThemeAuthor = "Narwin";
            this.SqlServerRadioButton.ThemeName = "MetroDark";
            this.SqlServerRadioButton.ToolTip = this.ToolTip;
            // 
            // SqliteRadioButton
            // 
            this.SqliteRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.SqliteRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SqliteRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.SqliteRadioButton.Checked = false;
            this.SqliteRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SqliteRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.SqliteRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.SqliteRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SqliteRadioButton.Group = 1;
            this.SqliteRadioButton.HoverText = null;
            this.SqliteRadioButton.Location = new System.Drawing.Point(135, 54);
            this.SqliteRadioButton.Name = "SqliteRadioButton";
            this.SqliteRadioButton.Result = null;
            this.SqliteRadioButton.Size = new System.Drawing.Size(125, 17);
            this.SqliteRadioButton.StyleManager = null;
            this.SqliteRadioButton.TabIndex = 1;
            this.SqliteRadioButton.Text = "    SQLite";
            this.SqliteRadioButton.ThemeAuthor = "Narwin";
            this.SqliteRadioButton.ThemeName = "MetroDark";
            this.SqliteRadioButton.ToolTip = this.ToolTip;
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.groupBox7);
            this.tabPageAdv1.Controls.Add(this.groupBox8);
            this.tabPageAdv1.Image = null;
            this.tabPageAdv1.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.ShowCloseButton = true;
            this.tabPageAdv1.Size = new System.Drawing.Size(200, 100);
            this.tabPageAdv1.TabFont = null;
            this.tabPageAdv1.TabIndex = 0;
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.groupBox7.BindingSource = null;
            this.groupBox7.Controls.Add(this.listBox5);
            this.groupBox7.Controls.Add(this.listBox6);
            this.groupBox7.DataFilter = null;
            this.groupBox7.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox7.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox7.HeaderText = null;
            this.groupBox7.HoverText = null;
            this.groupBox7.Location = new System.Drawing.Point(438, 58);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox7.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox7.Size = new System.Drawing.Size(377, 191);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.Text = "  Tables";
            this.groupBox7.ToolTip = null;
            // 
            // listBox5
            // 
            this.listBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.listBox5.BindingSource = null;
            this.listBox5.DataFilter = null;
            this.listBox5.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox5.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.listBox5.HoverText = null;
            this.listBox5.ItemHeight = 30;
            this.listBox5.Location = new System.Drawing.Point(15, 40);
            this.listBox5.Name = "listBox5";
            this.listBox5.Padding = new System.Windows.Forms.Padding(1);
            this.listBox5.Size = new System.Drawing.Size(348, 140);
            this.listBox5.TabIndex = 2;
            this.listBox5.Text = "listBox3";
            this.listBox5.ToolTip = this.ToolTip;
            // 
            // listBox6
            // 
            this.listBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.listBox6.BindingSource = null;
            this.listBox6.DataFilter = null;
            this.listBox6.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox6.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.listBox6.HoverText = null;
            this.listBox6.ItemHeight = 30;
            this.listBox6.Location = new System.Drawing.Point(15, 40);
            this.listBox6.Name = "listBox6";
            this.listBox6.Padding = new System.Windows.Forms.Padding(1);
            this.listBox6.Size = new System.Drawing.Size(348, 140);
            this.listBox6.TabIndex = 1;
            this.listBox6.Text = "listBox4";
            this.listBox6.ToolTip = this.ToolTip;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.groupBox8.BindingSource = null;
            this.groupBox8.Controls.Add(this.visualComboBox3);
            this.groupBox8.Controls.Add(this.visualLabel3);
            this.groupBox8.Controls.Add(this.visualLabel5);
            this.groupBox8.Controls.Add(this.visualTextBox3);
            this.groupBox8.DataFilter = null;
            this.groupBox8.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox8.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox8.HeaderText = null;
            this.groupBox8.HoverText = null;
            this.groupBox8.Location = new System.Drawing.Point(25, 293);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox8.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox8.Size = new System.Drawing.Size(790, 186);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.Text = "  Columns";
            this.groupBox8.ToolTip = null;
            // 
            // visualComboBox3
            // 
            this.visualComboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.visualComboBox3.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.visualComboBox3.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.visualComboBox3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visualComboBox3.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualComboBox3.Border.HoverVisible = true;
            this.visualComboBox3.Border.Rounding = 6;
            this.visualComboBox3.Border.Thickness = 1;
            this.visualComboBox3.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualComboBox3.Border.Visible = true;
            this.visualComboBox3.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.visualComboBox3.ButtonImage = null;
            this.visualComboBox3.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.visualComboBox3.ButtonWidth = 30;
            this.visualComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.visualComboBox3.DropDownHeight = 100;
            this.visualComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.visualComboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.visualComboBox3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualComboBox3.FormattingEnabled = true;
            this.visualComboBox3.ImageList = null;
            this.visualComboBox3.ImageVisible = false;
            this.visualComboBox3.Index = 0;
            this.visualComboBox3.IntegralHeight = false;
            this.visualComboBox3.ItemHeight = 24;
            this.visualComboBox3.ItemImageVisible = true;
            this.visualComboBox3.Location = new System.Drawing.Point(92, 91);
            this.visualComboBox3.MenuItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualComboBox3.MenuItemNormal = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.visualComboBox3.MenuTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualComboBox3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualComboBox3.Name = "visualComboBox3";
            this.visualComboBox3.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.visualComboBox3.Size = new System.Drawing.Size(221, 30);
            this.visualComboBox3.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualComboBox3.TabIndex = 4;
            this.visualComboBox3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualComboBox3.TextDisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualComboBox3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.visualComboBox3.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualComboBox3.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualComboBox3.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualComboBox3.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualComboBox3.TextStyle.Hover = System.Drawing.Color.Empty;
            this.visualComboBox3.TextStyle.Pressed = System.Drawing.Color.Empty;
            this.visualComboBox3.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualComboBox3.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualComboBox3.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualComboBox3.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.visualComboBox3.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.visualComboBox3.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.visualComboBox3.Watermark.Text = "Watermark text";
            this.visualComboBox3.Watermark.Visible = false;
            // 
            // visualLabel3
            // 
            this.visualLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.visualLabel3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel3.Location = new System.Drawing.Point(92, 57);
            this.visualLabel3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel3.Name = "visualLabel3";
            this.visualLabel3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel3.Outline = false;
            this.visualLabel3.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel3.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel3.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel3.ReflectionSpacing = 0;
            this.visualLabel3.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel3.ShadowDirection = 315;
            this.visualLabel3.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel3.ShadowOpacity = 100;
            this.visualLabel3.Size = new System.Drawing.Size(177, 23);
            this.visualLabel3.TabIndex = 3;
            this.visualLabel3.Text = "Select  Existing Column";
            this.visualLabel3.TextAlignment = System.Drawing.StringAlignment.Near;
            this.visualLabel3.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel3.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualLabel3.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel3.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel3.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel3.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel3.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel3.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // visualLabel5
            // 
            this.visualLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.visualLabel5.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualLabel5.Location = new System.Drawing.Point(419, 57);
            this.visualLabel5.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel5.Name = "visualLabel5";
            this.visualLabel5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel5.Outline = false;
            this.visualLabel5.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel5.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel5.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel5.ReflectionSpacing = 0;
            this.visualLabel5.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel5.ShadowDirection = 315;
            this.visualLabel5.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel5.ShadowOpacity = 100;
            this.visualLabel5.Size = new System.Drawing.Size(120, 23);
            this.visualLabel5.TabIndex = 2;
            this.visualLabel5.Text = "Enter New Name";
            this.visualLabel5.TextAlignment = System.Drawing.StringAlignment.Near;
            this.visualLabel5.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel5.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualLabel5.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel5.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel5.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel5.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel5.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel5.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // visualTextBox3
            // 
            this.visualTextBox3.AlphaNumeric = false;
            this.visualTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.visualTextBox3.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.visualTextBox3.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.visualTextBox3.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.visualTextBox3.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualTextBox3.Border.HoverVisible = true;
            this.visualTextBox3.Border.Rounding = 6;
            this.visualTextBox3.Border.Thickness = 1;
            this.visualTextBox3.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualTextBox3.Border.Visible = true;
            this.visualTextBox3.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.visualTextBox3.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualTextBox3.ButtonBorder.HoverVisible = true;
            this.visualTextBox3.ButtonBorder.Rounding = 6;
            this.visualTextBox3.ButtonBorder.Thickness = 1;
            this.visualTextBox3.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualTextBox3.ButtonBorder.Visible = true;
            this.visualTextBox3.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.visualTextBox3.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.visualTextBox3.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.visualTextBox3.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.visualTextBox3.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.visualTextBox3.ButtonIndent = 3;
            this.visualTextBox3.ButtonText = "visualButton";
            this.visualTextBox3.ButtonVisible = false;
            this.visualTextBox3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.visualTextBox3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.visualTextBox3.Image = null;
            this.visualTextBox3.ImageSize = new System.Drawing.Size(16, 16);
            this.visualTextBox3.ImageVisible = false;
            this.visualTextBox3.ImageWidth = 35;
            this.visualTextBox3.Location = new System.Drawing.Point(419, 91);
            this.visualTextBox3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualTextBox3.Name = "visualTextBox3";
            this.visualTextBox3.PasswordChar = '\0';
            this.visualTextBox3.ReadOnly = false;
            this.visualTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.visualTextBox3.Size = new System.Drawing.Size(278, 25);
            this.visualTextBox3.TabIndex = 1;
            this.visualTextBox3.TextBoxWidth = 268;
            this.visualTextBox3.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualTextBox3.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualTextBox3.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualTextBox3.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualTextBox3.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualTextBox3.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualTextBox3.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualTextBox3.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.visualTextBox3.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.visualTextBox3.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.visualTextBox3.Watermark.Text = "Watermark text";
            this.visualTextBox3.Watermark.Visible = false;
            this.visualTextBox3.WordWrap = true;
            // 
            // SelectButton
            // 
            this.SelectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SelectButton.BindingSource = null;
            this.SelectButton.DataFilter = null;
            this.SelectButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.HoverText = "Not Yet Implemented!";
            this.SelectButton.Images = null;
            this.SelectButton.Location = new System.Drawing.Point(72, 531);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(0);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Padding = new System.Windows.Forms.Padding(1);
            this.SelectButton.Size = new System.Drawing.Size(140, 55);
            this.SelectButton.TabIndex = 7;
            this.SelectButton.Text = "Select";
            this.SelectButton.ToolTip = this.ToolTip;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RefreshButton.BindingSource = null;
            this.RefreshButton.DataFilter = null;
            this.RefreshButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RefreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.RefreshButton.HoverText = "Not Yet Implemented!";
            this.RefreshButton.Images = null;
            this.RefreshButton.Location = new System.Drawing.Point(611, 531);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Padding = new System.Windows.Forms.Padding(1);
            this.RefreshButton.Size = new System.Drawing.Size(140, 55);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Clear";
            this.RefreshButton.ToolTip = this.ToolTip;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CloseButton.BindingSource = null;
            this.CloseButton.DataFilter = null;
            this.CloseButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.HoverText = "Close Window";
            this.CloseButton.Images = null;
            this.CloseButton.Location = new System.Drawing.Point(1182, 531);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(1);
            this.CloseButton.Size = new System.Drawing.Size(140, 55);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.ToolTip = this.ToolTip;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.groupBox2.BindingSource = null;
            this.groupBox2.DataFilter = null;
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.HeaderText = null;
            this.groupBox2.HoverText = null;
            this.groupBox2.Location = new System.Drawing.Point(1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox2.Size = new System.Drawing.Size(250, 150);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.ToolTip = null;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.groupBox3.BindingSource = null;
            this.groupBox3.DataFilter = null;
            this.groupBox3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.HeaderText = null;
            this.groupBox3.HoverText = null;
            this.groupBox3.Location = new System.Drawing.Point(1, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox3.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox3.Size = new System.Drawing.Size(250, 150);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.ToolTip = null;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.groupBox4.BindingSource = null;
            this.groupBox4.DataFilter = null;
            this.groupBox4.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.HeaderText = null;
            this.groupBox4.HoverText = null;
            this.groupBox4.Location = new System.Drawing.Point(1, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox4.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox4.Size = new System.Drawing.Size(250, 150);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.ToolTip = null;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.groupBox9.BindingSource = null;
            this.groupBox9.DataFilter = null;
            this.groupBox9.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox9.ForeColor = System.Drawing.Color.White;
            this.groupBox9.HeaderText = null;
            this.groupBox9.HoverText = null;
            this.groupBox9.Location = new System.Drawing.Point(1, 1);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox9.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox9.Size = new System.Drawing.Size(250, 150);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.ToolTip = null;
            // 
            // LookupDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1368, 588);
            this.ControlBox = false;
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.CloseButton);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Name = "LookupDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabControl)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.LookupTabPage.ResumeLayout(false);
            this.TableGroupBox.ResumeLayout(false);
            this.TableGroupBox.PerformLayout();
            this.ValueGroupBox.ResumeLayout(false);
            this.ValueGroupBox.PerformLayout();
            this.ColumnGroupBox.ResumeLayout(false);
            this.ColumnGroupBox.PerformLayout();
            this.ProviderGroupBox.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public RadioButton AccessRadioButton;
        public RadioButton SqlServerRadioButton;
        public RadioButton SqliteRadioButton;
        public MetroTip ToolTip;
        public System.Windows.Forms.BindingSource BindingSource;
        public GroupBox ProviderGroupBox;
        public Button RefreshButton;
        public Button CloseButton;
        public Button SelectButton;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        public GroupBox ValueGroupBox;
        public ListBox ValueListBox;
        public GroupBox ColumnGroupBox;
        public ListBox ColumnListBox;
        public ListBox TableListBox;
        public Syncfusion.Windows.Forms.Tools.TabControlAdv TabControl;
        public Syncfusion.Windows.Forms.Tools.TabPageAdv LookupTabPage;
        public GroupBox groupBox7;
        public ListBox listBox5;
        public ListBox listBox6;
        public GroupBox groupBox8;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox visualComboBox3;
        public VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel3;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel5;
        public VisualPlus.Toolkit.Controls.Editors.VisualTextBox visualTextBox3;
        private GroupBox groupBox9;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        public GroupBox TableGroupBox;
    }
}