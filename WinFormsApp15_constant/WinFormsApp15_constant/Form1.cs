namespace WinFormsApp15_constant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = 2.0;
            double area = Math.PI * r * r;
            MessageBox.Show(" " + area);
        }
    }
}