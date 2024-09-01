using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp16_SwitchAndEnum
{
    class Monstor
    {
        private int X;
        private int Y;

        public void move(Direction direction)
        {

            switch (direction)
            {
                case Direction.UP:
                    Y += 1;
                    break;
                case Direction.DOWN:
                    Y -= 1;
                    break;
                case Direction.LEFT:
                    X -= 1;
                    break;
                case Direction.RIGHT:
                    X -= 1;
                    break;
                default:
                    // Error
                    break;
            }
        }

        public string getPosition()
        {
            return "怪物在 (" + X + "," + Y + ")";
        }
    }
}
