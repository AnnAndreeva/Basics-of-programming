using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР05
{
    class Program
    {
        static void Main(string[] args)
        {
            bool key = false;
            while (key == false)
            {
                Console.WriteLine("Выберите задание Лабораторной работы №5");
                Console.WriteLine("1 - первое задание");
                Console.WriteLine("2 - второе задание\n");
                Console.Write("Выбранное задание - ");
                string menu1 = Console.ReadLine();
                Console.WriteLine();
                switch (menu1)
                {
                    case "1":
                        {
                            Task1();
                            Console.WriteLine();
                            Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "2":
                        {
                            Task2();
                            Console.WriteLine();
                            Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Введено значение, не соответствующее ни одному пункту меню.");
                            Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                }
            }

        }
        public static void Task1()
        {
            Console.WriteLine("Задание 1. «Правильная дробь»");
            int p1, m1, p2, m2;
            Fraction f1 = new Fraction();
            Console.Write("Введите числитель 1 дроби:   ");
            p1 = Convert.ToInt32(Console.ReadLine());
            f1.X = p1;
            Console.WriteLine("                             — ");
            Console.Write("Введите знаменатель 1 дроби: ");
            m1 = Convert.ToInt32(Console.ReadLine());
            f1.Y = m1;
            Console.WriteLine();

            Fraction f2 = new Fraction();
            Console.Write("Введите числитель 2 дроби:   ");
            p2 = Convert.ToInt32(Console.ReadLine());
            f2.X = p2;
            Console.WriteLine("                             — ");
            Console.Write("Введите знаменатель 2 дроби: ");
            m2 = Convert.ToInt32(Console.ReadLine());
            f2.Y = m2;
            Fraction f3 = new Fraction();
            Console.WriteLine();
            bool key = false;
            while (key == false)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("+ - сложение");
                Console.WriteLine("- - вычитание");
                Console.WriteLine("* - умножение");
                Console.WriteLine("/ - деление");
                Console.WriteLine();
                Console.Write("Выбранное действие: ");
                string choice = Console.ReadLine();
                Console.WriteLine();
                switch (choice)
                {
                    case "+":
                        {
                            f1.Summa(f2);
                            f1 = Fraction.Reduction(f1);
                            Console.WriteLine("Проверка метода без возвращаемого значения ");
                            Console.WriteLine("Результат: ");
                            Fraction.OutputFr(f1);
                            Console.WriteLine();

                            f1 = new Fraction(p1, m1);

                            f3 = f1.SummaS(f2);
                            f3 = Fraction.Reduction(f3);
                            Console.WriteLine("Проверка метода, возвращающего объект ");
                            Console.WriteLine("Результат: ");
                            Fraction.OutputFr(f3);
                            Console.WriteLine();

                            f3 = Fraction.SummaSt(f1, f2);
                            f3 = Fraction.Reduction(f3);
                            Console.WriteLine("Проверка статического метода ");
                            Console.WriteLine("Результат: ");
                            Fraction.OutputFr(f3);
                            Console.WriteLine();


                            f3 = f1 + f2;
                            f3 = Fraction.Reduction(f3);
                            Console.WriteLine("Проверка переопределения операции ");
                            Console.WriteLine("Результат: ");
                            Fraction.OutputFr(f3);
                            Console.WriteLine();

                            f3 = f1 + f2;                           
                            Console.WriteLine("Проверка сокращения дроби ");
                            Console.WriteLine("Начальная дробь: ");
                            Fraction.OutputFr(f3);

                            f3 = Fraction.Reduction(f3);
                            Console.WriteLine("Результат: ");
                            Fraction.OutputFr(f3);
                            Console.WriteLine();

                            Console.WriteLine("Для возвращения в меню нажмите Enter");
                            Console.ReadLine();
                            break;
                        }
                    case "-":
                        {
                            f1.Dif(f2);
                            f1 = Fraction.Reduction(f1);
                            Console.WriteLine("Проверка метода без возвращаемого значения ");
                            Console.WriteLine("Результат: ");
                            Fraction.OutputFr(f1);
                            Console.WriteLine();

                            f1 = new Fraction(p1, m1);

                            f3 = f1.DifS(f2);
                            f3 = Fraction.Reduction(f3);
                            Console.WriteLine("Проверка метода, возвращающего объект ");
                            Console.WriteLine("Результат: ");
                            Fraction.OutputFr(f3);
                            Console.WriteLine();

                            f3 = Fraction.DifSt(f1, f2);
                            f3 = Fraction.Reduction(f3);
                            Console.WriteLine("Проверка статического метода ");
                            Console.WriteLine("Результат: ");
                            Fraction.OutputFr(f3);
                            Console.WriteLine();

                            f3 = f1 - f2;
                            f3 = Fraction.Reduction(f3);
                            Console.WriteLine("Проверка переопределения операции ");
                            Console.WriteLine("Результат: ");
                            Fraction.OutputFr(f3);
                            Console.WriteLine();

                            f3 = f1 - f2;
                            Console.WriteLine("Проверка сокращения дроби ");
                            Console.WriteLine("Начальная дробь: ");
                            Fraction.OutputFr(f3);

                            f3 = Fraction.Reduction(f3);
                            Console.WriteLine("Результат: ");
                            Fraction.OutputFr(f3);
                            Console.WriteLine();

                            Console.WriteLine("Для возвращения в меню нажмите Enter");
                            Console.ReadLine();
                            break;
                        }
                    case "*":
                        {

                            f1.Multi(f2);
                            f1 = Fraction.Reduction(f1);
                            Console.WriteLine("Проверка метода без возвращаемого значения ");
                            Console.WriteLine("Результат: ");
                            Fraction.OutputFr(f1);
                            Console.WriteLine();

                            f1 = new Fraction(p1, m1);

                            f3 = f1.MultiS(f2);
                            f3 = Fraction.Reduction(f3);
                            Console.WriteLine("Проверка метода, возвращающего объект ");
                            Console.WriteLine("Результат: ");
                            Fraction.OutputFr(f3);
                            Console.WriteLine();

                            f3 = Fraction.MultiSt(f1, f2);
                            f3 = Fraction.Reduction(f3);
                            Console.WriteLine("Проверка статического метода ");
                            Console.WriteLine("Результат: ");
                            Fraction.OutputFr(f3);
                            Console.WriteLine();

                            f3 = f1 * f2;
                            f3 = Fraction.Reduction(f3);
                            Console.WriteLine("Проверка переопределения операции ");
                            Console.WriteLine("Результат: ");
                            Fraction.OutputFr(f3);
                            Console.WriteLine();

                            f3 = f1 * f2;
                            Console.WriteLine("Проверка сокращения дроби ");
                            Console.WriteLine("Начальная дробь: ");
                            Fraction.OutputFr(f3);

                            f3 = Fraction.Reduction(f3);
                            Console.WriteLine("Результат: ");
                            Fraction.OutputFr(f3);
                            Console.WriteLine();
                            Console.WriteLine("Для возвращения в меню нажмите Enter");
                            Console.ReadLine();
                            break;
                        }
                    case "/":
                        {
                            if ((p1 == 0) || (p2 == 0))
                            {
                                Console.WriteLine("Деление дробей недоступно");
                                Console.WriteLine("Один из числителей равен 0");
                                Console.WriteLine("Выполнение приведет к ошибке деления на 0");
                            }
                            else
                            {
                                f1.Div(f2);
                                f1 = Fraction.Reduction(f1);
                                Console.WriteLine("Проверка метода без возвращаемого значения ");
                                Console.WriteLine("Результат: ");
                                Fraction.OutputFr(f1);
                                Console.WriteLine();

                                f1 = new Fraction(p1, m1);

                                f3 = f1.DivS(f2);
                                f3 = Fraction.Reduction(f3);
                                Console.WriteLine("Проверка метода, возвращающего объект ");
                                Console.WriteLine("Результат: ");
                                Fraction.OutputFr(f3);
                                Console.WriteLine();

                                f3 = Fraction.DivSt(f1, f2);
                                f3 = Fraction.Reduction(f3);
                                Console.WriteLine("Проверка статического метода ");
                                Console.WriteLine("Результат: ");
                                Fraction.OutputFr(f3);
                                Console.WriteLine();

                                f3 = f1 / f2;
                                f3 = Fraction.Reduction(f3);
                                Console.WriteLine("Проверка переопределения операции ");
                                Console.WriteLine("Результат: ");
                                Fraction.OutputFr(f3);

                                f3 = f1 / f2;
                                Console.WriteLine("Проверка сокращения дроби ");
                                Console.WriteLine("Начальная дробь: ");
                                Fraction.OutputFr(f3);

                                f3 = Fraction.Reduction(f3);
                                Console.WriteLine("Результат: ");
                                Fraction.OutputFr(f3);
                                Console.WriteLine();
                                Console.WriteLine();
                            }

                            Console.WriteLine("Для возвращения в меню нажмите Enter");
                            Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Введено значение, не соответствующее ни одному пункту меню.");
                            Console.WriteLine("Для возвращения в меню нажмите Enter");
                            Console.ReadLine();
                            break;
                        }
                }
            }

        }
        public static void Task2()
        {
            Console.WriteLine("Задание 2. Статические методы вынести в отдельный класс \n и проверить работоспособность программы.");
            
            int p1, m1, p2, m2;
            Console.Write("Введите числитель 1 дроби:   ");
            p1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("                             — ");
            Console.Write("Введите знаменатель 1 дроби: ");
            m1 = Convert.ToInt32(Console.ReadLine());
            Fraction f1 = new Fraction(p1, m1);
            Console.WriteLine();

            Console.Write("Введите числитель 2 дроби:   ");
            p2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("                             — ");
            Console.Write("Введите знаменатель 2 дроби: ");
            m2 = Convert.ToInt32(Console.ReadLine());
            Fraction f2 = new Fraction(p2, m2);
            Fraction f3 = new Fraction();
            Console.WriteLine();
            bool key = false;
            while (key == false)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("+ - сложение");
                Console.WriteLine("- - вычитание");
                Console.WriteLine("* - умножение");
                Console.WriteLine("/ - деление");
                Console.WriteLine();
                Console.Write("Выбранное действие: ");
                string choice = Console.ReadLine();
                Console.WriteLine();
                switch (choice)
                {
                    case "+":
                        {
                            f3 = StaticFraction.SummaSt(f1, f2);
                            f3 = StaticFraction.Reduction(f3);
                            Console.WriteLine("Проверка статического метода ");
                            Console.WriteLine("Результат: ");
                            StaticFraction.OutputFr(f3);
                            Console.WriteLine();

                            Console.WriteLine("Для возвращения в меню нажмите Enter");
                            Console.ReadLine();
                            break;
                        }
                    case "-":
                        {
                            f3 = StaticFraction.DifSt(f1, f2);
                            f3 = StaticFraction.Reduction(f3);
                            Console.WriteLine("Проверка статического метода ");
                            Console.WriteLine("Результат: ");
                            StaticFraction.OutputFr(f3);
                            Console.WriteLine();

                            Console.WriteLine("Для возвращения в меню нажмите Enter");
                            Console.ReadLine();
                            break;
                        }
                    case "*":
                        {
                            f3 = StaticFraction.MultiSt(f1, f2);
                            f3 = StaticFraction.Reduction(f3);
                            Console.WriteLine("Проверка статического метода ");
                            Console.WriteLine("Результат: ");
                            StaticFraction.OutputFr(f3);
                            Console.WriteLine();

                            Console.WriteLine("Для возвращения в меню нажмите Enter");
                            Console.ReadLine();
                            break;
                        }
                    case "/":
                        {
                            if ((p1 == 0) || (p2 == 0))
                            {
                                Console.WriteLine("Деление дробей недоступно");
                                Console.WriteLine("Один из числителей равен 0");
                                Console.WriteLine("Выполнение приведет к ошибке деления на 0");
                            }
                            else
                            {
                                f3 = StaticFraction.DivSt(f1, f2);
                                f3 = StaticFraction.Reduction(f3);
                                Console.WriteLine("Проверка статического метода ");
                                Console.WriteLine("Результат: ");
                                StaticFraction.OutputFr(f3);
                                Console.WriteLine();
                            }

                            Console.WriteLine("Для возвращения в меню нажмите Enter");
                            Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Введено значение, не соответствующее ни одному пункту меню.");
                            Console.WriteLine("Для возвращения в меню нажмите Enter");
                            Console.ReadLine();
                            break;
                        }
                }
            }

        }

    }
}