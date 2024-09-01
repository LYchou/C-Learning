using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp13_base_
{
    class Slim 
    {
        private int hp;
        // 建構子
        public Slim()
        {
            hp = 500;  // hp為最近的 Slim的hp
            base.hp = 235235;
        }

        public override string introduceSelf()
        {
            return base.introduceSelf() + " 我是史萊姆";
        }

    }
}
