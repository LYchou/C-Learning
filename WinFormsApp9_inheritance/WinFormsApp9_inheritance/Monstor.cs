using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp9_inheritance
{
    class Monstor : Creature
    {

        // Overloading - 傳入參數型態為 base class ，這樣可以允許傳入 derive class
        public void attack(Creature c)
        {
            c.Injured(60);
        }
    }
}
