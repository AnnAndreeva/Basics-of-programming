using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР03
{
    enum Vacancies : int
    { Manager, Boss, Clerk, Salesman }

    struct Employee
    {
        private string name;
        private Vacancies vacancy;
        private int salary;
        private DateTime hiredate;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Vacancies Vacancy
        {
            get { return vacancy; }
            set { vacancy = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public DateTime Hiredate
        {
            get { return hiredate; }
            set { hiredate = value; }
        }
        public override string ToString()
        {
            return "ФИО:" + Name + ", должность:" + Vacancy + ", зарплата:" + Salary + "руб/мес, дата приема на работу :"
                + hiredate + ".";
        }
    }
}
