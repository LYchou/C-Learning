using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5_constructor
{
    class Student
    {
        int ID;
        int grade;
        string name;

        // constructor
        public Student(int id, int grade, string name)
        {
            ID = id;
            // this 就是指 Student property 的 grade ，
            // 因為輸入id與Student property 的 id名稱相同，如果硬不寫 grade = grade 這樣不會存到Student property 的 id
            this.grade = grade;
            this.name = name;
        }

        // 多載 - 設定不同引數的建構子
        public Student(int id, string name)
        {
            ID = id;
            // this 就是指 Student property 的 grade ，
            // 因為輸入id與Student property 的 id名稱相同，如果硬不寫 grade = grade 這樣不會存到Student property 的 id
            this.grade = 1;
            this.name = name;
        }

        public string say()
        {
            return "I'm " + name + ". I'm in " + grade + "th grade and my student number is " + ID + ".";
        }
    }
}
