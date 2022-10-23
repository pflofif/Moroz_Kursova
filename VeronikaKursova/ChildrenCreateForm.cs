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
using VeronikaKursova.Services.Exceptions;

namespace VeronikaKursova
{
    public partial class ChildrenCreateForm : Form
    {

        public ChildrenCreateForm()
        {
            InitializeComponent();
            InitDropList<Eateble>(comboBoxEatablePresents);
            InitDropList<Inedible>(comboBoxInediblePresents);
        }
        public Child ChildFromForm { get; private set; } = null!;

        private void button2_Click(object sender, EventArgs e)
        {
            var present = comboBoxEatablePresents.Enabled
                ? (Present?)comboBoxEatablePresents.SelectedItem
                : (Present?)comboBoxInediblePresents.SelectedItem;

            try
            {
                ChildFromForm = new Child
                (
                    textBoxName.Text,
                    Convert.ToInt32(numericAge.Value),
                    (string)checkedListBoxSex.SelectedItem,
                    Convert.ToInt32(textBoxCountOfGoodAct.Text),
                    Convert.ToInt32(textBoxCountOfBadAct.Text),
                    present
                );

                Close();
            }
            catch (NotGenderSelectException exp)
            {
                MessageBox.Show(exp.Message, "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                radioButtonInedible.Checked = false;
                radioButtonEatable.Enabled = true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Rethrow<NotFullInfoException>().Message, "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitDropList<T>(ComboBox comboBox) where T : class
        {
            var items = ReflectiveEnumerator.GetEnumerableOfType<T>().ToArray(); // ReflectiveEnumerator - клас для визначення всіх нащадків
            comboBox.Items.AddRange(items);                                     //GetEnumerableOfType - отримати всіх нащадків класу
            comboBox.Enabled = false;

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxEatablePresents.Enabled = radioButtonEatable.Checked;
            radioButtonInedible.Enabled = false;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxInediblePresents.SelectedIndex
                    = checkedListBoxSex.SelectedItem.Equals(Child.HumanGender.Woman
                        .ToString() ?? throw new NotFullInfoException()) // якщо дитина - дівчинка
                        ? 0 // Doll index in SelectedList
                        : 1; // ToyCar index in selectedLIst
                radioButtonEatable.Enabled = false;
            }
            catch (Exception exp)
            {
            }

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < checkedListBoxSex.Items.Count; ++ix)
                if (ix != e.Index) checkedListBoxSex.SetItemChecked(ix, false);
        }
    }
}
