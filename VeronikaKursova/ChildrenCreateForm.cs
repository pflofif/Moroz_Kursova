using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using AutoMapper.Execution;
using VeronikaKursova.Model;
using VeronikaKursova.Model.InediblePresents;
using VeronikaKursova.Services;
using VeronikaKursova.Model.EatablePresents;

namespace VeronikaKursova
{
    public partial class ChildrenCreateForm : Form
    {
       
        public ChildrenCreateForm()
        {
            InitializeComponent();
            InitDropList<Eateble>(comboBox1);
            InitDropList<Inedible>(comboBox2);
        }
       // public string ChildData => _newChild.ToString();
        public Child childFromForm => _newChild;

        private Child _newChild = null!;

        private void button2_Click(object sender, EventArgs e)
        {   
            _newChild = new Child
            (
                textBox1.Text,
                //Age = Convert.ToInt32(textBox2.Text),
                Convert.ToInt32(numericAge.Value),
                (string)checkedListBox1.SelectedItem,
                Convert.ToInt32(textBox3.Text),
                Convert.ToInt32(textBox4.Text),
                (Present?)comboBox1.SelectedItem
            );
            Close();
        }

        private void InitDropList<T>(ComboBox comboBox) where T : class
        {
            var items = ReflectiveEnumerator.GetEnumerableOfType<T>().ToList();
            comboBox.Items.AddRange(items.ToArray());
            comboBox.Enabled = false;

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = radioButton1.Checked;
            radioButton2.Enabled = false;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = radioButton2.Checked;
            radioButton1.Enabled = false;
        }
    }
}
