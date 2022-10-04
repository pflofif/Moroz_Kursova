using VeronikaKursova.Services;

namespace VeronikaKursova
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button button1;
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGoodActions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBadActions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPresent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instractionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonYoungestChildrens = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ColumnPresentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCountOfPresent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewYoungest = new System.Windows.Forms.DataGridView();
            this.ColumnNameYoungest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAgeYoungest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYoungest)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            button1.Location = new System.Drawing.Point(443, 39);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(235, 50);
            button1.TabIndex = 1;
            button1.Text = "Create Child";
            button1.UseVisualStyleBackColor = false;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnAge,
            this.ColumnGender,
            this.ColumnGoodActions,
            this.ColumnBadActions,
            this.ColumnPresent});
            this.dataGridView.Location = new System.Drawing.Point(9, 90);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 29;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridView.Size = new System.Drawing.Size(669, 360);
            this.dataGridView.TabIndex = 2;
            //this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnName.Width = 125;
            // 
            // ColumnAge
            // 
            this.ColumnAge.HeaderText = "Age";
            this.ColumnAge.MinimumWidth = 6;
            this.ColumnAge.Name = "ColumnAge";
            this.ColumnAge.ReadOnly = true;
            this.ColumnAge.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnAge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnAge.Width = 125;
            // 
            // ColumnGender
            // 
            this.ColumnGender.HeaderText = "Gender";
            this.ColumnGender.MinimumWidth = 6;
            this.ColumnGender.Name = "ColumnGender";
            this.ColumnGender.ReadOnly = true;
            this.ColumnGender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnGender.Width = 125;
            // 
            // ColumnGoodActions
            // 
            this.ColumnGoodActions.HeaderText = "Count of good actions";
            this.ColumnGoodActions.MinimumWidth = 6;
            this.ColumnGoodActions.Name = "ColumnGoodActions";
            this.ColumnGoodActions.ReadOnly = true;
            this.ColumnGoodActions.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnGoodActions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnGoodActions.Width = 110;
            // 
            // ColumnBadActions
            // 
            this.ColumnBadActions.HeaderText = "Count of bad actions";
            this.ColumnBadActions.MinimumWidth = 6;
            this.ColumnBadActions.Name = "ColumnBadActions";
            this.ColumnBadActions.ReadOnly = true;
            this.ColumnBadActions.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnBadActions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnBadActions.Width = 110;
            // 
            // ColumnPresent
            // 
            this.ColumnPresent.HeaderText = "Present";
            this.ColumnPresent.MinimumWidth = 6;
            this.ColumnPresent.Name = "ColumnPresent";
            this.ColumnPresent.ReadOnly = true;
            this.ColumnPresent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnPresent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnPresent.Width = 110;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readFromFileToolStripMenuItem,
            this.instractionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // readFromFileToolStripMenuItem
            // 
            this.readFromFileToolStripMenuItem.Name = "readFromFileToolStripMenuItem";
            this.readFromFileToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.readFromFileToolStripMenuItem.Text = "Read from file";
            this.readFromFileToolStripMenuItem.Click += new System.EventHandler(this.readFromFileToolStripMenuItem_Click);
            // 
            // instractionsToolStripMenuItem
            // 
            this.instractionsToolStripMenuItem.Name = "instractionsToolStripMenuItem";
            this.instractionsToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.instractionsToolStripMenuItem.Text = "Instractions";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createChildToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // createChildToolStripMenuItem
            // 
            this.createChildToolStripMenuItem.Name = "createChildToolStripMenuItem";
            this.createChildToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.createChildToolStripMenuItem.Text = "Create child";
            // 
            // buttonYoungestChildrens
            // 
            this.buttonYoungestChildrens.CausesValidation = false;
            this.buttonYoungestChildrens.Location = new System.Drawing.Point(681, 39);
            this.buttonYoungestChildrens.Name = "buttonYoungestChildrens";
            this.buttonYoungestChildrens.Size = new System.Drawing.Size(209, 50);
            this.buttonYoungestChildrens.TabIndex = 4;
            this.buttonYoungestChildrens.Text = "The yongest childrens";
            this.buttonYoungestChildrens.UseVisualStyleBackColor = true;
            this.buttonYoungestChildrens.Click += new System.EventHandler(this.buttonYoungestChildrens_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView2.ColumnHeadersHeight = 28;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPresentType,
            this.ColumnCountOfPresent});
            this.dataGridView2.Location = new System.Drawing.Point(681, 284);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(209, 166);
            this.dataGridView2.TabIndex = 6;
            // 
            // ColumnPresentType
            // 
            this.ColumnPresentType.HeaderText = "Type";
            this.ColumnPresentType.MinimumWidth = 6;
            this.ColumnPresentType.Name = "ColumnPresentType";
            this.ColumnPresentType.ReadOnly = true;
            this.ColumnPresentType.Width = 110;
            // 
            // ColumnCountOfPresent
            // 
            this.ColumnCountOfPresent.HeaderText = "Count";
            this.ColumnCountOfPresent.MinimumWidth = 6;
            this.ColumnCountOfPresent.Name = "ColumnCountOfPresent";
            this.ColumnCountOfPresent.ReadOnly = true;
            this.ColumnCountOfPresent.Width = 110;
            // 
            // dataGridViewYoungest
            // 
            this.dataGridViewYoungest.AllowUserToAddRows = false;
            this.dataGridViewYoungest.AllowUserToDeleteRows = false;
            this.dataGridViewYoungest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewYoungest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewYoungest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewYoungest.ColumnHeadersHeight = 48;
            this.dataGridViewYoungest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNameYoungest,
            this.ColumnAgeYoungest});
            this.dataGridViewYoungest.Location = new System.Drawing.Point(681, 90);
            this.dataGridViewYoungest.Name = "dataGridViewYoungest";
            this.dataGridViewYoungest.ReadOnly = true;
            this.dataGridViewYoungest.RowHeadersVisible = false;
            this.dataGridViewYoungest.RowHeadersWidth = 51;
            this.dataGridViewYoungest.RowTemplate.Height = 48;
            this.dataGridViewYoungest.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewYoungest.Size = new System.Drawing.Size(209, 193);
            this.dataGridViewYoungest.TabIndex = 7;
            // 
            // ColumnNameYoungest
            // 
            this.ColumnNameYoungest.HeaderText = "Name";
            this.ColumnNameYoungest.MinimumWidth = 6;
            this.ColumnNameYoungest.Name = "ColumnNameYoungest";
            this.ColumnNameYoungest.ReadOnly = true;
            this.ColumnNameYoungest.Width = 110;
            // 
            // ColumnAgeYoungest
            // 
            this.ColumnAgeYoungest.HeaderText = "Age";
            this.ColumnAgeYoungest.MinimumWidth = 6;
            this.ColumnAgeYoungest.Name = "ColumnAgeYoungest";
            this.ColumnAgeYoungest.ReadOnly = true;
            this.ColumnAgeYoungest.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 453);
            this.Controls.Add(this.dataGridViewYoungest);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.buttonYoungestChildrens);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(button1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mykolay";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYoungest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private DataGridView dataGridView;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem instractionsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem createChildToolStripMenuItem;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnAge;
        private DataGridViewTextBoxColumn ColumnGender;
        private DataGridViewTextBoxColumn ColumnGoodActions;
        private DataGridViewTextBoxColumn ColumnBadActions;
        private DataGridViewTextBoxColumn ColumnPresent;
        private Button buttonYoungestChildrens;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn ColumnPresentType;
        private DataGridViewTextBoxColumn ColumnCountOfPresent;
        private DataGridView dataGridViewYoungest;
        private DataGridViewTextBoxColumn ColumnNameYoungest;
        private DataGridViewTextBoxColumn ColumnAgeYoungest;
        private ToolStripMenuItem readFromFileToolStripMenuItem;
    }
}