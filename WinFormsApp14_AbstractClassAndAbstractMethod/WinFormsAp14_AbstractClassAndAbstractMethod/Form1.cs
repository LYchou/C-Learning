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
            
            MessageBox.Show("" + monstor.attack());  // �w�q abstract method ���n�B�A���M base �S���w�q attack method�A��subclass��baseclass�ܼƥh�s�ɡA�o�ˤ��i�I�s����subclass�w�q���n�� abstract method
            // �`�N�]�� monstor �O abstrat class �N���� Monstor monstor = new Monstor(); �����������O����ơA�]�� abstract method �٨S�Q�w�q��C
        }
    }
}