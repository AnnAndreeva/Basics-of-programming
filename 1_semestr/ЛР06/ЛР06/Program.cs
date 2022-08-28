using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР06
{
    class Program
    {
        static void Main(string[] args)
        {

            bool key = false;
            while (key == false)
            {
                Console.WriteLine("Выберите задание Лабораторной работы №6");
                Console.WriteLine("1 - первое задание");
                Console.WriteLine("2 - второе задание");
                Console.WriteLine("3 - третье задание\n");
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
            int n;
            Sort sort = new Sort();
            Console.WriteLine("Задание 1. «Сортировка»");
            Console.WriteLine("Сортировка одномерного массива 4 способами");
            Console.Write("Введите длину массива: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int[] copyarr = new int[n];
            arr = sort.InputArr(n);
            copyarr = arr;
            Console.WriteLine("Проверка шейкерной сортировки:");
            copyarr = sort.ShakerSort(copyarr);
            sort.OutputArr(n, copyarr, 13);
            Console.WriteLine();

            Console.WriteLine("Проверка сортировки вставками:");
            copyarr = arr;
            copyarr = sort.InsertianSort(copyarr);
            sort.OutputArr(n, copyarr, 16);
            Console.WriteLine();

            Console.WriteLine("Проверка гномьей сортировки:");
            copyarr = arr;
            copyarr = sort.GnomeSort(copyarr);
            sort.OutputArr(n, copyarr, 19);
            Console.WriteLine();

            Console.WriteLine("Проверка быстрой сортировки:");
            copyarr = arr;
            sort.QuickSort(copyarr, 0, n - 1);
            sort.OutputArr(n, copyarr, 22);
            Console.WriteLine();
            Console.ReadLine();
        }
        public static void Task2()
        {
            Console.WriteLine("Задание 2. «Массивы»");
            Console.WriteLine("Сортировка матрицы из рандомных элементов");
            int n, m;
            MyArray myArray = new MyArray();
            Console.Write("Введите кол-во строк(m): ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во столбцов(n): ");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] matr = new int[m, n];
            int[,] copymatr = new int[m, n];
            matr = myArray.InputMatr(n, m);
            copymatr = matr;
            Console.WriteLine("Полученная матрица рандомных элементов: ");
            myArray.OutputMatr(n, m, matr, 8);
            Console.WriteLine();

            copymatr = myArray.SortMatrUP(n, m, matr);
            Console.SetCursorPosition(0, m+13);
            Console.WriteLine("Отсортированная по возрастанию сумм элементов столбца матрица : ");
            myArray.OutputMatr(n, m, matr, m + 10 );
            Console.WriteLine();

            matr = myArray.SortMatrDown(n, m, matr);
            Console.SetCursorPosition(0, m + 17);
            Console.WriteLine("Отсортированная по убыванию сумм элементов столбца матрица : ");
            myArray.OutputMatr(n, m, matr, m + 14);

            Console.ReadLine();
        }
        public static void Task3()
        {
            Console.WriteLine("Задание 3. «Ступенчатые массивы»");
            Console.WriteLine("Сортировка ступенчатого массива(по возрастанию)");

            int N;

            StepArray stepArray = new StepArray();
            Console.Write("Введите размерность ступенчатого массива: ");
            N = Convert.ToInt32(Console.ReadLine());
            
            int[][] sArr = new int[N][];
            
            sArr = stepArray.InputStepArr(N);
            sArr = stepArray.ArrToStepArr( sArr);
            Console.SetCursorPosition(0, 17);
            Console.WriteLine("Отсортированный по возрастанию массив : ");
            sArr = stepArray.OutputStepArr( sArr);

            Console.ReadLine();
        }
    }

}



