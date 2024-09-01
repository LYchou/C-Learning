using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp10_override
{
    class Villager : Creature  
    {
        public Villager(String name)
        {
            this.name = name;
        }

        public override string attack(Creature target)
        {
            return name + " 不能攻擊其他人";
        }


    }
}
