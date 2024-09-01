using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp11_OverrideVsHiding
{
    class Aaple : Fruit
    {
        public override string saySomeThing()
        {
            return "我是一顆蘋果";
        }
    }
}
