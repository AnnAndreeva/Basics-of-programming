﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Лабораторная работа 1 \nЗадание 3 \nОпределение попадания в мишень");
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
            Console.ReadLine();
        }
    }
}
