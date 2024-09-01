using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp19_gomoku
{
    class DirectionOfLineConnectionCount
    {
        public int Vertical_count = 0;
        public int Horizontal_count = 0;
        public int LeftSlash_count = 0;
        public int RightSlash_count = 0;

        private int flag = 0;

        public bool CheckWinner()
        {
            if (Vertical_count >= 6)
                flag = 1;
            if (Horizontal_count >= 6)
                flag = 1;
            if (LeftSlash_count >= 6)
                flag = 1;
            if (RightSlash_count >= 6)
                flag = 1;

            if (flag == 0)
                return false;
            else
                return true;
        }
    }
}
