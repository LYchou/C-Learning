namespace WinFormsApp7_StaticVariable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s1 = new Student(30, "mike");
            Student s2 = new Student(70, "Time");
            Student s3 = new Student(20, "Time");

            // ���p�ߧ��� s1.passScore �� s1 ���ή�зǻP��L���P
            // �p�U
            s1.passScore = 10;
            MessageBox.Show(" "+s1.isPass() + "  -  " + s2.isPass() + "  -  " + s3.isPass());

            // �p�G�Q�n���ή�зǡA�����w���class �� static var ���A�o�˩Ҧ� class �����F
            Student.passScore_static = 10;
            MessageBox.Show(" " + s1.isPass_UsingStaticVar() + "  -  " + s2.isPass_UsingStaticVar() + "  -  " + s3.isPass_UsingStaticVar());

        }
    }
}