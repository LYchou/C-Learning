using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp10_override
{
    class Monstor : Creature
    {
        // Constructor
        public Monstor(String name)
        {
            // this.name 就是 Monstor 繼承 Creature.name
            this.name = name;
        }

        public override string move()
        {
            return name + " 橫著走";
        }

        public string move2()
        {
            return name + " 橫著走";
        }
    }
}
