namespace WinFormsAp14_AbstractClassAndAbstractMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Monstor monstor = new Slim();
            
            MessageBox.Show("" + monstor.attack());  // 定義 abstract method 的好處，雖然 base 沒有定義 attack method，但subclass用baseclass變數去存時，這樣仍可呼叫的到subclass定義的好的 abstract method
            // 注意因為 monstor 是 abstrat class 就不能 Monstor monstor = new Monstor(); 不能把虛擬類別實體化，因為 abstract method 還沒被定義到。
        }
    }
}