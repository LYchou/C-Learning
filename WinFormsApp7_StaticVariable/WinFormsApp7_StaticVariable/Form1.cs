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

            // 當不小心更改到 s1.passScore 那 s1 的及格標準與其他不同
            // 如下
            s1.passScore = 10;
            MessageBox.Show(" "+s1.isPass() + "  -  " + s2.isPass() + "  -  " + s3.isPass());

            // 如果想要更改及格標準，直接針對該class 的 static var 更改，這樣所有 class 都更改了
            Student.passScore_static = 10;
            MessageBox.Show(" " + s1.isPass_UsingStaticVar() + "  -  " + s2.isPass_UsingStaticVar() + "  -  " + s3.isPass_UsingStaticVar());

        }
    }
}