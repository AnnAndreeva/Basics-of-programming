﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double z1, z2, a;
            Console.WriteLine("Лабораторная работа 1 \nЗадание 1 \nРасчет по двум формулам");
            Console.Write("Введите число для расчета по двум формулам а = ");
            a = Convert.ToDouble(Console.ReadLine());
            if ((a != 0) && (a != -2) && (a != 2))
            {
                z1 = Math.Pow(((((1 + a + Math.Pow(a, 2))) / (2 * a + Math.Pow(a, 2))) + 2 - (((1 - a + Math.Pow(a, 2))) / (2 * a - Math.Pow(a, 2)))), -1) * (5 - 2 * Math.Pow(a, 2));
                Console.WriteLine("Результат расчета по первой формуле = " + z1);
            }
            else
            {
                Console.WriteLine("Нельзя посчитать по первой формуле");
            }
            z2 = (4 - Math.Pow(a, 2)) / 2;
            Console.WriteLine("Результат расчета по второй формуле = " + z2);
            Console.ReadLine();
        }
    }
}
