using VeronikaKursova.Model;
using VeronikaKursova.Model.InediblePresents;
using VeronikaKursova.Services;


namespace VeronikaKursova
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitDataGridViewPresentCount();
        }

        List<Child> children = new List<Child>(); // ������ ����

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonCreateChild_Click(object sender, EventArgs e)
        {
            ChildrenCreateForm createChildrenForm = new();
            createChildrenForm.ShowDialog();
            var child = createChildrenForm.ChildFromForm; // ���������� ������ � �����
            var childToFind = children.FirstOrDefault(c => c.Name == child.Name); // ���������� �� ������ � ����� ������ ����
            if (childToFind is null) // ���� ������ � ������ ����
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

        public void FillGrid()     // ����� � �������
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
            if (children.Any())
            {
                var minAge = children.MinBy(child => child.Age)!.Age;

                var youngestchildren = children.Where(child => child.Age == minAge).ToList();
                foreach (var child in youngestchildren)
                {
                    int rowId = dataGridViewYoungest.Rows.Add();
                    DataGridViewRow row = dataGridViewYoungest.Rows[rowId];
                    row.Cells[0].Value = child.Name;
                    row.Cells[1].Value = child.Age;
                }
            }
            else
            {
                MessageBox.Show("There are no childrens\nPlease, add child or read information from file.", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void readFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string path = @"C:\Users\�������\source\repos\Moroz_Kursova\VeronikaKursova\children.json";
            List<Child> child = new List<Child>();
            child.AddRange(FileWorker.ReadFromFile<List<Child>>(path)); // FileWorker - ����, ��� ������ � json
            for (int i = 0; i < child.Count; i++)
            {
                var childToFind = children.FirstOrDefault(c => c.Name == child[i].Name); // ���������� �� ������ � ����� ������ ����
                if (childToFind is null) // ���� ������ � ������ ����
                {
                    children.Add(child[i]);
                }
                else
                {
                    dataGridView.Rows.RemoveAt(children.IndexOf(childToFind));
                    children[children.IndexOf(childToFind)] = child[i];
                }
            }
            FillGrid();
            PresentCount();
        }

        public void PresentCount()
        {
            var present = children.GroupBy(child => child?.PresentType?.ToString()); // GroupBy ������� ������� IEnumerable<IGrouping<string?, Child>>
            foreach (DataGridViewRow row in dataGridViewPresentCount.Rows)
            {
                var presentId = present.FirstOrDefault(p => p.Key == row.Cells[0].Value);
                row.Cells[1].Value = presentId?.Count() ?? 0;
            }
        }
        private void InitDataGridViewPresentCount() // ���������� ������� � �-��� ���������
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
            if (children.Any())
            {
                children.RemoveAt(dataGridView.CurrentCell.RowIndex);
                FillGrid();
                PresentCount();
            }
            else
            {
                MessageBox.Show("There are no childrens\nPlease, add child or read information from file.", "Ops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}