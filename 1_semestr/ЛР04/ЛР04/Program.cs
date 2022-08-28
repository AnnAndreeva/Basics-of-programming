using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР04
{

    class Program
    {
        static void Main(string[] args)
        {
            bool key = false;
            while (key == false)
            {
                Console.WriteLine("Выберите задание Лабораторной работы №4");
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
            Console.WriteLine("Задание 1. «Ввод и обработка матриц»");
            Console.WriteLine("Выберите, с какими матрицами будете работать:");
            Console.WriteLine("1 - квадратные");
            Console.WriteLine("2 - прямоугольные\n");
            Console.Write("Выбранный тип матриц: ");
            string menuMatr = Console.ReadLine();
            Console.WriteLine();
            switch (menuMatr)
            {
                case "1":
                    {
                        Console.WriteLine("Выберите, что будете делать:");
                        Console.WriteLine("+ - складывать, вычитать, умножать матрицы");
                        Console.WriteLine("# - считать определитель матрицы");
                        Console.Write("Выбор: ");
                        string menuQuadrMatr = Console.ReadLine();
                        Console.WriteLine();
                        switch (menuQuadrMatr)
                        {
                            case "+":
                                {
                                    QuadrMatr();
                                    Console.ReadLine();
                                    break;
                                }
                            case "#":
                                {
                                    DetQuadMatr();
                                    Console.ReadLine();
                                    break;
                                }
                        }
                        break;
                    }
                case "2":
                    {
                        Matr();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Введено значение, не соответствующее ни одному пункту меню.");
                        break;
                    }
            }
        }
        public static void Task2()
        {
            int a;
            Console.WriteLine("Задание 2. «Перевод из двоичной системы счисления в десятичную»");
            Console.Write("Введите число = ");
            a = Convert.ToInt32(Console.ReadLine());
            Binary binary = new Binary();
            a = binary.ToBinary(a);
            Console.WriteLine("Это же число в двоичной системе счисления = " + a);
            a = binary.Triads(a);
            Console.WriteLine("После смены первой и третьей триады = " + a);
            a = binary.ToDecimal(a);
            Console.WriteLine("В десятичной системе счисления = " + a);
            Console.ReadLine();
        }
        public static void QuadrMatr()
        {
            int n1, n2;
            int r = 0, m = 17; //переменные для красивого вывода матриц            
            Matrix matrix = new Matrix();
            Console.SetCursorPosition(r, m);
            Console.Write("Введите размер 1 матрицы: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            if ((n1 <= 10) && (n1 >= 1))
            {
                double[,] matr1 = new double[n1, n1];
                matr1 = matrix.InputMatr(n1, n1, r, m);
                r += 32;
                Console.SetCursorPosition(r, m);
                Console.Write("Введите размер 2 матрицы: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                if ((n2 <= 10) && (n2 >= 1))
                {
                    if (n1 == n2)
                    {
                        double[,] matr2 = new double[n2, n2];
                        matr2 = matrix.InputMatr(n2, n2, r, m);
                        Console.WriteLine();
                        bool key = false;
                        while (key == false)
                        {
                            Console.WriteLine("Выберите действие:");
                            Console.WriteLine("+ - сложение матриц");
                            Console.WriteLine("- - вычитание матриц");
                            Console.WriteLine("* - умножение матриц");
                            Console.WriteLine();
                            Console.Write("Выбранное действие: ");
                            string choice = Console.ReadLine();
                            Console.WriteLine();
                            switch (choice)
                            {
                                case "+":
                                    {
                                        matrix.SumMatr(n1, n1, m, matr1, matr2);
                                        Console.WriteLine("Для возвращения в меню нажмите Enter");
                                        Console.ReadLine();
                                        break;
                                    }
                                case "-":
                                    {
                                        matrix.DifMatr(n1, n1, m, matr1, matr2);
                                        Console.WriteLine("Для возвращения в меню нажмите Enter");
                                        Console.ReadLine();
                                        break;
                                    }
                                case "*":
                                    {
                                        matrix.MultiMatr(n1, n1, m, matr1, matr2);
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
                    else
                    {
                        Console.SetCursorPosition(0, m + 10);
                        Console.WriteLine("Операции возможна только для матриц одинаковых размеров");
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректный размер 2 матрицы. Его значение должно быть в пределах [1, 10]. ");
                }

            }
            else
            {
                Console.WriteLine("Вы ввели некорректный размер 1 матрицы. Его значение должно быть в пределах [1, 10]. ");
            }
        }
        public static void DetQuadMatr()
        {
            int n;
            int r = 0, m = 17;
            Matrix matrix = new Matrix();
            Console.SetCursorPosition(r, m);
            Console.Write("Введите размер матрицы: ");
            n = Convert.ToInt32(Console.ReadLine());
            double[,] matr = new double[n, n];
            matr = matrix.InputMatr(n, n, r, m);
            Console.WriteLine("Определитель матрицы =" + matrix.DetMatr(n, matr));

        }
        public static void Matr()
        {
            int n1, n2, m1, m2;
            Matrix matrix = new Matrix();
            int r = 0, p = 15; //переменная для красивого вывода матриц
            Console.Write("Введите кол-во строк 1 матрицы: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов 1 матрицы: ");
            m1 = Convert.ToInt32(Console.ReadLine());
            double[,] matr1 = new double[n1, m1];
            matr1 = matrix.InputMatr(n1, m1, r, p);
            r += 40;
            Console.SetCursorPosition(r, p - 2);
            Console.Write("Введите кол-во строк 2 матрицы: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(r, p - 1);
            Console.Write("Введите кол-во столбцов 2 матрицы: ");
            m2 = Convert.ToInt32(Console.ReadLine());
            if ((n1 == n2) && (m1 == m2)){
                double[,] matr2 = new double[n2, m2];
                matr2 = matrix.InputMatr(n2, m2, r, p);
                Console.WriteLine();
                bool key = false;
                while (key == false)
                {
                    Console.WriteLine("Выберите действие:");
                    Console.WriteLine("+ - сложение матриц");
                    Console.WriteLine("- - вычитание матриц\n");
                    
                    Console.WriteLine();
                    Console.Write("Выбранное действие: ");
                    string choice = Console.ReadLine();

                    Console.WriteLine();
                    switch (choice)
                    {
                        case "+":
                            {


                                matrix.SumMatr(n1, m1, p + 1, matr1, matr2);
                                Console.WriteLine();
                                Console.WriteLine("Для возвращения в меню нажмите Enter");
                                Console.ReadLine();


                                break;
                            }
                        case "-":
                            {
                                matrix.DifMatr(n1, m1, p + 1, matr1, matr2);
                                Console.WriteLine("Для возвращения в меню нажмите Enter");
                                Console.WriteLine();
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
            else
            {
                Console.SetCursorPosition(0, p + 10);
                Console.WriteLine("Сложение и вычитание возможнo только для матриц одинаковых размеров");
                if (m1 == n2)
                {
                    Console.WriteLine("Вам доступно только умножение матриц");
                    double[,] matr2 = new double[n2, m2];
                    matr2 = matrix.InputMatr(n2, m2, r, p);
                    matrix.MultiRMatr(n1, m1, m2, p + 1, matr1, matr2);
                }
                else Console.WriteLine("Операция возможна только для матриц с совпадающим кол-вом строк 1-й и столбцов 2-й");
                Console.WriteLine();
                Console.WriteLine("Для возвращения в меню нажмите Enter");
                Console.ReadLine();
            }
        }
    }
}




