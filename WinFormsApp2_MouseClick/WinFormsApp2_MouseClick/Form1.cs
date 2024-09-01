namespace WinFormsApp2_MouseClick
{
    public partial class Form1 : Form
    {
        int times = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            times++;
            timesLabel.Text = "你已經按了 ..."+ times + "下";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            times = 0;
            timesLabel.Text = "你已經按了 ..." + times + "下";
        }
    }
}