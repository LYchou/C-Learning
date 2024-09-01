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

        private void Form1_MouseDown(object sender, MouseEventArgs e)  // object sender 先不用理他 ；MouseEventArgs e 存一些資訊，例如滑鼠點擊的位置
        {

            Piece piece = game.PlaceAPiece(e.X, e.Y);
            if (piece!=null)
            {
                this.Controls.Add(piece);  

                // 檢查是否有人獲勝
                if (game.Winner == PieceType.BLACK)
                {
                    MessageBox.Show("黑色獲勝");
                }
                else if (game.Winner == PieceType.WHITE)
                {
                    MessageBox.Show("白色獲勝");
                }
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // 當滑鼠移動，的處理
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