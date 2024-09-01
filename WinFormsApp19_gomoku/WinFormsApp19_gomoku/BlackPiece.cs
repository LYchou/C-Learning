using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp19_gomoku
{
    class BlackPiece : Piece
    {
        public BlackPiece(int x, int y) : base(x ,y)
        {
            this.Image = Resource1.black;
        }

        public override PieceType GetPieceType()
        {
            return PieceType.BLACK;
        }
    }
}
