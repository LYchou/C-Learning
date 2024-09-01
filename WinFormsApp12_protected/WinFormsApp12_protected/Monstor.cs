using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp12_protected
{
    class Monstor
    {

        //private int hp = 100;
        protected int hp = 100;

        public int getHp()
        {
            return hp;
        }

        protected string introduceSelf()
        {
            return "我是個怪物";
        }
    }
}
