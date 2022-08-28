using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР_3
{
    public class Counter
    {
        public int max, min, current;
        public Counter()
        { }
        public Counter(int min, int max, int current)
        {
            this.max = max;
            this.min = min;
            this.current = current;
        }
        public void Increase()
        {
            if (current < max)
            {
                current++;
            }
            else
            {
                current = min;
            }

        }
        public void Decrease()
        {
            if (current > min)
            {
                current--;
            }
            else
            {
                current = max;
            }

        }
        public int GetCurrent()
        {
            return current;
        }

    }

    public class Quadratic {
        public double a, b, c, x1, x2, D, v;
        string str;

        public Quadratic()
        { }

        public Quadratic(double a, double b, double c, double x1, double x2, double D, double v, string str) {
            this.a = a;
            this.b = b;
            this.c = c;
            this.x1 = x1;
            this.x2 = x2;
            this.D = D;
            this.v = v;
            this.str = str;
        }
        
        public string ShortQuadratic(double a, double b, double c)
        {
            if ((b == 0) && (c == 0))
            {
                x1 = 0;
                str = "Уравнение имеет один корень x = " + x1;

            }
            else if (c == 0)
            {
                x1 = 0;
                x2 = Math.Round(-1 * (b / a), 2);
                if (x1 < x2)
                {
                    v = x1;
                    x1 = x2;
                    x2 = v;
                }
                str = "Уравнение имеет два корня x1 = " + x1 + ", x2 = " + x2;
            }
            else if (b == 0)
            {
                if ((-1 * (c / a)) > 0)
                {
                    x1 = Math.Round(-1 * Math.Sqrt(-1 * (c / a)), 2);
                    x2 = Math.Round(Math.Sqrt(-1 * (c / a)), 2);
                    str = "Уравнение имеет два корня x1 = " + x1 + ", x2 = " + x2;
                }
                else
                {

                    str = "Нет корней";
                }
            }
                return str;

        }

        public string FullQuadratic(double a, double b, double c) {
            D = (Math.Pow(b, 2) - 4 * a * c);
            if (D < 0)
            {
                str = "Нет корней";
            }
            else if (D == 0)
            {
                x1 = Math.Round(((-1 )* b + Math.Sqrt(D)) / (2 * a), 2);
                str = "Уравнение имеет один корень x = " + x1;
            }
            else
            {
                x1 = Math.Round((-1 * b - Math.Sqrt(D)) / (2 * a),2);
                x2 = Math.Round((-1 * b + Math.Sqrt(D)) / (2 * a), 2);
                if (x1 < x2)
                {
                    v = x1;
                    x1 = x2;
                    x2 = v;
                }
                str = "Уравнение имеет два корня x1 = " + x1 + ", x2 = " + x2;
            }
            return str;
            
        }
        public string GetX()
        {
            return str;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool key = false;
            while (key == false)
            {
                
                Console.WriteLine("Выберите задание Лабораторной работы №2");
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
                            Console.WriteLine("Для возвращения в меню нажмите Enter");
                            Console.ReadLine();
                            Console.Clear();
                            break;                            
                        }
                    case "2":
                        {
                            Task2();
                            Console.WriteLine();
                            Console.WriteLine("Для возвращения в меню нажмите Enter");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Введено значение, не соответствующее ни одному пункту меню.");
                            Console.WriteLine("Для возвращения в меню нажмите Enter");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }

                }



            }
            
        }
        public static void Task1()
        {
            int max, min, current, v;
            Console.WriteLine("Задание 1 \n«Десятичный счетчик»");
            Console.Write("Введите левую границу = ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите правую границу = ");
            max = Convert.ToInt32(Console.ReadLine());
            
            if (min > max)
            {
                v = max;
                max = min;
                min = v;
            }
            Console.Write("Введите изначальное значение = ");
            current = Convert.ToInt32(Console.ReadLine());
            Counter counter = new Counter(min, max, current);
            bool key2 = false;
             while (key2 == false)
             {
               
                Console.WriteLine();
                Console.WriteLine("Выберете действие:");
                Console.WriteLine("+ - увеличить значение");
                Console.WriteLine("- - уменьшить значение");
                Console.WriteLine("* - закончить");
                Console.Write("Выбранное действие: ");
                string choice = Console.ReadLine();
                Console.WriteLine();
                switch (choice)
                {
                    case "+":
                        {
                            if (current <= max)
                            {
                                counter.Increase();
                                Console.WriteLine("Результат = " + counter.GetCurrent());
                                Console.WriteLine();
                                Console.WriteLine("Нажмите Enter, чтобы вернуться к выбору действия");
                                Console.ReadLine();
                            }
                            break;
                        }
                    case "-":
                        {
                            if (current >= min)
                            {
                                counter.Decrease();
                                Console.WriteLine("Результат = " + counter.GetCurrent());
                                Console.WriteLine();
                                Console.WriteLine("Нажмите Enter, чтобы вернуться к выбору действия");
                                Console.ReadLine();
                            }
                            break;
                        }
                    case "*":
                        {
                            key2 = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Введено не верное значение действия");
                            Console.WriteLine();
                            Console.WriteLine("Нажмите Enter, чтобы вернуться к выбору действия");
                            Console.ReadLine();
                            break;
                        }
                }
             }
            
        }
        public static void Task2() {
            double a, b, c;
            Console.WriteLine("Задание 2 \n«Многочлен»");
            Console.WriteLine("Введите коэффициенты квадратного многочлена вида ax^2 + bx + c = 0");
            Console.Write("Введите коэффициент a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент c = ");
            c = Convert.ToDouble(Console.ReadLine());
            Quadratic quadr = new Quadratic();          
            

            if (a == 0)
            {
                Console.WriteLine("Это не квадратное уравнение");
            }
            else if ((b == 0) || (c == 0))
            {
                quadr.ShortQuadratic( a,  b,  c);
                string quad = quadr.GetX();
                Console.WriteLine();
                Console.WriteLine(quad);
            } else {
                quadr.FullQuadratic( a,  b,  c);
                string quad = quadr.GetX();
                Console.WriteLine();
                Console.WriteLine(quad);

            }
            
        }

    }
   

}


