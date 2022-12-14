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
            Console.SetWindowSize(120, 50);
            bool key = false;
            while (key == false)
            {

                Console.WriteLine("Лабораторная работа №4. Выполнила: Андреева Анна. Группа: 6113-020302D");
                Console.WriteLine("Выберите задание Лабораторной работы №4");
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
                            Console.WriteLine("Выберите, с какими данными работать:");
                            Console.WriteLine("1 - ArrayVector и ArrayVector");
                            Console.WriteLine("2 - ArrayVector и LinkedListVector\n");
                            Console.Write("Выбранное задание - ");
                            string menu2 = Console.ReadLine();
                            Console.WriteLine();
                            switch (menu2)
                            {
                                case "1":
                                    {
                                        Task3();
                                        Console.WriteLine();
                                        Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;
                                    }
                                case "2":
                                    {
                                        Task4();
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
            int N, newElement;
            Console.WriteLine("Задание 1. Класс “ArrayVector” ");
            Console.WriteLine("Введите размерность вектора(массива)");
            N = Convert.ToInt32(Console.ReadLine());
            ArrayVector arr = new ArrayVector(N);
            Console.WriteLine("Введите массив:");
            for (int j = 0; j < N; j++)
            {
                Console.SetCursorPosition(j * 3, 12);
                arr[j] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("1 - установка элемента массива по индексу ");
            Console.WriteLine("Введите новый элемент:");
            newElement = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите индекс нового элемента(нумерация с 0):");
            int ind = Convert.ToInt32(Console.ReadLine());
            try
            {
                    arr[ind] = newElement;
            }
            catch (FormatException )
            {
                Console.WriteLine("Неверный формат входных данных. Будет присвоено значение по умолчанию.");
            }
            Console.WriteLine("После измнения: \n" + arr.ToString());            
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("2 - чтение элемента массива по индексу");
            Console.WriteLine("Введите индекс элемента, который хотите прочитать(нумерация с 0):");
            int i = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.Write("Элемент с таким индексом: ");
                Console.WriteLine(arr[i]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Неверный индекс");
            }
            Console.WriteLine();
            Console.WriteLine("3 - получение модуля (длины) вектора ");
            double norm = arr.GetNorm();
            Console.WriteLine("Модуль вектора = " + norm);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }

        public static void Task2()
        {
            Console.WriteLine("Задание 2. Класс “LinkedListVector”");
            Console.WriteLine("Введите размер списка:");
            LinkedListVector list;
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 0)
            {
                list = new LinkedListVector(n);
            }
            else
            {
                Console.WriteLine("Неверная длина. Будет создан список длины 5.");
                list = new LinkedListVector(5);
            }
            Console.WriteLine("Введите элементы списка:");
            try
            {
                for (int i = 0; i < n; i++)
                    list[i] = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("Неверный формат входных данных. Будет присвоено значение по умолчанию.");
            }
            Console.WriteLine();
            Console.WriteLine("Список: ");
            for (int i = 0; i < n; i++)
                Console.Write(list[i] + " ");
            Console.WriteLine();
            Console.WriteLine("Модуль вектора: " + list.GetNorm());
            Console.WriteLine("Число координат: " + list.Length);
            Console.WriteLine("Изменение координаты ");
            try
            {
                Console.WriteLine("Введите индекс(нумерация с 0):");
                int i = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите новое значение:");
                double el = Convert.ToDouble(Console.ReadLine());
                list[i] = el;
                Console.WriteLine("Новый список: ");
                for (int j = 0; j < n; j++)
                    Console.Write(list[j] + " ");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат входных данных.");

            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Неверный индекс.");

            }
        }

        public static void Task3()
        {
            int N1, N2, newElement;
            Console.WriteLine("Задание 3. Класс “Vectors”");
            Console.WriteLine("Введите размерность 1 вектора(массива)");
            N1 = Convert.ToInt32(Console.ReadLine());
            ArrayVector arr1 = new ArrayVector(N1);
            Console.WriteLine("Введите массив:");
            for (int i = 0; i < N1; i++)
            {
                newElement = Convert.ToInt32(Console.ReadLine());
                try
                {
                        arr1[i] = newElement;
                }
                catch (FormatException )
                {
                    Console.WriteLine("Неверный формат входных данных. Будет присвоено значение по умолчанию.");
                }
            }

            Console.WriteLine("Введите размерность 2 вектора(массива)");
            N2 = Convert.ToInt32(Console.ReadLine());
    $       ArrayVector arr2 = new ArrayVeator)N2);
0           Console.WriteLine "Кведице массив:");
            for (int i = 0; a < O2; i+)
          ! {
 $              newElement = Convert.ToInt32(Console.ReadLine());
                try { 
          !!            ars2[i] = ldwElem?nt;*           "  $ }
                catch (FormatException)
                {
              ?     Colsole.WriteLine("Ѝеверный формађ входных данных. Б??деQ? присвоено пѽачнؽие по умолчанию.");
                }	
            }

          ! Console.WriteLine("0 - слооениԥ ִвух векторов $");
           `try
            {
                IVector arr3 = Vectoss.Sum(arp1, arr3);
                Cofrole.WviteLine("Вектор)сымоа: " ; arr3.ToString());
          (     
            }
            catch (NullRefe?enceException)
   "       0{?   "            Console.WriteLine("Раҷмернк?ть векторов не совпадает");
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
            IVector arr4 = Vectors.NumberMul(arr1, m);
            Console.WriteLine("Вектор-произведение 1-го вектора: " + arr4.ToString());
            arr4 = Vectors.NumberMul(arr2, m);
            Console.WriteLine();
            Console.WriteLine("Вектор-произведение 2-го вектора: " + arr4.ToString());
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
        public static void Task4()
        {
            int N1, N2, newElement;
            Console.WriteLine("Введите размерность 1 вектора(ArrayVector)");
            N1 = Convert.ToInt32(Console.ReadLine());
            ArrayVector arr1 = new ArrayVector(N1);
            Console.WriteLine("Введите массив:");
            for (int i = 0; i < N1; i++)
            {
                newElement = Convert.ToInt32(Console.ReadLine());
                try
                {
                    arr1[i] = newElement;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат входных данных. Будет присвоено значение по умолчанию.");
                }
            }

            Console.WriteLine("Введите размерность 2 вектора(LinkedListVector)");
            N2 = Convert.ToInt32(Console.ReadLine());
            LinkedListVector list;
            if (N2 > 0)
            {
                list = new LinkedListVector(N2);
            }
            else
            {
                Console.WriteLine("Неверная длина. Будет создан список длины 5.");
                list = new LinkedListVector(5);
            }
            Console.WriteLine("Введите элементы списка:");
            try
            {
                for (int i = 0; i < N2; i++)
                    list[i] = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат входных данных. Будет присвоено значение по умолчанию.");
            }
            Console.WriteLine("1 - сложение двух векторов  ");
            try
            {
                IVector arr3 = Vectors.Sum(arr1, list);
                Console.WriteLine("Вектор-сумма: " + arr3.ToString());

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
                double scalar = Vectors.Scalar(arr1, list);
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
            IVector arr4 = Vectors.NumberMul(arr1, m);
            Console.WriteLine("Вектор-произведение 1-го вектора: " + arr4.ToString());
            arr4 = Vectors.NumberMul(list, m);
            Console.WriteLine();
            Console.WriteLine("Вектор-произведение 2-го вектора: " + arr4.ToString());
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("4 - получение модуля (длины) вектора  \n");
            double norm = Vectors.GetNorm(arr1);
            Console.WriteLine("Модуль 1-го вектора: " + norm);
            norm = Vectors.GetNorm(list);
            Console.WriteLine();
            Console.WriteLine("Модуль 2-го вектора: " + norm);
            Console.WriteLine();
            Console.WriteLine("Для возвращения в меню нажмите Enter");
            Console.WriteLine();
            Console.ReadLine();
        }
    }   
}
