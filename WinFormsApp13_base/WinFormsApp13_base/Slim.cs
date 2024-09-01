using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp13_base
{
    class Slim : Monstor
    {
        private int hp;
        // 利用 Base 存取base建構子
        //public Slim(string name) : base(name)  // name 就會直接存在 base.name ，這樣才能傳給 Monstor 的 Constructor
        public Slim(string name) : base("史萊姆") // 也可以直接傳入
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
