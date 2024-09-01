namespace WinFormsApp11_OverrideVsHiding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fruit a = new Aaple();
            Fruit o = new Orange();
            Orange o2 = new Orange();

            MessageBox.Show(a.saySomeThing());
            MessageBox.Show(o.saySomeThing());  // hiding method ，用 Fruit 接 Orange 只能看到 Fruit 的 method，否則看下一行
            MessageBox.Show(o2.saySomeThing());
        }
    }
}