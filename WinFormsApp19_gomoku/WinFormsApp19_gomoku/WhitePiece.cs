﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp19_gomoku
{
    class WhitePiece : Piece
    {
        public WhitePiece(int x, int y) : base(x,y)
        {
            this.Image = Resource1.white;
        }

        public override PieceType GetPieceType()
        {
            return PieceType.WHITE;
        }
    }
}
