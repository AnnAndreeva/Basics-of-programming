﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_2
{

    class Program
    {
        static void Main(string[] args)
        {
            bool key = false;
            while (key == false)
            {
                Console.WriteLine();
                Console.WriteLine("Выберите задание Лабораторной работы №2");
                Console.WriteLine("1 - первое задание");
                Console.WriteLine("2 - второе задание");
                Console.WriteLine("3 - третье задание\n");
                Console.Write("Выбранное задание - ");
                string menu1 = Console.ReadLine();
                Console.WriteLine();
                switch (menu1)
                {
                    case "1":
                        {
                            double xmin, xmax, dx, y, v;
                            Console.WriteLine("Задание 1 \nТаблица значений функции");
                            Console.Write("Введите xmin = ");
                            xmin = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите xmax = ");
                            xmax = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Введите dx = ");
                            dx = Convert.ToDouble(Console.ReadLine());
                            if (xmin > xmax)
                            {
                                v = xmax;
                                xmax = xmin;
                                xmin = v;
                            }

                            Console.WriteLine("\nВвод значений функции на интервале от {0} до {1} на экран\n", xmin, xmax);
                            Console.WriteLine("\tx\t\ty\n");

                            for (double x = xmin; x <= xmax; x += dx)
                            {
                                double r = 2;
                                if ((x >= -7) && (x <= 3))
                                {
                                    if (x < -6)
                                    {
                                        y = 2;
                                    }
                                    else if ((x >= -6) && (x < -2))
                                    {
                                        y = x / 2 + 1;
                                    }
                                    else if ((x >= -2) && (x < 0))
                                    {
                                        y = Math.Sqrt(Math.Pow(r, 2) - Math.Pow((x + 2), 2)) + 2;
                                    }
                                    else if ((x >= 0) && (x < 2))
                                    {
                                        y = Math.Sqrt(Math.Pow(r, 2) - Math.Pow(x, 2));
                                    }
                                    else
                                    {
                                        y = -x + 2;
                                    }
                                    Console.WriteLine("{0,10:0.#0}{1,16:0.#0}", x, y);
                                }
                                else
                                {
                                    string err = "Нет у";
                                    Console.WriteLine("{0,10:0.#0}{1,16}", x, err);

                                }
                            }
                            Console.WriteLine("Для возвращения в меню нажмите Enter");
                            Console.ReadLine();
                        }
                        break;

                    case "2":
                        {
                            Console.WriteLine("Задание 2 \nСерия выстрелов по мишени");
                            double x, y, n = 0;
                            while (n < 10)
                            {
                                n++;
                                Console.WriteLine("Сделайте {0} выстрел", n);
                                Console.Write("Введите x = ");
                                x = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Введите y = ");
                                y = Convert.ToDouble(Console.ReadLine());
                                if (y >= 0)
                                {
                                    if ((y >= Math.Pow((x - 2), 2) - 3) && (x >= Math.Abs(y)))
                                    {
                                        Console.WriteLine("Вы попали в мишень");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Вы не попали в мишень");
                                    }
                                }
                                else
                                {
                                    if ((y >= Math.Pow((x - 2), 2) - 3) && (x <= Math.Abs(y)))
                                    {
                                        Console.WriteLine("Вы попали в мишень");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Вы не попали в мишень");
                                    }
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("Для возвращения в меню нажмите Enter");
                            Console.ReadLine();
                        }
                        break;
                    case "3":
                        {
                            Console.WriteLine("Задание 3 \nСумма ряда");
                            double curr = 1, n = 0, sum = Math.PI / 2, e, x;
                            Console.Write("Введите x = ");
                            x = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Введите точность вычислений = ");
                            e = Convert.ToDouble(Console.ReadLine());

                            if ((x > 1) && (e < 1))
                            {
                                while (Math.Abs(curr) > e)
                                {
                                    curr = Math.Pow(-1, n + 1) / ((2 * n + 1) * Math.Pow(x, 2 * n + 1));
                                    n++;
                                    sum += curr;
                                }

                                Console.WriteLine("Arctg x = {0}. Количество членов в ряду {1}", sum, n);
                            }
                            else
                            {
                                Console.WriteLine("Вычисление невозможно. Введите корректные значения.");
                            }

                            Console.WriteLine("Для возвращения в меню нажмите Enter");
                            Console.ReadLine();

                        }
                        break;
                    default:
                        Console.WriteLine("Введено значение, не соответствующее ни одному пункту меню.");
                        Console.WriteLine("Для возвращения в меню нажмите Enter");
                        break;
                }
            }
        }
    }

}


