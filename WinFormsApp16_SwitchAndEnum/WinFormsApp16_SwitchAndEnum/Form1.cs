namespace WinFormsApp16_SwitchAndEnum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Monstor monstor = new Monstor();
            monstor.move(Direction.UP);
            monstor.move(Direction.UP);
            monstor.move(Direction.LEFT);
            MessageBox.Show(monstor.getPosition());
        }
    }
}