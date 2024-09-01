using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4_DeclareClass
{
    class Student
    {
        // Property
        public int StudentID;
        public string Name;
        public int Grade;

        // Method
        public string Say()
        {
            return "我叫" + Name + "，我是" + Grade + "年級的學生";
        }
    }
}
