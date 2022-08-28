using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР07_extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дополнительное задание к лабораторной работе № 7");
            Console.WriteLine("Калькулятор с римскими цифрами");
            Console.WriteLine("Введите выражение: ");
            string input = Console.ReadLine();
            Calculator calculator = new Calculator(input);
            Console.Write("Ответ: ");
            int d = calculator.SecondPriority();
            string res = calculator.ToRoman(d);
            Console.Write(res);
            Console.ReadLine();
        }
    }
}
