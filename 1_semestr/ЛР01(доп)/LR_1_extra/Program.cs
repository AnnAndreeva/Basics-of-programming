using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_1_extra
{
    class Calculator
    {
        string input;
        char[] charArr;
        int length;
        int current = -1;
        char symbol;
        public Calculator(String input)
        {
            this.input = input;
            charArr = input.ToCharArray();  //переводим полученную на входе строку в массив символов
            length = charArr.Length;
        }
        char nextToken()  //выбираем следующий символ из строки
        {
            ++current;
            if (current == length) return 'p';
            return charArr[current];
        }
        bool isDigit(char digit)  //проверяем, цифры ли в строки
        {
            return digit == '0' || digit == '1' || digit == '2' || digit == '3' || digit == '4' || digit == '5' || digit == '6' || digit == '7' || digit == '8' || digit == '9';
        }

        public double ReadNumber()   //считываем число из строки
        {
            string str = "";
            double value = 0.0;
            while (true)
            {

                symbol = nextToken();
                if (isDigit(symbol))
                {
                    str += symbol;
                }
                else
                {
                    break;
                }
            }
            value = double.Parse(str);
            return value;

        }

        public double FirstPriority()   //считаем умножение или деление
        {
            double d = ReadNumber();
            switch (symbol)
            {
                case '*':
                    d *= ReadNumber();
                    break;
                case '/':
                    d /= ReadNumber();
                    break;
                default:
                    break;

            }
            return d;
        }

        public double SecondPriority()  //считаем сложение или вычитание
        {
            double d = FirstPriority();
            while (true)
            {
                switch (symbol)
                {
                    case '+':
                        d += FirstPriority();
                        break;
                    case '-':
                        d -= FirstPriority();
                        break;
                    default:
                        break;

                }
                if (symbol == 'p') break;
            }
            return d;

        }          

       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дополнительное задание к лабораторной работе № 1.");
            Console.WriteLine("Калькулятор.");
            Console.WriteLine("Введите выражение: ");
            string input = Console.ReadLine();
            Console.Write("Ответ: ");
            Console.Write(new Calculator(input).SecondPriority());
            Console.ReadLine();
        }
    }
}
