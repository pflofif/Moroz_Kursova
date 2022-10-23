using VeronikaKursova.Model;
using VeronikaKursova.Model.InediblePresents;
using VeronikaKursova.Services;
using VeronikaKursova.Services.Exceptions;


namespace VeronikaKursova
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitDataGridViewPresentCount();
        }

        List<Child> children = new List<Child>(); // список дітей

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonCreateChild_Click(object sender, EventArgs e)
        {
            ChildrenCreateForm createChildrenForm = new();
            createChildrenForm.ShowDialog();
            var child = createChildrenForm.ChildFromForm; // зчитування дитини з форми
            var childToFind = children.FirstOrDefault(c => c.Name == child.Name); // перевіряємо чи дитина з таким іменем існує
            if (childToFind is null) // якщо дитини в списку немає
            {
                children.Add(child);
            }
            else
            {
                dataGridView.Rows.RemoveAt(children.IndexOf(childToFind));
                children[children.IndexOf(childToFind)] = child;
            }
            FillGrid();
            PresentCount();
        }

        public void FillGrid()     // запис у таблицю
        {
            dataGridView.Rows.Clear();
            //var rowCount = ;
            foreach (var child in children)
            {
                int rowId = dataGridView.Rows.Add();
                DataGridViewRow row = dataGridView.Rows[rowId];
                row.Cells[0].Value = child.Name;
                row.Cells[1].Value = child.Age;
                row.Cells[2].Value = child.Gender;
                row.Cells[3].Value = child.GoodActionCount;
                row.Cells[4].Value = child.BadActionCount;
                row.Cells[5].Value = child.PresentType;
            }
        }

        private void buttonYoungestChildrens_Click(object sender, EventArgs e)
        {
            try
            {
                int minAge = children.MinBy(child => child.Age)!.Age;
                var youngestchildren = children.Where(child => child.Age == minAge).ToList();
                foreach (var child in youngestchildren)
                {
                    int rowId = dataGridViewYoungest.Rows.Add();
                    DataGridViewRow row = dataGridViewYoungest.Rows[rowId];
                    row.Cells[0].Value = child.Name;
                    row.Cells[1].Value = child.Age;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Rethrow<NoChildrenException>().Message, "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void readFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string path = @"C:\Users\Вероніка\source\repos\Moroz_Kursova\VeronikaKursova\children.json";
            List<Child> child = new List<Child>();
            try
            {
                child.AddRange(
                    FileWorker.ReadFromFile<List<Child>>(path) // FileWorker - клас, для роботи з json
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Rethrow<EmptyFileException>().Message, "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var ch in child)
            {
                var childToFind =
                    children.FirstOrDefault(c => c.Name == ch.Name); // перевіряємо чи дитина з таким іменем існує
                if (childToFind is null) // якщо дитини в списку немає
                {
                    children.Add(ch);
                }
                else
                {
                    dataGridView.Rows.RemoveAt(children.IndexOf(childToFind));
                    children[children.IndexOf(childToFind)] = ch;
                }
            }


            FillGrid();
            PresentCount();
        }

        public void PresentCount()
        {
            var present = children.GroupBy(child => child?.PresentType?.ToString()); // GroupBy повертає словник IEnumerable<IGrouping<string?, Child>>
            foreach (DataGridViewRow row in dataGridViewPresentCount.Rows)
            {
                var presentId = present.FirstOrDefault(p => p.Key == row.Cells[0].Value);
                row.Cells[1].Value = presentId?.Count() ?? 0;
            }
        }
        private void InitDataGridViewPresentCount() // заповнення таблиці з к-стю подарунків
        {
            FillDataGridWithType<Eateble>();
            FillDataGridWithType<Inedible>();

            int rowId = dataGridViewPresentCount.Rows.Add();
            DataGridViewRow row = dataGridViewPresentCount.Rows[rowId];
            row.Cells[0].Value = new Rizka().ToString();
            row.Cells[1].Value = 0;
        }
        private void FillDataGridWithType<T>() where T : class
        {
            var eatablePresents = ReflectiveEnumerator.GetEnumerableOfType<T>()
                            .Select(type => type?.ToString());
            foreach (var eateble in eatablePresents)
            {
                int rowId = dataGridViewPresentCount.Rows.Add();
                DataGridViewRow row = dataGridViewPresentCount.Rows[rowId];
                row.Cells[0].Value = eateble;
                row.Cells[1].Value = 0;
            }
        }

        private void ButtonDeleteChild_Click(object sender, EventArgs e)
        {
            try
            {
                children.RemoveAt(dataGridView.CurrentCell.RowIndex);
                FillGrid();
                PresentCount();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Rethrow<NoChildrenException>().Message, "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}