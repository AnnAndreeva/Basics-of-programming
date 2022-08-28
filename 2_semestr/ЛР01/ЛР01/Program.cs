using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(120, 50);
            bool key = false;
            while (key == false)
            {

                Console.WriteLine("Лабораторная работа №1. Выполнила: Андреева Анна. Группа: 6113-020302D");
                Console.WriteLine("Выберите задание Лабораторной работы №1");
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
        public static void OutputArr(ArrayVector v, int n)
        {
            for (int i = 0; i < n; i++)
            {
                v.GetElement(i);
            }
        }
        public static void Task1()
        {
            int N, newElement;
            Console.WriteLine("Задание 1. Класс “ArrayVector” ");
            Console.WriteLine("Введите размерность вектора(массива)");
            N = Convert.ToInt32(Console.ReadLine());
            ArrayVector arr = new ArrayVector(N);
            Console.WriteLine("Введите массив:");
            for (int j = 0; j < N; j++)
            {
                Console.SetCursorPosition(j * 3, 11);
                newElement = Convert.ToInt32(Console.ReadLine());
                arr.SetElement(j, newElement);
            }

            Console.WriteLine("1 - установка элемента массива по индексу ");
            Console.WriteLine("Введите новый элемент:");
            newElement = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите индекс нового элемента(нумерация с 0):");
            int ind = Convert.ToInt32(Console.ReadLine());
            arr.SetElement(ind, newElement);
            Console.WriteLine("Изменённый массив:");
            OutputArr(arr, N);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("2 - чтение элемента массива по индексу");
            Console.WriteLine("Введите индекс элемента, который хотите прочитать(нумерация с 0):");
            int i = Convert.ToInt32(Console.ReadLine());
            if ((i <= N) && (i >= 0))
            {
                Console.Write("Элемент с таким индексом: ");
                arr.GetElement(i);
            }
            else
            {
                Console.WriteLine("Элемент с таким индексом не существует");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("3 - получение модуля (длины) вектора ");
            int norm = arr.GetNorm();
            Console.WriteLine("Модуль вектора = " + norm);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("4 - подсчет суммы  положительных элементов массива с четными номерами");
            int sum = arr.SumPositivesFromChetIndex();
            Console.WriteLine("Cумма положительных элементов массива с четными номерами = " + sum);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("5 - подсчет суммы  элементов массива с нечетными номерами и меньше среднего значения ");
            sum = arr.SumLessFromNechetIndex();
            Console.WriteLine("Cумма элементов массива с нечетными номерами и меньше среднего значения = " + sum);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("6 - подсчет произведения всех четных положительных элементов ");
            int mul = arr.MulChet();
            if (mul == 1)
            {
                Console.WriteLine("Таких элементов не существует");
            }
            else
            {
                Console.WriteLine("Произведение всех четных положительных элементов = " + mul);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("7 - подсчет произведения всех нечетных элементов, не делящихся на три");
            mul = arr.MulNechet();
            if (mul == 1)
            {
                Console.WriteLine("Таких элементов не существует");
            }
            else
            {
                Console.WriteLine("Произведение всех нечетных элементов, не делящихся на три = " + mul);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("8 - сортировка массива");
            ArrayVector Carr1 = arr;
            Carr1.SortUp();
            Console.WriteLine("Отсортированный по возрастанию массив:");
            OutputArr(Carr1, N);
            Console.WriteLine();
            Console.WriteLine();
            Carr1.SortDown();
            Console.WriteLine("Отсортированный по убыванию массив:");
            OutputArr(Carr1, N);
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }
        public static void Task2()
        {
            int N1, N2, newElement;
            Console.WriteLine("Задание 2. Класс “Vectors”");
            Console.WriteLine("Введите размерность 1 вектора(массива)");
            N1 = Convert.ToInt32(Console.ReadLine());
            ArrayVector arr1 = new ArrayVector(N1);
            Console.WriteLine("Введите массив:");
            for (int i = 0; i < N1; i++)
            {
                Console.SetCursorPosition(i * 3, 11);
                newElement = Convert.ToInt32(Console.ReadLine());
                arr1.SetElement(i, newElement);
            }

            Console.WriteLine("Введите размерность 2 вектора(массива)");
            N2 = Convert.ToInt32(Console.ReadLine());
            ArrayVector arr2 = new ArrayVector(N2);
            Console.WriteLine("Введите массив:");
            for (int i = 0; i < N2; i++)
            {
                Console.SetCursorPosition(i * 3, 15);
                newElement = Convert.ToInt32(Console.ReadLine());
                arr2.SetElement(i, newElement);
            }

            Console.WriteLine("1 - сложение двух векторов  ");
            try
            {
                ArrayVector arr3 = Vectors.Sum(arr1, arr2);
                Console.WriteLine("Вектор-сумма: ");
                OutputArr(arr3, N1);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Размерность векторов не совпадает");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("2 - скалярное произведения двух векторов ");
            try
            {
                double scalar = Vectors.Scalar(arr1, arr2);
                Console.WriteLine("Скалярное произведение = " + scalar);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Размерность векторов не совпадает");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("3 - умножение вектора на число");
            Console.WriteLine("Введите число: ");
            int m = Convert.ToInt32(Console.ReadLine());
            ArrayVector arr4 = Vectors.NumberMul(arr1, m);
            Console.WriteLine("Вектор-произведение 1-го вектора: ");
            OutputArr(arr4, N1);
            arr4 = Vectors.NumberMul(arr2, m);
            Console.WriteLine();
            Console.WriteLine("Вектор-произведение 2-го вектора: ");
            OutputArr(arr4, N2);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("4 - получение модуля (длины) вектора  \n");
            double norm = Vectors.GetNorm(arr1);
            Console.WriteLine("Модуль 1-го вектора: " + norm);
            norm = Vectors.GetNorm(arr2);
            Console.WriteLine();
            Console.WriteLine("Модуль 2-го вектора: " + norm);
            Console.WriteLine();
            Console.WriteLine("Для возвращения в меню нажмите Enter");
            Console.WriteLine();
            Console.ReadLine();

            Console.ReadLine();
        }
    }

}
