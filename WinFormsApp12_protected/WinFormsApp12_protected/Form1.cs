namespace WinFormsApp12_protected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Monstor m = new Monstor();
            Monstor s = new Slime();
            Slime s2 = new Slime();

            MessageBox.Show(" " + s.getHp());
            MessageBox.Show(s2.say());
        }
    }
}