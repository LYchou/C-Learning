namespace WinFormsApp6_static
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 20;

            
            MessageBox.Show(" " + Math_SelfDefined.max_static(a, b));

            a = 30;
            Math_SelfDefined math = new Math_SelfDefined();
            MessageBox.Show(" "+math.max(a, b));
            

        }
    }
}