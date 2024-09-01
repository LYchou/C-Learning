using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp15_constant
{
    class GameEngine
    {

        // const 寫這存在一些特性，如其它程式用了這個並且編譯，在其它程式中GameEngine.DAMAGE_MULTIPLIER就直接替換成10.0
        // 如果不把其它程式也從新編譯，即使你去GameEngine改了DAMAGE_MULTIPLIER，改為5.0，並只編譯GameEngine，
        // 其它程式中 GameEngine.DAMAGE_MULTIPLIER仍為10.0
        // public const double DAMAGE_MULTIPLIER = 10.0;  

        // readonly是執行的時候，才去看GameEngine.DAMAGE_MULTIPLIER，所以不會出現上述問題
        public static readonly double DAMAGE_MULTIPLIER = 5.0;


        // http://slmtsite.blogspot.com/2016/10/c-36-constant.html
        // https://dotblogs.com.tw/yc421206/2011/06/06/27232
    }
}
