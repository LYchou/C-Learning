namespace WinFormsApp17_MultidimensionalArrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // 建構一維陣列 方法1
            int[] scores;
            scores = new int[100];
            scores[0] = 100;
            scores[1] = 95;
            scores[99] = 50;

            // 建構一維陣列 方法2
            int[] socres2 = new int[] { 12, 30, 100 };

            // 二維陣列
            int[,] board;
            board = new int[4, 4];
            board[0, 1] = 10;

            // 建構二維陣列 方法2
            int[,] board2;
            board2 = new int[,] { { 0, 1 }, { 2, 3 } };
            MessageBox.Show(" " + board2[1, 0]);

            // 矩陣相加

            // 列印矩陣

        }

        
    }
}