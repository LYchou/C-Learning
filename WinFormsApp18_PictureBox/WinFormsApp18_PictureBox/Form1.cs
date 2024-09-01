namespace WinFormsApp18_PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            logo.Image = Resource1.logo;
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}