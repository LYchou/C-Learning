using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp10_override
{
    class Creature
    {
        public string name;

        public virtual string attack(Creature target)  // 想要被 override 的 method 必須 前面加 virtual
        {
            return name+ " 攻擊了" + target.name;
        }

        public virtual string move()
        {
            return name + " 向前走";
        }

    }
}
