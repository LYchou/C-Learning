namespace WinFormsApp5_constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student(123, 3, "mike");
            Student s2 = new Student(124, "Tim");
            MessageBox.Show(s.say());
            MessageBox.Show(s2.say());
        }
    }
}