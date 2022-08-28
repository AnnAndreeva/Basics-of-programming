using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР07_extra
{
    class Calculator
    {
        string input;
        char[] charArr;
        int length;
        int current = -1;
        char symbol;

        public Calculator()
        { }

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

        bool isDigit(char digit)  //проверяем, римские цифры ли в строки
        {
            return digit == 'I' || digit == 'V' || digit == 'X' || digit == 'L' || digit == 'C' || digit == 'D' || digit == 'M';

        }

        public int ReadNumber()   //считываем число из строки
        {
            string str = "";
            int value = 0;
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
            value = ToArabian(str);
            return value;

        }

        public int ToArabian(string str)  //перевод в арабские цифры
        {
            Dictionary<char, int> Romans = new Dictionary<char, int>();
            Romans.Add('M', 1000);
            Romans.Add('D', 500);
            Romans.Add('C', 100);
            Romans.Add('L', 50);
            Romans.Add('X', 10);
            Romans.Add('V', 5);
            Romans.Add('I', 1);

            int sum = 0;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (Romans[str[i]] < Romans[str[i + 1]])
                    sum -= Romans[str[i]];
                else
                    sum += Romans[str[i]];
            }
            return sum += Romans[str[str.Length - 1]];
        }

        public string ToRoman(int value) //перевод в римские цифры
        {
            string str = "";
            // Выделяем тысячи
            int m1 = value / 1000;
            for (int i = 0; i < m1; i++)
            {
                str += "M";
            }

            // то что осталось после тысяч
            int m2 = value % 1000;

            // Выделяем пятьсот из остатка от тысячи
            int d1 = m2 / 500;
            for (int i = 0; i < d1; i++)
            {
                str += "D";
            }

            // остаток после выделения полтысячи
            int d2 = m2 % 500;

            // Выделяем сотни из остатка
            int c1 = d2 / 100;
            for (int i = 0; i < c1; i++)
            {
                str += "C";
            }

            // остаток из сотен
            int c2 = d2 % 100;

            // Выделяем полсотни
            int l1 = c2 / 50;
            for (int i = 0; i < l1; i++)
            {
                str += "L";
            }

            // остаток
            int l2 = c2 % 50;

            // Выделяем десятки
            int x1 = l2 / 10;
            for (int i = 0; i < x1; i++)
            {
                str += "X";
            }

            // остаток
            int x2 = l2 % 10;
            if (x2 == 9) {
                str += "IX";
            }
            else if (x2 == 5)
            {
                str += "V";
            }
            else if(x2 == 4)
            {
                str += "IV";
            }
            else
            {
                for (int i = 0; i < x2; i++)
                {

                    str += "I";
                }
            }
            return str;
        }

        public int FirstPriority()   //считаем умножение или деление
        {
            int d = ReadNumber();
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

        public int SecondPriority()  //считаем сложение или вычитание
        {
            int d = FirstPriority();
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
}
