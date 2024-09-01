using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp17_MultidimensionalArrays
{
    class Math
    {

        public string Matrix2Dimention_convert_string(int[,] a)
        {
            string result = " ";
            for (int x=0; x<2; x++)
            {
                for (int y=0; y<2; y++)
                {
                    result += " " + a[x, y];
                }
                result += "\n";
            }
            return result;
        }

        public int[,] add(int[,] a, int[,] b)
        {
            int[,] c = new int[2,2];
            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    c[x,y] = a[x, y] + b[x,y];
                }
            }
            return c;
        }
    }
}
