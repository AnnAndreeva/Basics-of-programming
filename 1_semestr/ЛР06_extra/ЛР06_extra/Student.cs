using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР06_extra
{
    class Student
    {
        public string name;
        public int m1, m2, m3, m4;

        public Student()
        {
        }

        public Student(string name, int m1, int m2, int m3, int m4)
        {
            this.name = name;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
            this.m4 = m4;
            
        }
        public string Info(string name, int m1, int m2, int m3, int m4) {
            string info;
            info = name + " " + m1 + " " + m2 + " " + m3 + " " + m4;
            return info;
        }
    }
}
