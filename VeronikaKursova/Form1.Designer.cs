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
            this.buttonCreateChild = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instractionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteChildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonYoungestChildrens = new System.Windows.Forms.Button();
            this.dataGridViewPresentCount = new System.Windows.Forms.DataGridView();
            this.ColumnPresentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCountOfPresent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewYoungest = new System.Windows.Forms.DataGridView();
            this.ColumnNameYoungest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAgeYoungest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonDeleteChild = new System.Windows.Forms.Button();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGoodActions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBadActions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPresent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresentCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYoungest)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateChild
            // 
            this.buttonCreateChild.FlatAppearance.BorderSize = 0;
            this.buttonCreateChild.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCreateChild.Location = new System.Drawing.Point(132, 37);
            this.buttonCreateChild.Name = "buttonCreateChild";
            this.buttonCreateChild.Size = new System.Drawing.Size(270, 50);
            this.buttonCreateChild.TabIndex = 1;
            this.buttonCreateChild.Text = "Create Child";
            this.buttonCreateChild.UseVisualStyleBackColor = false;
            this.buttonCreateChild.Click += new System.EventHandler(this.buttonCreateChild_Click);
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
            this.dataGridView.Size = new System.Drawing.Size(669, 414);
            this.dataGridView.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 28);
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
            this.readFromFileToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.readFromFileToolStripMenuItem.Text = "Read from file";
            this.readFromFileToolStripMenuItem.Click += new System.EventHandler(this.readFromFileToolStripMenuItem_Click);
            // 
            // instractionsToolStripMenuItem
            // 
            this.instractionsToolStripMenuItem.Name = "instractionsToolStripMenuItem";
            this.instractionsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.instractionsToolStripMenuItem.Text = "Instractions";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createChildToolStripMenuItem,
            this.deleteChildToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // createChildToolStripMenuItem
            // 
            this.createChildToolStripMenuItem.Name = "createChildToolStripMenuItem";
            this.createChildToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createChildToolStripMenuItem.Text = "Create child";
            this.createChildToolStripMenuItem.Click += new System.EventHandler(this.buttonCreateChild_Click);
            // 
            // deleteChildToolStripMenuItem
            // 
            this.deleteChildToolStripMenuItem.Name = "deleteChildToolStripMenuItem";
            this.deleteChildToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deleteChildToolStripMenuItem.Text = "Delete Child";
            this.deleteChildToolStripMenuItem.Click += new System.EventHandler(this.ButtonDeleteChild_Click);
            // 
            // buttonYoungestChildrens
            // 
            this.buttonYoungestChildrens.CausesValidation = false;
            this.buttonYoungestChildrens.Location = new System.Drawing.Point(681, 39);
            this.buttonYoungestChildrens.Name = "buttonYoungestChildrens";
            this.buttonYoungestChildrens.Size = new System.Drawing.Size(270, 50);
            this.buttonYoungestChildrens.TabIndex = 4;
            this.buttonYoungestChildrens.Text = "The yongest childrens";
            this.buttonYoungestChildrens.UseVisualStyleBackColor = true;
            this.buttonYoungestChildrens.Click += new System.EventHandler(this.buttonYoungestChildrens_Click);
            // 
            // dataGridViewPresentCount
            // 
            this.dataGridViewPresentCount.AllowUserToAddRows = false;
            this.dataGridViewPresentCount.AllowUserToDeleteRows = false;
            this.dataGridViewPresentCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPresentCount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewPresentCount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridViewPresentCount.ColumnHeadersHeight = 28;
            this.dataGridViewPresentCount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPresentType,
            this.ColumnCountOfPresent});
            this.dataGridViewPresentCount.Location = new System.Drawing.Point(681, 289);
            this.dataGridViewPresentCount.Name = "dataGridViewPresentCount";
            this.dataGridViewPresentCount.ReadOnly = true;
            this.dataGridViewPresentCount.RowHeadersVisible = false;
            this.dataGridViewPresentCount.RowHeadersWidth = 140;
            this.dataGridViewPresentCount.RowTemplate.Height = 29;
            this.dataGridViewPresentCount.Size = new System.Drawing.Size(270, 212);
            this.dataGridViewPresentCount.TabIndex = 6;
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
            this.dataGridViewYoungest.Size = new System.Drawing.Size(270, 193);
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
            // ButtonDeleteChild
            // 
            this.ButtonDeleteChild.Location = new System.Drawing.Point(408, 37);
            this.ButtonDeleteChild.Name = "ButtonDeleteChild";
            this.ButtonDeleteChild.Size = new System.Drawing.Size(270, 50);
            this.ButtonDeleteChild.TabIndex = 8;
            this.ButtonDeleteChild.Text = "Delete Child";
            this.ButtonDeleteChild.UseVisualStyleBackColor = true;
            this.ButtonDeleteChild.Click += new System.EventHandler(this.ButtonDeleteChild_Click);
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
            this.ColumnAge.Width = 106;
            // 
            // ColumnGender
            // 
            this.ColumnGender.HeaderText = "Gender";
            this.ColumnGender.MinimumWidth = 6;
            this.ColumnGender.Name = "ColumnGender";
            this.ColumnGender.ReadOnly = true;
            this.ColumnGender.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnGender.Width = 107;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 513);
            this.Controls.Add(this.ButtonDeleteChild);
            this.Controls.Add(this.dataGridViewYoungest);
            this.Controls.Add(this.dataGridViewPresentCount);
            this.Controls.Add(this.buttonYoungestChildrens);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonCreateChild);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mykolay";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPresentCount)).EndInit();
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
        private Button buttonYoungestChildrens;
        private DataGridView dataGridViewPresentCount;
        private DataGridView dataGridViewYoungest;
        private DataGridViewTextBoxColumn ColumnNameYoungest;
        private DataGridViewTextBoxColumn ColumnAgeYoungest;
        private ToolStripMenuItem readFromFileToolStripMenuItem;
        private DataGridViewTextBoxColumn ColumnPresentType;
        private DataGridViewTextBoxColumn ColumnCountOfPresent;
        private ToolStripMenuItem deleteChildToolStripMenuItem;
        private Button ButtonDeleteChild;
        private Button buttonCreateChild;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnAge;
        private DataGridViewTextBoxColumn ColumnGender;
        private DataGridViewTextBoxColumn ColumnGoodActions;
        private DataGridViewTextBoxColumn ColumnBadActions;
        private DataGridViewTextBoxColumn ColumnPresent;
    }
}