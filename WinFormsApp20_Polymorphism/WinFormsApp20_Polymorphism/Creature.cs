using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp20_Polymorphism
{
    class Creature
    {

        protected int hp;
        protected string name;

        public Creature(string name)
        {
            this.hp = 100;
            this.name = name;
        }

        public void injured(int damage)
        {
            if (damage > hp)
            {
                hp = 0;
            }
            else
            {
                hp -= damage;
            }
        }

        public virtual string say()
        {
            return "我是" + name + ", 我有" + hp + "滴血";
        }
    }
}
