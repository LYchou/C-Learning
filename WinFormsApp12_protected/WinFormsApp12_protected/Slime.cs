using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp12_protected
{
    class Slime : Monstor  
    {
        // 繼承 Monstor，但是初始血量不想要100，所以可以被 derive class 看到的變數為 protected，
        // 所以將 Monstor.hp 設成 protected ，這樣使derive class 看到，但外部也不能隨意修改 private
        // (反之，將 Monstor.hp 設成 private ，這樣使derive class 看不到)
        public Slime()
        {
            hp = 500;
        }

        public string say()
        {
            return introduceSelf() + " 我是史萊姆";
        }
        
    }
}
