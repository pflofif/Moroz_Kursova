using VeronikaKursova.Model;
using VeronikaKursova.Model.InediblePresents;
using VeronikaKursova.Services;

namespace VeronikaKursova
{
    public partial class Form1 : Form
    {
        private readonly IChildCreator _childCreator;

        public Form1(IChildCreator childCreator)
        {
            _childCreator = childCreator;
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

            var children = new Child()
            {
                Name = "Veronika",
                Age = 18,
                BadActionCount = 0,
                GoodActionCount = 100,
                PresentType = new Doll(),
                Gender = Child.HumanGender.Women
            };
            label1.Text = children.ToString();
        }
    }
}