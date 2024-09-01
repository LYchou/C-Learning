using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp19_gomoku
{
    class Game
    {
        private PieceType currentPlayer = PieceType.BLACK;
        private PieceType winner = PieceType.NONE;
        public PieceType Winner { get { return winner; } }
        private Board board = new Board();

        public bool CanBePlaced(int x, int y)
        {
            return board.CanBePlaced(x, y);
        }

        public Piece PlaceAPiece( int x, int y)
        {
            Piece piece = board.PlaceAPiece(x, y, currentPlayer);
            if (piece != null)
            {

                // 檢查是否下棋的人有沒有獲勝
                CheckWinner();


                // 交換選手
                if (currentPlayer == PieceType.BLACK)
                    currentPlayer = PieceType.WHITE;
                else if (currentPlayer == PieceType.WHITE)
                    currentPlayer = PieceType.BLACK;
                return piece;
            }

            return null;
        }

        public void CheckWinner()
        {
            int centerX = board.LastPlacedNode.X;
            int centerY = board.LastPlacedNode.Y;


            DirectionOfLineConnectionCount directionOfLineConnectionCount = new DirectionOfLineConnectionCount();
            // 檢查八個不同方向
            for ( int xDir = -1; xDir <= 1; xDir++)
            {
                for ( int yDir = -1; yDir <= 1; yDir++)
                {
                    // 排除中間情況 (x,y方向都不動)
                    if (xDir == 0 && yDir == 0)
                        continue;

                    // 紀錄現在看到幾顆相同的棋子
                    int count = 1;
                    while (count < 5)
                    {

                        int targetX = centerX + count*xDir;
                        int targetY = centerY + count*yDir;

                        // 檢查顏色是否相同
                        if (targetX < 0 || targetX >= Board.NODE_COUNT ||
                           targetY < 0 || targetY >= Board.NODE_COUNT ||
                           board.GetPieceType(targetX, targetY) != currentPlayer) // 附註:這麼長的判斷式，or 的條件只有有出現true，他就回傳true，就不會繼續檢查下面條件
                            break;

                        count++;
                    }

                    if (yDir == 0)
                        directionOfLineConnectionCount.Vertical_count += count;
                    else if (xDir == 0)
                        directionOfLineConnectionCount.Horizontal_count += count;
                    else if (xDir * yDir > 0)
                        directionOfLineConnectionCount.RightSlash_count += count;
                    else if (yDir * xDir < 0)
                        directionOfLineConnectionCount.LeftSlash_count += count;

                    if (directionOfLineConnectionCount.CheckWinner())
                        //count = 5;
                        winner = currentPlayer;

                    /*
                    // 檢查是否看到五顆棋子
                    if (count == 5)
                        winner = currentPlayer;
                    */
                }
            }

            

        }
    }
}
