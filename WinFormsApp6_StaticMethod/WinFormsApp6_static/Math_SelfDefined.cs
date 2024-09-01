using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp6_static
{
    class Math_SelfDefined
    {
        // 由於這個是屬於 Math_SelfDefined 之 method
        // 所以需要再其他地方先 Math_SelfDefined math = new Math_SelfDefined();
        // 我只是想要用比大小的功能，但何必需要宣告一個記憶體空間，才能用比大小功能呢?
        // 以下就提供不須宣告class即可使用method，這個method即稱為 static
        public int max(int a, int b)
        {
            return Math.Max(a, b);
        }

        // 可在其他地方直接使用，如: Math_SelfDefined.max_static(a,b);
        public static int max_static(int a, int b)
        {
            return Math.Max(a, b);
        }
    }
}
