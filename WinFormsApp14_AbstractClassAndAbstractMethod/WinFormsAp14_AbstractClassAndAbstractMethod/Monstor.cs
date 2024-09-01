using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAp14_AbstractClassAndAbstractMethod
{
    abstract class Monstor
    {
        protected int hp = 100;

        private string name;

        public Monstor(string name)
        {
            this.name = name;
        }


        // abstract method ，先不定義method，強迫 subclass override
        public abstract string attack();

        public int getHp()
        {
            return hp;
        }

        public virtual string introduceSelf()
        {
            return "我是個怪物 鳩咪 哈哈";
        }
    }
}
