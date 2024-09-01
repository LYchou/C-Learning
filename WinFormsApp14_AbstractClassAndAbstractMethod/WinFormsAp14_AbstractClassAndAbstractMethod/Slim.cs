using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAp14_AbstractClassAndAbstractMethod
{
    class Slim : Monstor
    {

        public Slim() : base("史萊姆")
        {
            hp = 500;
        }
        public override string attack()
        {
            return "史萊姆正在使用黏液攻擊";
        }
    }
}
