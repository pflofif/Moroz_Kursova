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
        }
        List<Child> children = new List<Child>(); // список дітей

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChildrenCreateForm createChildrenForm = new();
            createChildrenForm.ShowDialog();
            var child = createChildrenForm.childFromForm; // зчитування дитини з форми
            children.Add(child);                          // додавання дитини у список
            FillGrid();
        }

        public void FillGrid()
        {
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
            //List<Child> youngestchildren = new List<Child>();
            var minAge = children.MinBy(child=>child.Age).Age;
            var youngestchildren = children.Where(child => child.Age == minAge).ToList();
            foreach (var child in youngestchildren)
            {
                int rowId = dataGridViewYoungest.Rows.Add();
                DataGridViewRow row = dataGridViewYoungest.Rows[rowId];
                row.Cells[0].Value = child.Name;
                row.Cells[1].Value = child.Age;
            }
        }
    }
}