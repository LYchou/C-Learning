using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp13_base_
{
    class Monstor
    {
        protected int hp = 100;

        private string name=" ";

        public void SetName(string name)
        { this.name = name; }

        public int getHp()
        { return hp; }

        public virtual string introduceSelf()
        { return "我是一個怪物 鳩咪"; }
    }
}
