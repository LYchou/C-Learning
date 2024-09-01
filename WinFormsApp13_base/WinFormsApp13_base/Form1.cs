namespace WinFormsApp13_base
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Slim s = new Slim();
            MessageBox.Show(" " + s.introduceSelf());
        }
    }
}