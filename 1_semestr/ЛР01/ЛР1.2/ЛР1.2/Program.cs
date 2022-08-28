using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, x, r = 2;
            Console.WriteLine("Лабораторная работа 1 \nЗадание 2 \nВычисление значения заданной функции");
            Console.Write("Введите x = ");
            x = Convert.ToDouble(Console.ReadLine());
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
                Console.WriteLine("Значение функции равно " + y);

            }
            else
            {
                Console.WriteLine("Значение функции не определено");
            }
            Console.ReadLine();

        }
    }
}
