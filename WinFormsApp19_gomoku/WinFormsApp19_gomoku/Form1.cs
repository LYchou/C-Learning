namespace WinFormsApp19_gomoku
{
    public partial class Form1 : Form
    {

        private Game game = new Game();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)  // object sender �����βz�L �FMouseEventArgs e �s�@�Ǹ�T�A�Ҧp�ƹ��I������m
        {

            Piece piece = game.PlaceAPiece(e.X, e.Y);
            if (piece!=null)
            {
                this.Controls.Add(piece);  

                // �ˬd�O�_���H���
                if (game.Winner == PieceType.BLACK)
                {
                    MessageBox.Show("�¦����");
                }
                else if (game.Winner == PieceType.WHITE)
                {
                    MessageBox.Show("�զ����");
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // ��ƹ����ʡA���B�z
            if (game.CanBePlaced(e.X, e.Y))
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }

        }
    }
}