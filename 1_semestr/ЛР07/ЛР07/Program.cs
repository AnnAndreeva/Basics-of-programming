using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР07
{
    class Program
    {
        static void Main(string[] args)
        {


            bool key = false;
            while (key == false)
            {
                Console.WriteLine("Выберите задание Лабораторной работы №7");
                Console.WriteLine("1 - подсчитать в строке число букв;");
                Console.WriteLine("2 - подсчитать в строке среднюю длину слова");
                Console.WriteLine("3 - заменить в строке все вхождения заданного пользователем слова");
                Console.WriteLine("4 - подсчитать в строке количество вхождений заданной подстроки");
                Console.WriteLine("5 - проверить, является ли строка палиндромом ");
                Console.WriteLine("6 - проверить, является ли введенная строка датой\n");
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
                    case "3":
                        {
                            Task3();
                            Console.WriteLine();
                            Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "4":
                        {
                            Task4();
                            Console.WriteLine();
                            Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "5":
                        {
                            Task5();
                            Console.WriteLine();
                            Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "6":
                        {
                            Task6();
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
            string s;
            int k;
            Lines lines = new Lines();
            Console.WriteLine("Подсчет в строке числа букв");
            Console.WriteLine("Введите строку:");
            s = Console.ReadLine();
            k = lines.LetterCounter(s);
            Console.WriteLine("Количество букв в строке = " + k);
            Console.WriteLine();
            Console.ReadLine();
        }
        public static void Task2()
        {
            string s;
            double k;
            Lines lines = new Lines();
            Console.WriteLine("Подсчет в строке средней длины слова");
            Console.WriteLine("Введите строку:");
            s = Console.ReadLine();
            k = lines.MiddleCounter(s);
            Console.WriteLine("Средняя длина слова в строке = {0:0.0}", k);
            Console.WriteLine();
            Console.ReadLine();
        }
        public static void Task3()
        {
            string s, word, change, s1;
            Lines lines = new Lines();
            Console.WriteLine("Замена в строке все вхождения заданного пользователем слова");
            s = "Привет – самое распространенное приветствие, привет также можно передать";
            Console.WriteLine(s);
            Console.Write("Введите слово, которое хотите заменить:");
            word = Console.ReadLine();
            Console.Write("Введите слово, на которое хотите заменить:");
            change = Console.ReadLine();
            s1 = lines.Change(s, word, change);
            Console.WriteLine("Результат:");
            Console.WriteLine(s1);
            Console.WriteLine();
            Console.ReadLine();
        }
        public static void Task4()
        {
            string s, subS, s1;
            int k;
            Lines lines = new Lines();
            Console.WriteLine("Подсчет в строке количество вхождений заданной подстроки");
            s = "Привет – самое распространенное приветствие, привет также можно передать";
            Console.WriteLine(s);
            Console.Write("Введите подстроку:");
            subS = Console.ReadLine();
            k = lines.SubSCounter(s, subS);
            Console.WriteLine("Количество вхождений заданной подстроки = " + k);
            Console.WriteLine();
            Console.ReadLine();
        }
        public static void Task5()
        {
            string s;
            Lines lines = new Lines();
            Console.WriteLine("Проверка, является ли строка палиндромом");
            Console.WriteLine("Введите строку:");
            s = Console.ReadLine();
            lines.IsPalindrome(s);
            Console.WriteLine();
            Console.ReadLine();
        }
        public static void Task6()
        {
            string s;
            Lines lines = new Lines();
            Console.WriteLine("Проверка, является ли введенная строка датой");
            Console.WriteLine("Введите строку:");
            s = Console.ReadLine();
            lines.IsData(s);
            Console.WriteLine();
            Console.ReadLine();
        }

    }
}
