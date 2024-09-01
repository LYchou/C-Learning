using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp11_OverrideVsHiding
{
    class Fruit
    {

        public virtual string saySomeThing()
        {
            return "我是水果";
        }
    }
}
