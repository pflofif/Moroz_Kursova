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

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //var children = new Child()
            //{
            //    Name = "Veronika",
            //    Age = 18,
            //    BadActionCount = 0,
            //    GoodActionCount = 100,
            //    PresentType = new Doll(),
            //    Gender = Child.HumanGender.Women
            //};
            ChildrenCreateForm createChildren = new();
            createChildren.ShowDialog();
            var child = createChildren.ChildData;
            //var name = createChildren.TextBox1.Name;
            // var content = createChildren.TextBox1.Text;
            label1.Text = child;
        }
    }
}