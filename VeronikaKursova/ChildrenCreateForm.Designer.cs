namespace VeronikaKursova
{
    partial class ChildrenCreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCountOfGoodAct = new System.Windows.Forms.TextBox();
            this.textBoxCountOfBadAct = new System.Windows.Forms.TextBox();
            this.CreateChildButton = new System.Windows.Forms.Button();
            this.comboBoxEatablePresents = new System.Windows.Forms.ComboBox();
            this.radioButtonEatable = new System.Windows.Forms.RadioButton();
            this.radioButtonInedible = new System.Windows.Forms.RadioButton();
            this.comboBoxInediblePresents = new System.Windows.Forms.ComboBox();
            this.checkedListBoxSex = new System.Windows.Forms.CheckedListBox();
            this.numericAge = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.AccessibleName = "NameTextBox";
            this.textBoxName.Location = new System.Drawing.Point(183, 32);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Name";
            this.textBoxName.Size = new System.Drawing.Size(200, 27);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxCountOfGoodAct
            // 
            this.textBoxCountOfGoodAct.AccessibleDescription = "";
            this.textBoxCountOfGoodAct.Location = new System.Drawing.Point(183, 159);
            this.textBoxCountOfGoodAct.Name = "textBoxCountOfGoodAct";
            this.textBoxCountOfGoodAct.PlaceholderText = "Count of good actions";
            this.textBoxCountOfGoodAct.Size = new System.Drawing.Size(200, 27);
            this.textBoxCountOfGoodAct.TabIndex = 2;
            // 
            // textBoxCountOfBadAct
            // 
            this.textBoxCountOfBadAct.Location = new System.Drawing.Point(183, 226);
            this.textBoxCountOfBadAct.Name = "textBoxCountOfBadAct";
            this.textBoxCountOfBadAct.PlaceholderText = "Count of bad actions";
            this.textBoxCountOfBadAct.Size = new System.Drawing.Size(200, 27);
            this.textBoxCountOfBadAct.TabIndex = 3;
            // 
            // CreateChildButton
            // 
            this.CreateChildButton.Location = new System.Drawing.Point(385, 298);
            this.CreateChildButton.Name = "CreateChildButton";
            this.CreateChildButton.Size = new System.Drawing.Size(161, 77);
            this.CreateChildButton.TabIndex = 5;
            this.CreateChildButton.Text = "Create Child";
            this.CreateChildButton.UseVisualStyleBackColor = true;
            this.CreateChildButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxEatablePresents
            // 
            this.comboBoxEatablePresents.FormattingEnabled = true;
            this.comboBoxEatablePresents.Location = new System.Drawing.Point(145, 298);
            this.comboBoxEatablePresents.Name = "comboBoxEatablePresents";
            this.comboBoxEatablePresents.Size = new System.Drawing.Size(200, 28);
            this.comboBoxEatablePresents.TabIndex = 6;
            this.comboBoxEatablePresents.Text = "Eatable Presents";
            // 
            // radioButtonEatable
            // 
            this.radioButtonEatable.AutoSize = true;
            this.radioButtonEatable.Location = new System.Drawing.Point(40, 302);
            this.radioButtonEatable.Name = "radioButtonEatable";
            this.radioButtonEatable.Size = new System.Drawing.Size(80, 24);
            this.radioButtonEatable.TabIndex = 7;
            this.radioButtonEatable.TabStop = true;
            this.radioButtonEatable.Text = "Eatable";
            this.radioButtonEatable.UseVisualStyleBackColor = true;
            this.radioButtonEatable.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonInedible
            // 
            this.radioButtonInedible.AutoSize = true;
            this.radioButtonInedible.Location = new System.Drawing.Point(40, 342);
            this.radioButtonInedible.Name = "radioButtonInedible";
            this.radioButtonInedible.Size = new System.Drawing.Size(84, 24);
            this.radioButtonInedible.TabIndex = 8;
            this.radioButtonInedible.TabStop = true;
            this.radioButtonInedible.Text = "Inedible";
            this.radioButtonInedible.UseVisualStyleBackColor = true;
            this.radioButtonInedible.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comboBoxInediblePresents
            // 
            this.comboBoxInediblePresents.Enabled = false;
            this.comboBoxInediblePresents.FormattingEnabled = true;
            this.comboBoxInediblePresents.Location = new System.Drawing.Point(143, 347);
            this.comboBoxInediblePresents.Name = "comboBoxInediblePresents";
            this.comboBoxInediblePresents.Size = new System.Drawing.Size(202, 28);
            this.comboBoxInediblePresents.TabIndex = 9;
            this.comboBoxInediblePresents.Text = "Inedible Presents";
            // 
            // checkedListBoxSex
            // 
            this.checkedListBoxSex.CheckOnClick = true;
            this.checkedListBoxSex.FormattingEnabled = true;
            this.checkedListBoxSex.Items.AddRange(new object[] {
            "Male",
            "Woman"});
            this.checkedListBoxSex.Location = new System.Drawing.Point(301, 83);
            this.checkedListBoxSex.Name = "checkedListBoxSex";
            this.checkedListBoxSex.Size = new System.Drawing.Size(84, 48);
            this.checkedListBoxSex.TabIndex = 10;
            this.checkedListBoxSex.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // numericAge
            // 
            this.numericAge.Location = new System.Drawing.Point(230, 93);
            this.numericAge.Maximum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.numericAge.Name = "numericAge";
            this.numericAge.Size = new System.Drawing.Size(42, 27);
            this.numericAge.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Age";
            // 
            // ChildrenCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 433);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericAge);
            this.Controls.Add(this.checkedListBoxSex);
            this.Controls.Add(this.comboBoxInediblePresents);
            this.Controls.Add(this.radioButtonInedible);
            this.Controls.Add(this.radioButtonEatable);
            this.Controls.Add(this.comboBoxEatablePresents);
            this.Controls.Add(this.CreateChildButton);
            this.Controls.Add(this.textBoxCountOfBadAct);
            this.Controls.Add(this.textBoxCountOfGoodAct);
            this.Controls.Add(this.textBoxName);
            this.Name = "ChildrenCreateForm";
            this.Text = "ChildrenCreateForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxCountOfGoodAct;
        private TextBox textBoxCountOfBadAct;
        private Button CreateChildButton;
        private ComboBox comboBoxEatablePresents;
        private RadioButton radioButtonEatable;
        private RadioButton radioButtonInedible;
        private ComboBox comboBoxInediblePresents;
        private CheckedListBox checkedListBoxSex;
        private NumericUpDown numericAge;
        private Label label1;
    }
}