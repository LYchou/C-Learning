namespace WinFormsApp4_DeclareClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = "¼B";
            s.StudentID = 123;
            s.Grade = 3;
            MessageBox.Show(s.Say());
        }
    }
}