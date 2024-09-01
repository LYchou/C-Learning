using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp7_StaticVariable
{
    class Student
    {
        public int score;
        public int passScore = 60;
        public static int passScore_static = 60;
        public string name;

        public Student(int score, string name)
        {
            this.score = score;
            this.name = name;
        }

        public bool isPass()
        {
            return score > passScore;
        }

        public bool isPass_UsingStaticVar()
        {
            return score > passScore_static;
        }
    }
}
