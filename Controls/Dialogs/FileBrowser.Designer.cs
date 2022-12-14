
namespace BudgetExecution
{
    using System;
    using System.ComponentModel;
    using System.Threading;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    

    partial class FileBrowser : MetroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileBrowser));
        this.TextBoxLayout = new System.Windows.Forms.TableLayoutPanel();
        this.CheckBoxLayout = new System.Windows.Forms.TableLayoutPanel();
        this.LibraryRadioButton = new BudgetExecution.RadioButton();
        this.PowerPointRadioButton = new BudgetExecution.RadioButton();
        this.ExecutableRadioButton = new BudgetExecution.RadioButton();
        this.TextRadioButton = new BudgetExecution.RadioButton();
        this.SqlCeRadioButton = new BudgetExecution.RadioButton();
        this.ExcelRadioButton = new BudgetExecution.RadioButton();
        this.CsvRadioButton = new BudgetExecution.RadioButton();
        this.AccessRadioButton = new BudgetExecution.RadioButton();
        this.SQLiteRadioButton = new BudgetExecution.RadioButton();
        this.SqlServerRadioButton = new BudgetExecution.RadioButton();
        this.WordRadioButton = new BudgetExecution.RadioButton();
        this.PdfRadioButton = new BudgetExecution.RadioButton();
        this.FileList = new BudgetExecution.ListBox();
        this.ToolTip = new BudgetExecution.SmallTip();
        this.FoundLabel = new BudgetExecution.Label();
        this.FileDialog = new System.Windows.Forms.OpenFileDialog();
        this.TopTablePanel = new System.Windows.Forms.TableLayoutPanel();
        this.Header = new BudgetExecution.Label();
        this.Picture = new BudgetExecution.Picture();
        this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
        this.MessageLabel = new BudgetExecution.Label();
        this.SelectButton = new BudgetExecution.Button();
        this.CloseButton = new BudgetExecution.Button();
        this.TextBoxLayout.SuspendLayout();
        this.CheckBoxLayout.SuspendLayout();
        this.TopTablePanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
        this.SuspendLayout();
        // 
        // TextBoxLayout
        // 
        this.TextBoxLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        this.TextBoxLayout.BackColor = System.Drawing.Color.Transparent;
        this.TextBoxLayout.ColumnCount = 3;
        this.TextBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.55012F));
        this.TextBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.99126F));
        this.TextBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.4723F));
        this.TextBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        this.TextBoxLayout.Controls.Add(this.CheckBoxLayout, 2, 0);
        this.TextBoxLayout.Controls.Add(this.FileList, 1, 0);
        this.TextBoxLayout.Controls.Add(this.FoundLabel, 0, 0);
        this.TextBoxLayout.Dock = System.Windows.Forms.DockStyle.Top;
        this.TextBoxLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
        this.TextBoxLayout.Location = new System.Drawing.Point(0, 55);
        this.TextBoxLayout.Margin = new System.Windows.Forms.Padding(5);
        this.TextBoxLayout.Name = "TextBoxLayout";
        this.TextBoxLayout.Padding = new System.Windows.Forms.Padding(1);
        this.TextBoxLayout.RowCount = 1;
        this.TextBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.TextBoxLayout.Size = new System.Drawing.Size(688, 314);
        this.TextBoxLayout.TabIndex = 5;
        // 
        // CheckBoxLayout
        // 
        this.CheckBoxLayout.BackColor = System.Drawing.Color.Transparent;
        this.CheckBoxLayout.ColumnCount = 1;
        this.CheckBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        this.CheckBoxLayout.Controls.Add(this.LibraryRadioButton, 0, 11);
        this.CheckBoxLayout.Controls.Add(this.PowerPointRadioButton, 0, 8);
        this.CheckBoxLayout.Controls.Add(this.ExecutableRadioButton, 0, 10);
        this.CheckBoxLayout.Controls.Add(this.TextRadioButton, 0, 7);
        this.CheckBoxLayout.Controls.Add(this.SqlCeRadioButton, 0, 9);
        this.CheckBoxLayout.Controls.Add(this.ExcelRadioButton, 0, 6);
        this.CheckBoxLayout.Controls.Add(this.CsvRadioButton, 0, 5);
        this.CheckBoxLayout.Controls.Add(this.AccessRadioButton, 0, 4);
        this.CheckBoxLayout.Controls.Add(this.SQLiteRadioButton, 0, 3);
        this.CheckBoxLayout.Controls.Add(this.SqlServerRadioButton, 0, 2);
        this.CheckBoxLayout.Controls.Add(this.WordRadioButton, 0, 1);
        this.CheckBoxLayout.Controls.Add(this.PdfRadioButton, 0, 0);
        this.CheckBoxLayout.Dock = System.Windows.Forms.DockStyle.Fill;
        this.CheckBoxLayout.Location = new System.Drawing.Point(576, 4);
        this.CheckBoxLayout.Name = "CheckBoxLayout";
        this.CheckBoxLayout.RowCount = 12;
        this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333765F));
        this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333266F));
        this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333266F));
        this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333266F));
        this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333266F));
        this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333266F));
        this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333266F));
        this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333266F));
        this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333267F));
        this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333765F));
        this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333765F));
        this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.332569F));
        this.CheckBoxLayout.Size = new System.Drawing.Size(108, 306);
        this.CheckBoxLayout.TabIndex = 2;
        // 
        // LibraryRadioButton
        // 
        this.LibraryRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
        this.LibraryRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
        this.LibraryRadioButton.Checked = false;
        this.LibraryRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        this.LibraryRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
        this.LibraryRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
        this.LibraryRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
        this.LibraryRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.LibraryRadioButton.Group = 1;
        this.LibraryRadioButton.HoverText = "Library Files";
        this.LibraryRadioButton.Location = new System.Drawing.Point(3, 278);
        this.LibraryRadioButton.Name = "LibraryRadioButton";
        this.LibraryRadioButton.Result = null;
        this.LibraryRadioButton.Size = new System.Drawing.Size(102, 17);
        this.LibraryRadioButton.StyleManager = null;
        this.LibraryRadioButton.TabIndex = 15;
        this.LibraryRadioButton.Tag = ".dll";
        this.LibraryRadioButton.Text = "  DLL Files";
        this.LibraryRadioButton.ThemeAuthor = "Terry D. Eppler";
        this.LibraryRadioButton.ThemeName = "Budget Execution";
        this.LibraryRadioButton.ToolTip = null;
        // 
        // PowerPointRadioButton
        // 
        this.PowerPointRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
        this.PowerPointRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
        this.PowerPointRadioButton.Checked = false;
        this.PowerPointRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        this.PowerPointRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
        this.PowerPointRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
        this.PowerPointRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
        this.PowerPointRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.PowerPointRadioButton.Group = 1;
        this.PowerPointRadioButton.HoverText = "Power Point Files";
        this.PowerPointRadioButton.Location = new System.Drawing.Point(3, 203);
        this.PowerPointRadioButton.Name = "PowerPointRadioButton";
        this.PowerPointRadioButton.Result = null;
        this.PowerPointRadioButton.Size = new System.Drawing.Size(102, 17);
        this.PowerPointRadioButton.StyleManager = null;
        this.PowerPointRadioButton.TabIndex = 21;
        this.PowerPointRadioButton.Tag = ".pptx";
        this.PowerPointRadioButton.Text = "  Power Point";
        this.PowerPointRadioButton.ThemeAuthor = "Terry D. Eppler";
        this.PowerPointRadioButton.ThemeName = "Budget Execution";
        this.PowerPointRadioButton.ToolTip = null;
        // 
        // ExecutableRadioButton
        // 
        this.ExecutableRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
        this.ExecutableRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
        this.ExecutableRadioButton.Checked = false;
        this.ExecutableRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        this.ExecutableRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
        this.ExecutableRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
        this.ExecutableRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
        this.ExecutableRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.ExecutableRadioButton.Group = 1;
        this.ExecutableRadioButton.HoverText = "Executable Files";
        this.ExecutableRadioButton.Location = new System.Drawing.Point(3, 253);
        this.ExecutableRadioButton.Name = "ExecutableRadioButton";
        this.ExecutableRadioButton.Result = null;
        this.ExecutableRadioButton.Size = new System.Drawing.Size(102, 17);
        this.ExecutableRadioButton.StyleManager = null;
        this.ExecutableRadioButton.TabIndex = 14;
        this.ExecutableRadioButton.Tag = ".exe";
        this.ExecutableRadioButton.Text = "  EXE Files";
        this.ExecutableRadioButton.ThemeAuthor = "Terry D. Eppler";
        this.ExecutableRadioButton.ThemeName = "Budget Execution";
        this.ExecutableRadioButton.ToolTip = null;
        // 
        // TextRadioButton
        // 
        this.TextRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
        this.TextRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
        this.TextRadioButton.Checked = false;
        this.TextRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        this.TextRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
        this.TextRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
        this.TextRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
        this.TextRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.TextRadioButton.Group = 1;
        this.TextRadioButton.HoverText = "Text Files";
        this.TextRadioButton.Location = new System.Drawing.Point(3, 178);
        this.TextRadioButton.Name = "TextRadioButton";
        this.TextRadioButton.Result = null;
        this.TextRadioButton.Size = new System.Drawing.Size(102, 17);
        this.TextRadioButton.StyleManager = null;
        this.TextRadioButton.TabIndex = 20;
        this.TextRadioButton.Tag = ".txt";
        this.TextRadioButton.Text = "  Text Files";
        this.TextRadioButton.ThemeAuthor = "Terry D. Eppler";
        this.TextRadioButton.ThemeName = "Budget Execution";
        this.TextRadioButton.ToolTip = null;
        // 
        // SqlCeRadioButton
        // 
        this.SqlCeRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
        this.SqlCeRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
        this.SqlCeRadioButton.Checked = false;
        this.SqlCeRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        this.SqlCeRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
        this.SqlCeRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
        this.SqlCeRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
        this.SqlCeRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.SqlCeRadioButton.Group = 1;
        this.SqlCeRadioButton.HoverText = "SQL Compact Files";
        this.SqlCeRadioButton.Location = new System.Drawing.Point(3, 228);
        this.SqlCeRadioButton.Name = "SqlCeRadioButton";
        this.SqlCeRadioButton.Result = null;
        this.SqlCeRadioButton.Size = new System.Drawing.Size(102, 17);
        this.SqlCeRadioButton.StyleManager = null;
        this.SqlCeRadioButton.TabIndex = 13;
        this.SqlCeRadioButton.Tag = ".sdf";
        this.SqlCeRadioButton.Text = "  SQL Compact";
        this.SqlCeRadioButton.ThemeAuthor = "Terry D. Eppler";
        this.SqlCeRadioButton.ThemeName = "Budget Execution";
        this.SqlCeRadioButton.ToolTip = null;
        // 
        // ExcelRadioButton
        // 
        this.ExcelRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
        this.ExcelRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
        this.ExcelRadioButton.Checked = false;
        this.ExcelRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        this.ExcelRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
        this.ExcelRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
        this.ExcelRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
        this.ExcelRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.ExcelRadioButton.Group = 1;
        this.ExcelRadioButton.HoverText = "Excel Workbooks";
        this.ExcelRadioButton.Location = new System.Drawing.Point(3, 153);
        this.ExcelRadioButton.Name = "ExcelRadioButton";
        this.ExcelRadioButton.Result = null;
        this.ExcelRadioButton.Size = new System.Drawing.Size(102, 17);
        this.ExcelRadioButton.StyleManager = null;
        this.ExcelRadioButton.TabIndex = 19;
        this.ExcelRadioButton.Tag = ".xlsx";
        this.ExcelRadioButton.Text = "  Excel Files";
        this.ExcelRadioButton.ThemeAuthor = "Terry D. Eppler";
        this.ExcelRadioButton.ThemeName = "Budget Execution";
        this.ExcelRadioButton.ToolTip = null;
        // 
        // CsvRadioButton
        // 
        this.CsvRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
        this.CsvRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
        this.CsvRadioButton.Checked = false;
        this.CsvRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        this.CsvRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
        this.CsvRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
        this.CsvRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
        this.CsvRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.CsvRadioButton.Group = 1;
        this.CsvRadioButton.HoverText = "CSV Files";
        this.CsvRadioButton.Location = new System.Drawing.Point(3, 128);
        this.CsvRadioButton.Name = "CsvRadioButton";
        this.CsvRadioButton.Result = null;
        this.CsvRadioButton.Size = new System.Drawing.Size(102, 17);
        this.CsvRadioButton.StyleManager = null;
        this.CsvRadioButton.TabIndex = 18;
        this.CsvRadioButton.Tag = ".csv";
        this.CsvRadioButton.Text = "  CSV Files";
        this.CsvRadioButton.ThemeAuthor = "Terry D. Eppler";
        this.CsvRadioButton.ThemeName = "Budget Execution";
        this.CsvRadioButton.ToolTip = null;
        // 
        // AccessRadioButton
        // 
        this.AccessRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
        this.AccessRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
        this.AccessRadioButton.Checked = false;
        this.AccessRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        this.AccessRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
        this.AccessRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
        this.AccessRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
        this.AccessRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.AccessRadioButton.Group = 1;
        this.AccessRadioButton.HoverText = "Access DB Files";
        this.AccessRadioButton.Location = new System.Drawing.Point(3, 103);
        this.AccessRadioButton.Name = "AccessRadioButton";
        this.AccessRadioButton.Result = null;
        this.AccessRadioButton.Size = new System.Drawing.Size(102, 17);
        this.AccessRadioButton.StyleManager = null;
        this.AccessRadioButton.TabIndex = 17;
        this.AccessRadioButton.Tag = ".accdb";
        this.AccessRadioButton.Text = "  MS Access";
        this.AccessRadioButton.ThemeAuthor = "Terry D. Eppler";
        this.AccessRadioButton.ThemeName = "Budget Execution";
        this.AccessRadioButton.ToolTip = null;
        // 
        // SQLiteRadioButton
        // 
        this.SQLiteRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
        this.SQLiteRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
        this.SQLiteRadioButton.Checked = false;
        this.SQLiteRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        this.SQLiteRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
        this.SQLiteRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
        this.SQLiteRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
        this.SQLiteRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.SQLiteRadioButton.Group = 1;
        this.SQLiteRadioButton.HoverText = "SQLite DB Files";
        this.SQLiteRadioButton.Location = new System.Drawing.Point(3, 78);
        this.SQLiteRadioButton.Name = "SQLiteRadioButton";
        this.SQLiteRadioButton.Result = null;
        this.SQLiteRadioButton.Size = new System.Drawing.Size(102, 17);
        this.SQLiteRadioButton.StyleManager = null;
        this.SQLiteRadioButton.TabIndex = 16;
        this.SQLiteRadioButton.Tag = ".db";
        this.SQLiteRadioButton.Text = "  SQLite";
        this.SQLiteRadioButton.ThemeAuthor = "Terry D. Eppler";
        this.SQLiteRadioButton.ThemeName = "Budget Execution";
        this.SQLiteRadioButton.ToolTip = null;
        // 
        // SqlServerRadioButton
        // 
        this.SqlServerRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
        this.SqlServerRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
        this.SqlServerRadioButton.Checked = false;
        this.SqlServerRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        this.SqlServerRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
        this.SqlServerRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
        this.SqlServerRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
        this.SqlServerRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.SqlServerRadioButton.Group = 1;
        this.SqlServerRadioButton.HoverText = "SQL Server DB Files";
        this.SqlServerRadioButton.Location = new System.Drawing.Point(3, 53);
        this.SqlServerRadioButton.Name = "SqlServerRadioButton";
        this.SqlServerRadioButton.Result = null;
        this.SqlServerRadioButton.Size = new System.Drawing.Size(102, 17);
        this.SqlServerRadioButton.StyleManager = null;
        this.SqlServerRadioButton.TabIndex = 15;
        this.SqlServerRadioButton.Tag = ".mdf";
        this.SqlServerRadioButton.Text = "  SQL Server";
        this.SqlServerRadioButton.ThemeAuthor = "Terry D. Eppler";
        this.SqlServerRadioButton.ThemeName = "Budget Execution";
        this.SqlServerRadioButton.ToolTip = null;
        // 
        // WordRadioButton
        // 
        this.WordRadioButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
        this.WordRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
        this.WordRadioButton.Checked = false;
        this.WordRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        this.WordRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
        this.WordRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
        this.WordRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
        this.WordRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.WordRadioButton.Group = 1;
        this.WordRadioButton.HoverText = "Word Documents";
        this.WordRadioButton.Location = new System.Drawing.Point(3, 28);
        this.WordRadioButton.Name = "WordRadioButton";
        this.WordRadioButton.Result = null;
        this.WordRadioButton.StyleManager = null;
        this.WordRadioButton.TabIndex = 14;
        this.WordRadioButton.Tag = ".docx";
        this.WordRadioButton.Text = "  Word";
        this.WordRadioButton.ThemeAuthor = "Terry D. Eppler";
        this.WordRadioButton.ThemeName = "Budget Execution";
        this.WordRadioButton.ToolTip = null;
        // 
        // PdfRadioButton
        // 
        this.PdfRadioButton.BackgroundColor = System.Drawing.Color.Transparent;
        this.PdfRadioButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
        this.PdfRadioButton.Checked = false;
        this.PdfRadioButton.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
        this.PdfRadioButton.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
        this.PdfRadioButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
        this.PdfRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
        this.PdfRadioButton.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.PdfRadioButton.Group = 1;
        this.PdfRadioButton.HoverText = "PDF Documents";
        this.PdfRadioButton.Location = new System.Drawing.Point(3, 3);
        this.PdfRadioButton.Name = "PdfRadioButton";
        this.PdfRadioButton.Result = null;
        this.PdfRadioButton.Size = new System.Drawing.Size(102, 17);
        this.PdfRadioButton.StyleManager = null;
        this.PdfRadioButton.TabIndex = 13;
        this.PdfRadioButton.Tag = ".pdf";
        this.PdfRadioButton.Text = "  PDF";
        this.PdfRadioButton.ThemeAuthor = "Terry D. Eppler";
        this.PdfRadioButton.ThemeName = "Budget Execution";
        this.PdfRadioButton.ToolTip = null;
        // 
        // FileList
        // 
        this.FileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
        this.FileList.BindingSource = null;
        this.FileList.DataFilter = null;
        this.FileList.Dock = System.Windows.Forms.DockStyle.Fill;
        this.FileList.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.FileList.ForeColor = System.Drawing.Color.LightSteelBlue;
        this.FileList.HoverText = null;
        this.FileList.ItemHeight = 30;
        this.FileList.Location = new System.Drawing.Point(90, 4);
        this.FileList.Name = "FileList";
        this.FileList.Padding = new System.Windows.Forms.Padding(1);
        this.FileList.Size = new System.Drawing.Size(480, 306);
        this.FileList.TabIndex = 3;
        this.FileList.ToolTip = this.ToolTip;
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
        // FoundLabel
        // 
        this.FoundLabel.BackColor = System.Drawing.Color.Transparent;
        this.FoundLabel.BindingSource = null;
        this.FoundLabel.DataFilter = null;
        this.FoundLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.FoundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
        this.FoundLabel.HoverText = null;
        this.FoundLabel.Location = new System.Drawing.Point(4, 4);
        this.FoundLabel.Name = "FoundLabel";
        this.FoundLabel.Padding = new System.Windows.Forms.Padding(1);
        this.FoundLabel.Size = new System.Drawing.Size(80, 23);
        this.FoundLabel.TabIndex = 4;
        this.FoundLabel.ToolTip = null;
        // 
        // FileDialog
        // 
        this.FileDialog.Filter = "Document FIles | *.PDF | *.DOCX | *.DOC ";
        // 
        // TopTablePanel
        // 
        this.TopTablePanel.BackColor = System.Drawing.Color.Transparent;
        this.TopTablePanel.ColumnCount = 3;
        this.TopTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
        this.TopTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.61539F));
        this.TopTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
        this.TopTablePanel.Controls.Add(this.Header, 1, 0);
        this.TopTablePanel.Controls.Add(this.Picture, 0, 0);
        this.TopTablePanel.Dock = System.Windows.Forms.DockStyle.Top;
        this.TopTablePanel.Location = new System.Drawing.Point(0, 0);
        this.TopTablePanel.Name = "TopTablePanel";
        this.TopTablePanel.RowCount = 1;
        this.TopTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        this.TopTablePanel.Size = new System.Drawing.Size(688, 55);
        this.TopTablePanel.TabIndex = 9;
        // 
        // Header
        // 
        this.Header.BackColor = System.Drawing.Color.Transparent;
        this.Header.BindingSource = null;
        this.Header.DataFilter = null;
        this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
        this.Header.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
        this.Header.HoverText = null;
        this.Header.Location = new System.Drawing.Point(90, 3);
        this.Header.Name = "Header";
        this.Header.Size = new System.Drawing.Size(477, 49);
        this.Header.TabIndex = 0;
        this.Header.Text = "File Search";
        this.Header.ToolTip = null;
        // 
        // PictureBox
        // 
        this.Picture.BackColor = System.Drawing.Color.Transparent;
        this.Picture.BindingSource = this.BindingSource;
        this.Picture.DataFilter = null;
        this.Picture.Field = BudgetExecution.Field.AccountCode;
        this.Picture.HoverText = null;
        this.Picture.ImageList = null;
        this.Picture.Location = new System.Drawing.Point(3, 3);
        this.Picture.Name = "PictureBox";
        this.Picture.Padding = new System.Windows.Forms.Padding(1);
        this.Picture.Size = new System.Drawing.Size(31, 31);
        this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
        this.Picture.TabIndex = 1;
        this.Picture.TabStop = false;
        this.Picture.ToolTip = this.ToolTip;
        // 
        // MessageLabel
        // 
        this.MessageLabel.BackColor = System.Drawing.Color.Transparent;
        this.MessageLabel.BindingSource = null;
        this.MessageLabel.DataFilter = null;
        this.MessageLabel.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.MessageLabel.ForeColor = System.Drawing.Color.LightSteelBlue;
        this.MessageLabel.HoverText = null;
        this.MessageLabel.Location = new System.Drawing.Point(90, 371);
        this.MessageLabel.Name = "MessageLabel";
        this.MessageLabel.Padding = new System.Windows.Forms.Padding(1);
        this.MessageLabel.Size = new System.Drawing.Size(488, 23);
        this.MessageLabel.TabIndex = 12;
        this.MessageLabel.ToolTip = null;
        // 
        // SelectButton
        // 
        this.SelectButton.BackColor = System.Drawing.Color.Transparent;
        this.SelectButton.BindingSource = null;
        this.SelectButton.DataFilter = null;
        this.SelectButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.SelectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
        this.SelectButton.HoverText = "Select File";
        this.SelectButton.Location = new System.Drawing.Point(40, 411);
        this.SelectButton.Margin = new System.Windows.Forms.Padding(0);
        this.SelectButton.Name = "SelectButton";
        this.SelectButton.Padding = new System.Windows.Forms.Padding(1);
        this.SelectButton.Size = new System.Drawing.Size(120, 48);
        this.SelectButton.TabIndex = 11;
        this.SelectButton.Text = "Select";
        this.SelectButton.ToolTip = null;
        // 
        // CloseButton
        // 
        this.CloseButton.BackColor = System.Drawing.Color.Transparent;
        this.CloseButton.BindingSource = null;
        this.CloseButton.DataFilter = null;
        this.CloseButton.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
        this.CloseButton.HoverText = "Close Window";
        this.CloseButton.Location = new System.Drawing.Point(517, 411);
        this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
        this.CloseButton.Name = "CloseButton";
        this.CloseButton.Padding = new System.Windows.Forms.Padding(1);
        this.CloseButton.Size = new System.Drawing.Size(120, 48);
        this.CloseButton.TabIndex = 10;
        this.CloseButton.Text = "Close";
        this.CloseButton.ToolTip = null;
        // 
        // FileBrowser
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
        this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
        this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
        this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
        this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
        this.CaptionButtonHoverColor = System.Drawing.Color.Red;
        this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
        this.ClientSize = new System.Drawing.Size(688, 468);
        this.ControlBox = false;
        this.Controls.Add(this.MessageLabel);
        this.Controls.Add(this.SelectButton);
        this.Controls.Add(this.CloseButton);
        this.Controls.Add(this.TextBoxLayout);
        this.Controls.Add(this.TopTablePanel);
        this.DoubleBuffered = true;
        this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.ForeColor = System.Drawing.Color.LightGray;
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.MaximizeBox = false;
        this.MaximumSize = new System.Drawing.Size(700, 550);
        this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
        this.MinimizeBox = false;
        this.Name = "FileBrowser";
        this.ShowIcon = false;
        this.ShowMaximizeBox = false;
        this.ShowMinimizeBox = false;
        this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.TextBoxLayout.ResumeLayout(false);
        this.TextBoxLayout.PerformLayout();
        this.CheckBoxLayout.ResumeLayout(false);
        this.TopTablePanel.ResumeLayout(false);
        this.TopTablePanel.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
        this.ResumeLayout(false);

        }

        #endregion

        public TableLayoutPanel TextBoxLayout;
        public TableLayoutPanel CheckBoxLayout;
        public OpenFileDialog FileDialog;
        public SmallTip ToolTip;
        public TableLayoutPanel TopTablePanel;
        public Label Header;
        public Button CloseButton;
        public Button SelectButton;
        public BindingSource BindingSource;
        public Picture Picture;
        public ListBox FileList;
        public Label FoundLabel;
        public Label MessageLabel;
        public RadioButton LibraryRadioButton;
        public RadioButton PowerPointRadioButton;
        public RadioButton ExecutableRadioButton;
        public RadioButton TextRadioButton;
        public RadioButton SqlCeRadioButton;
        public RadioButton ExcelRadioButton;
        public RadioButton CsvRadioButton;
        public RadioButton AccessRadioButton;
        public RadioButton SQLiteRadioButton;
        public RadioButton SqlServerRadioButton;
        public RadioButton WordRadioButton;
        public RadioButton PdfRadioButton;
    }
    
}
