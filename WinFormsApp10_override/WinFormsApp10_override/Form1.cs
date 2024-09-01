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
            Player p = new Player("勇者");
            Monstor m = new Monstor("史萊姆");
            Villager v = new Villager("歐比王");  // 不想要讓村民也要攻擊能力，但已經繼承 creature.attack(Creature)，則可以利用 override 掉

            string message = p.attack(m);
            MessageBox.Show(message);

            message = v.attack(m);  // 村民 attack method 被覆寫掉了
            MessageBox.Show(message);

            message = v.move();
            MessageBox.Show(message);

            Creature m2 = m; // override 第二個好處，用個 base class 的變數接 derive class 的變數時，這樣就可以呼叫到 monstor.move() 被 override的 method
            message = m2.move();
            //message = m2.move2(); // 這個就呼叫不到，因Creature中本就沒有move2這個 method
            MessageBox.Show(message);
        }
    }
}