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

            // �غc�@���}�C ��k1
            int[] scores;
            scores = new int[100];
            scores[0] = 100;
            scores[1] = 95;
            scores[99] = 50;

            // �غc�@���}�C ��k2
            int[] socres2 = new int[] { 12, 30, 100 };

            // �G���}�C
            int[,] board;
            board = new int[4, 4];
            board[0, 1] = 10;

            // �غc�G���}�C ��k2
            int[,] board2;
            board2 = new int[,] { { 0, 1 }, { 2, 3 } };
            MessageBox.Show(" " + board2[1, 0]);

            // �x�}�ۥ[

            // �C�L�x�}

        }

        
    }
}