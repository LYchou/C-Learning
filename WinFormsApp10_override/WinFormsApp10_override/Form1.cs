namespace WinFormsApp10_override
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player p = new Player("�i��");
            Monstor m = new Monstor("�v�ܩi");
            Villager v = new Villager("�ڤ��");  // ���Q�n�������]�n������O�A���w�g�~�� creature.attack(Creature)�A�h�i�H�Q�� override ��

            string message = p.attack(m);
            MessageBox.Show(message);

            message = v.attack(m);  // ���� attack method �Q�мg���F
            MessageBox.Show(message);

            message = v.move();
            MessageBox.Show(message);

            Creature m2 = m; // override �ĤG�Ӧn�B�A�έ� base class ���ܼƱ� derive class ���ܼƮɡA�o�˴N�i�H�I�s�� monstor.move() �Q override�� method
            message = m2.move();
            //message = m2.move2(); // �o�ӴN�I�s����A�]Creature�����N�S��move2�o�� method
            MessageBox.Show(message);
        }
    }
}