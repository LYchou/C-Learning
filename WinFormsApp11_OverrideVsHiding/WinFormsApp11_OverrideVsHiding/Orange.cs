using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp11_OverrideVsHiding
{
    class Orange : Fruit
    {

        public new string saySomeThing()
        {
            return "我是一顆煩人的柳丁";
        }
    }
}
