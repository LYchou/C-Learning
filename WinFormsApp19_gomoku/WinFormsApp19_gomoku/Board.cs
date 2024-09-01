using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp19_gomoku
{
    class Board
    {
        public static readonly int NODE_COUNT = 9;

        private static readonly Point NO_MATCH_NODE = new Point(-1, -1);  // 不會用到的點，用來給沒有找到點來回傳的

        private static readonly int OFFSET = 75;
        private static readonly int NODE_RADIUS = 10;
        private static readonly int NODE_DISTANCE = 75;

        private Piece[,] pieces = new Piece[NODE_COUNT, NODE_COUNT];
        private Point lastPlacedNode = NO_MATCH_NODE;

        public Point LastPlacedNode { get { return lastPlacedNode; } }  // 對外面的人來說就是唯讀變數


        public bool CanBePlaced(int x, int y)
        {
            // TODO : 找到最近的節點 (Node)
            Point nodeId = FindTheClosetNode(x, y);

            // TODO : 如果沒有的話，回傳 false
            if (nodeId == NO_MATCH_NODE)
            {
                return false;
            }

            // TODO : 如果有的話，檢查是否已經存在棋子
            if (pieces[nodeId.X, nodeId.Y] != null)
                return false;


            return true;

        }

        public Piece PlaceAPiece(int x, int y, PieceType type)
        {
            // TODO : 找到最近的節點 (Node)
            Point nodeId = FindTheClosetNode(x, y);

            // TODO : 如果沒有的話，回傳 false
            if (nodeId == NO_MATCH_NODE)
            {
                return null;
            }

            // TODO : 如果有的話，檢查是否已經棋子存在
            if (pieces[nodeId.X,nodeId.Y] != null)
            {
                return null;
            }


            // TODO : 根據 type 產生對應的棋子
            Point formPos = convertToFormPosition(nodeId);
            if (type == PieceType.BLACK)
            {
                pieces[nodeId.X, nodeId.Y] = new BlackPiece(formPos.X, formPos.Y);
            } else if (type == PieceType.WHITE)
            {
                pieces[nodeId.X, nodeId.Y] = new WhitePiece(formPos.X, formPos.Y);
            }


            // 紀錄最後下子的紀錄
            lastPlacedNode = nodeId;

            return pieces[nodeId.X, nodeId.Y];
        }

        public PieceType GetPieceType(int nodeIdX, int nodeIdY)
        {

            if (pieces[nodeIdX, nodeIdY] == null)
                return PieceType.NONE;
            else
                return pieces[nodeIdX, nodeIdY].GetPieceType();
        }

        private Point convertToFormPosition(Point nodeId)
        {
            Point formPosition = new Point();
            formPosition.X = nodeId.X * NODE_DISTANCE + OFFSET; 
            formPosition.Y = nodeId.Y * NODE_DISTANCE + OFFSET;
            return formPosition;
        }
  
        private Point FindTheClosetNode(int x, int y)
        {
            int nodeIdX = FindTheClosetNode(x);
            if (nodeIdX == -1 || nodeIdX >= NODE_COUNT)
            {
                return NO_MATCH_NODE;
            }

            int nodeIdY = FindTheClosetNode(y);
            if (nodeIdY == -1 || nodeIdX >= NODE_COUNT)
            {
                return NO_MATCH_NODE;
            }
            return new Point(nodeIdX, nodeIdY);
        }

        private int FindTheClosetNode(int pos)
        {

            if (pos < OFFSET - NODE_RADIUS)
            {
                return -1;
            }
            pos -= OFFSET;

            int quotient = pos / NODE_DISTANCE;
            int remainder = pos % NODE_DISTANCE;

            if (remainder <= NODE_RADIUS)
                return quotient;
            else if (remainder >= NODE_DISTANCE - NODE_RADIUS)
                return quotient + 1;
            else
                return -1;
        }
    }
}
