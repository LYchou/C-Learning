using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace WinFormsApp19_gomoku
{
    abstract class Piece : PictureBox  // inherient
    {
        private static readonly int IMAGE_WIDTH = 50;
        public Piece(int x, int y)
        {
            this.BackColor = Color.Transparent;
            this.Location = new Point(x - IMAGE_WIDTH/2, y - IMAGE_WIDTH/2);
            this.Size = new Size(IMAGE_WIDTH, IMAGE_WIDTH);

        }


        // 因為我們不會知道子類別的資訊(黑還是白棋)，
        // 拿到棋子顏色，去 WhitePiece 和 BlackPiece 子類別寫 method 又會遇到別的問題
        // 問題為: 我們存棋子的陣列用的型別是 Piece (父類別)，父類別不能呼叫子類別的 method，
        // 除非，我們定義 abstract method，子類別分別去 override
        public abstract PieceType GetPieceType();
    }
}
