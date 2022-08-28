using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР03
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetWindowSize(120, 50);
            Console.WriteLine("Лабораторная работа №3. Перечисления.\nВыполнила: Андреева Анна. Группа: 6113-020302D");
            Console.WriteLine("Введите размер массива с данными о работниках:");
            int N = Convert.ToInt32(Console.ReadLine());
            Employee[] employees = new Employee[N];
            Console.WriteLine("Заполните данные о работниках:");
            for (int i = 0; i < N; i++)
            {
                Console.Write("ФИО: ");
                employees[i].Name = Console.ReadLine();
                Console.Write("1 - Manager;\n2 - Boss;\n3 - Clerk;\n4 -  Salesman.\nДолжность(число): ");
                int v = Convert.ToInt32(Console.ReadLine());
                switch (v)
                {
                    case 1:
                        {
                            employees[i].Vacancy = Vacancies.Manager;
                            break;
                        }
                    case 2:
                        {
                            employees[i].Vacancy = Vacancies.Boss;
                            break;
                        }
                    case 3:
                        {
                            employees[i].Vacancy = Vacancies.Clerk;
                            break;
                        }
                    case 4:
                        {
                            employees[i].Vacancy = Vacancies.Salesman;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Такой должности нет. Будет присвоена должность Salesman.");
                            employees[i].Vacancy = Vacancies.Salesman;
                            break;
                        }
                }
                Console.Write("Зарплата: ");
                employees[i].Salary = Convert.ToInt32(Console.ReadLine());
                Console.Write("Дата приема на работу(дд.мм.гггг): ");
                employees[i].Hiredate = DateTime.Parse(Console.ReadLine());
            }
            bool key = false;
            while (key == false)
            {
                Console.WriteLine("Выберите задание Лабораторной работы №3");
                Console.WriteLine("1 - полная информацию обо всех сотрудниках ");
                Console.WriteLine("2 - полная информацию о сотрудниках, работающих в указанной должности ");
                Console.WriteLine("3 - все менеджеры, зарплата которых больше средней зарплаты всех клерков");
                Console.WriteLine("4 - полная информацию обо всех сотрудниках, принятых на работу позже босса\n");
                Console.Write("Выбранное задание - ");
                string menu1 = Console.ReadLine();
                Console.WriteLine();
                switch (menu1)
                {
                    case "1":
                        {
                            for (int i = 0; i < N; i++)
                            {
                                Console.WriteLine(employees[i]);
                            }
                            Console.WriteLine();
                            Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                            Console.ReadLine();
                            break;
                        }
                    case "2":
                        {

                            Console.Write("1 - Manager;\n2 - Boss;\n3 - Clerk;\n4 -  Salesman.\nВведите должность:(число): ");
                            int v = Convert.ToInt32(Console.ReadLine());
                            switch (v)
                            {
                                case 1:
                                    {
                                        int k = 0;
                                        for (int i = 0; i < N; i++)
                                        {
                                            if (employees[i].Vacancy == Vacancies.Manager)
                                                k++;
                                        }
                                        if (k != 0)
                                        {
                                            for (int i = 0; i < N; i++)
                                            {
                                                if (employees[i].Vacancy == Vacancies.Manager)
                                                    Console.WriteLine(employees[i]);
                                            }
                                        }
                                        else Console.WriteLine("Работников в этой должности нет. ");
                                        break;
                                    }
                                case 2:
                                    {
                                        int k = 0;
                                        for (int i = 0; i < N; i++)
                                        {
                                            if (employees[i].Vacancy == Vacancies.Boss)
                                                k++;
                                        }
                                        if (k != 0)
                                        {
                                            for (int i = 0; i < N; i++)
                                            {
                                                if (employees[i].Vacancy == Vacancies.Boss)
                                                    Console.WriteLine(employees[i]);
                                            }
                                        }
                                        else Console.WriteLine("Работников в этой должности нет. ");
                                        break;
                                    }
                                case 3:
                                    {
                                        int k = 0;
                                        for (int i = 0; i < N; i++)
                                        {
                                            if (employees[i].Vacancy == Vacancies.Clerk)
                                                k++;
                                        }
                                        if (k != 0)
                                        {
                                            for (int i = 0; i < N; i++)
                                            {
                                                if (employees[i].Vacancy == Vacancies.Clerk)
                                                    Console.WriteLine(employees[i]);
                                            }
                                        }
                                        else Console.WriteLine("Работников в этой должности нет. ");
                                        break;
                                    }
                                case 4:
                                    {
                                        int k = 0;
                                        for (int i = 0; i < N; i++)
                                        {
                                            if (employees[i].Vacancy == Vacancies.Salesman)
                                                k++;
                                        }
                                        if (k != 0)
                                        {
                                            for (int i = 0; i < N; i++)
                                            {
                                                if (employees[i].Vacancy == Vacancies.Salesman)
                                                    Console.WriteLine(employees[i]);
                                            }
                                        }
                                        else Console.WriteLine("Работников в этой должности нет. ");
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Такой должности нет.");
                                        break;
                                    }
                            }
                            Console.WriteLine();
                            Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                            Console.ReadLine();
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine(" ");
                            int Ssalary = 0, k = 0;
                            for (int i = 0; i < N; i++)
                            {
                                if (employees[i].Vacancy == Vacancies.Clerk)
                                {
                                    Ssalary += employees[i].Salary;
                                    k++;
                                }

                            }
                            if (k != 0)
                            {
                                Ssalary /= k;
                                k = 0;
                                for (int i = 0; i < N; i++)
                                {
                                    if ((employees[i].Salary > Ssalary) && (employees[i].Vacancy == Vacancies.Manager))
                                    {
                                        k++;
                                    }
                                }
                                Employee[] managers = new Employee[k];
                                int c = 0;
                                for (int i = 0; i < N; i++)
                                {
                                    if ((employees[i].Salary > Ssalary) && (employees[i].Vacancy == Vacancies.Manager))
                                    {
                                        managers[c] = employees[i];
                                        c++;
                                    }
                                }
                                for (int i = 0; i < k; i++)
                                {
                                    for (int j = 0; j < k - 1; j++)
                                    {

                                        if (ReOrder(managers[j].Name, managers[j + 1].Name))
                                        {
                                            string s = managers[j].Name;
                                            managers[j].Name = managers[j + 1].Name;
                                            managers[j + 1].Name = s;
                                        }
                                    }
                                }

                                for (int i = 0; i < k; i++)
                                {

                                    Console.WriteLine(managers[i]);
                                }
                                Console.WriteLine("Средняя зарплата клерков = " + Ssalary + "руб/мес");
                            }
                            else Console.WriteLine("Нет работников-клерков.");
                            Console.WriteLine();
                            Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                            Console.ReadLine();

                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine(" ");
                            int k = 0;
                            bool boss = false;
                            DateTime BossDate = new DateTime();
                            for (int i = 0; i < N; i++)
                            {
                                if (employees[i].Vacancy == Vacancies.Boss)
                                {

                                    BossDate = employees[i].Hiredate;
                                    boss = true;

                                }
                            }
                            if (boss)
                            {
                                for (int i = 0; i < N; i++)
                                {
                                    if ((employees[i].Hiredate < BossDate) && (employees[i].Vacancy != Vacancies.Boss))
                                    {
                                        k++;
                                    }
                                }
                                if (k != 0)
                                {
                                    Employee[] AfterBoss = new Employee[k];
                                    int c = 0;
                                    for (int i = 0; i < N; i++)
                                    {
                                        if ((employees[i].Hiredate < BossDate) && (employees[i].Vacancy != Vacancies.Boss))
                                        {
                                            AfterBoss[c] = employees[i];
                                            c++;
                                        }
                                    }


                                    for (int i = 0; i < k; i++)
                                    {
                                        for (int j = 0; j < k - 1; j++)
                                        {
                                            if (ReOrder(AfterBoss[j].Name, AfterBoss[j + 1].Name))
                                            {
                                                string s = AfterBoss[j].Name;
                                                AfterBoss[j].Name = AfterBoss[j + 1].Name;
                                                AfterBoss[j + 1].Name = s;
                                            }
                                        }
                                    }

                                    for (int i = 0; i < k; i++)
                                    {
                                        Console.WriteLine(AfterBoss[i]);
                                    }
                                }
                                else Console.WriteLine("Нет работников, нанятых позже босса.");
                            } else Console.WriteLine("Нет босса.");                           
                            Console.WriteLine();
                            Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                            Console.ReadLine();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Введено значение, не соответствующее ни одному пункту меню.");
                            Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                            Console.ReadLine();
                            break;
                        }
                }

            }

        }
        public static bool ReOrder(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return false;
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return true;
            }
            return false;
        }
    }
}

