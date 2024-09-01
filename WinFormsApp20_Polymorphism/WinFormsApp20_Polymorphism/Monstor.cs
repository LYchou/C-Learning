using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp20_Polymorphism
{
     class Monstor
    {

        // 傳入不用為每種衍伸類別寫 attack，直接用base class，這就是多型性
        // 統一操做基底類別
        public void attack(Creature c)
        {
            c.injured(10);
        }
    }
}
