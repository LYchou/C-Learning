namespace WinFormsApp3_Stars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int row = (int)rowChooser.Value; //Value是Decimal型別的資料，要轉成int才能存到int的變數中
            string result = "";

            for (int i = 0; i <= row; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    result += "*";
                }
                result += "\r\n";
            }

            MessageBox.Show(result);

        }
    }
}