namespace WinFormsApp20_Polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player c = new Player("¤p¤s¿ß");
            Villager v = new Villager();
            Monstor m = new Monstor();
            m.attack(c);
            m.attack(v);
            v.injured(10);
            c.injured(10);
            MessageBox.Show(c.say());
            MessageBox.Show(v.say());
        }
    }
}