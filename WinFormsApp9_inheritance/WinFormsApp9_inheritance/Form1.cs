namespace WinFormsApp9_inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Villager vi = new Villager();
            Monstor mon = new Monstor();

            MessageBox.Show(" " + vi.Talk());

            mon.attack(vi);
            MessageBox.Show(" " + vi.GetHp());

            int another_attack_point = 70;
            vi.HP -= another_attack_point;
            MessageBox.Show(" " + vi.HP);

        }
    }
}