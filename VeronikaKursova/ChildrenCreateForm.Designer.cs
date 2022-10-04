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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CreateChildButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.numericAge = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "NameTextBox";
            this.textBox1.Location = new System.Drawing.Point(183, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Name";
            this.textBox1.Size = new System.Drawing.Size(200, 27);
            this.textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.AccessibleDescription = "";
            this.textBox3.Location = new System.Drawing.Point(183, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Count of good actions";
            this.textBox3.Size = new System.Drawing.Size(200, 27);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(183, 226);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Count of bad actions";
            this.textBox4.Size = new System.Drawing.Size(200, 27);
            this.textBox4.TabIndex = 3;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 298);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Eatable Presents";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(40, 302);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 24);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Eatable";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(40, 342);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(84, 24);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Inedible";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(143, 347);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(202, 28);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.Text = "Inedible Presents";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Male",
            "Woman"});
            this.checkedListBox1.Location = new System.Drawing.Point(301, 83);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(84, 48);
            this.checkedListBox1.TabIndex = 10;
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
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CreateChildButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Name = "ChildrenCreateForm";
            this.Text = "ChildrenCreateForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button CreateChildButton;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ComboBox comboBox2;
        private CheckedListBox checkedListBox1;
        private NumericUpDown numericAge;
        private Label label1;
    }
}