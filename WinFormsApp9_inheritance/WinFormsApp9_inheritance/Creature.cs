using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp9_inheritance
{
    class Creature
    {
        private int hp = 100;
        public int HP
        {
            get { return hp; }  // 在讀取 HP 時會自動呼叫 (附註: 如過不寫 set ，這樣這個變數就變成"唯讀"變數)
            set { // 在存入數值時會自動呼叫 ex: creature.HP = -10; 此時 set 當中 value 變數即為 -10
                if (value < 0)
                    hp = 0;
                else
                    hp = value;
            }
        }

        public int GetHp()
        {
            return hp;
        }

        public void Injured(int injuredPoint)
        {
            hp -= injuredPoint;
        }
    }
}
