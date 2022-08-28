using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР07
{
    class Program
    {
        delegate void Tasks();
        static void Main(string[] args)
        {
            Tasks t = null;
            bool key = false;
            while (key == false)
            {
                Console.WriteLine("Лабораторная работа №7. Выполнила: Андреева Анна. Группа: 6113-020302D");
                Console.WriteLine("Выберите задание Лабораторной работы №7");
                Console.WriteLine("1 - ArrayVector");
                Console.WriteLine("2 - LinkedListVector");
                Console.WriteLine("3 - Vectors(ArrayVector и ArrayVector)");
                Console.WriteLine("4 - Vectors(ArrayVector и LinkedListVector)");
                Console.WriteLine("5 - Проверка метода Equals()");
                Console.WriteLine("6 - Проверка наследования от IComparable и IComparer");
                Console.WriteLine("7 - Проверка наследования от ICloneable  \n");
                Console.WriteLine("Введите последовательность действий, которые хотите выполнить, через запятую");
                string s = Console.ReadLine();
                string[] words = s.Split(new char[] { ' ', ',', '-', ';', ':', '.', '!', '?' });
                for (int i = 0; i < words.Length; i++)
                {
                    switch (words[i])
                    {
                        case "1":
                            {
                                t += Task1;
                                break;
                            }
                        case "2":
                            {
                                t += Task2;
                                break;
                            }
                        case "3":
                            {
                                t += Task3a;
                                break;
                            }
                        case "4":
                            {
                                t += Task3b;
                                break;
                            }
                        case "5":
                            {
                                t += Task4;
                                break;
                            }
                        case "6":
                            {
                                t += Task5;
                                break;
                            }
                        case "7":
                            {
                                t += Task6;
                                break;
                            }
                        default:
                            {
                                break;
                            }
                    }
                }
                try
                {
                    t();
                }
                catch (NullReferenceException) {
                    Console.WriteLine("Введено неверное значение!");
                }
                Console.WriteLine();
                Console.ReadLine();
            }

        }
        public static void Task1()
        {

            int N, newElement;
            Console.WriteLine("++Класс “ArrayVector” ");
            Console.WriteLine("Введите размерность вектора(массива)");
            N = Convert.ToInt32(Console.ReadLine());
            ArrayVector arr;
            if (N > 0)
            {
                arr = new ArrayVector(N);
            }
            else
            {
                Console.WriteLine("Нeверная длина! Будет создан массив длины 5");
                arr = new ArrayVector(5);
            }
            Console.WriteLine("Введите массив:");
            for (int j = 0; j < N; j++)
            {
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
            catch (FormatException)
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
            Console.Clear();
        }

        public static void Task2()
        {
            Console.WriteLine("++Класс “LinkedListVector”");
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
            catch (FormatException)
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
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
        }

        public static void Task3a()
        {
            int N1, N2, newElement;
            Console.WriteLine("++Класс “Vectors”, операнды ArrayVector и ArrayVector");
            Console.WriteLine("Введите размерность 1 вектора(массива)");
            N1 = Convert.ToInt32(Console.ReadLine());
            ArrayVector arr1, arr2; 
            if (N1 > 0)
            {
                arr1 = new ArrayVector(N1);
            }
            else
            {
                Console.WriteLine("Нeверная длина! Будет создан массив длины 5");
                arr1 = new ArrayVector(5);
            }
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

            Console.WriteLine("Введите размерность 2 вектора(массива)");
            N2 = Convert.ToInt32(Console.ReadLine());
            if (N2 > 0)
            {
                arr2 = new ArrayVector(N2);
            }
            else
            {
                Console.WriteLine("Нeверная длина! Будет создан массив длины 5");
                arr2 = new ArrayVector(5);
            }
            Console.WriteLine("Введите массив:");
            for (int i = 0; i < N2; i++)
            {
                newElement = Convert.ToInt32(Console.ReadLine());
                try
                {
                    arr2[i] = newElement;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат входных данных. Будет присвоено значение по умолчанию.");
                }
            }

            Console.WriteLine("1 - сложение двух векторов  ");
            try
            {
                IVector arr3 = Vectors.Sum(arr1, arr2);
                Console.WriteLine("Вектор-сумма: " + arr3.ToString());

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Размерность векторов не совпадает");
            }
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

            Console.WriteLine("3 - умножение вектора на число");
            Console.WriteLine("Введите число: ");
            int m = Convert.ToInt32(Console.ReadLine());
            IVector arr4 = Vectors.NumberMul(arr1, m);
            Console.WriteLine("Вектор-произведение 1-го вектора: " + arr4.ToString());
            arr4 = Vectors.NumberMul(arr2, m);
            Console.WriteLine();
            Console.WriteLine("Вектор-произведение 2-го вектора: " + arr4.ToString());
            Console.WriteLine();

            Console.WriteLine("4 - получение модуля (длины) вектора  \n");
            double norm = Vectors.GetNorm(arr1);
            Console.WriteLine("Модуль 1-го вектора: " + norm);
            norm = Vectors.GetNorm(arr2);
            Console.WriteLine();
            Console.WriteLine("Модуль 2-го вектора: " + norm);
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
        }

        public static void Task3b()
        {
            int N1, N2, newElement;
            Console.WriteLine("++Класс “Vectors”, операнды ArrayVector и LinkedListVector");
            Console.WriteLine("Введите размерность 1 вектора(ArrayVector)");
            N1 = Convert.ToInt32(Console.ReadLine());
            ArrayVector arr1;
            if (N1 > 0)
            {
                arr1 = new ArrayVector(N1);
            }
            else
            {
                Console.WriteLine("Нeверная длина! Будет создан массив длины 5");
                arr1 = new ArrayVector(5);
            }
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
            Console.ReadLine();
            Console.Clear();
        }
        public static void Task4()
        {
            int N1, N2, newElement;
            Console.WriteLine("++Проверка метода Equals()");
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
            Console.WriteLine("Проверка метода c ArrayVector:");
            Console.WriteLine("Вектор 1 равен 2?" + arr1.Equals(list));
            Console.WriteLine("Хэш-код = " + arr1.GetHashCode());
            Console.WriteLine("Проверка метода c LinkedListVector:");
            Console.WriteLine("Вектор 2 равен 1?" + list.Equals(arr1));
            Console.WriteLine("Хэш-код = " + list.GetHashCode());
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
        }
        public static void Task5()
        {
            IVector max, min;
            Random rnd = new Random();
            Console.WriteLine("++Проверка наследования от IComparable и IComparer");
            Console.WriteLine("Создадим массив из 5 векторов разных типов:");
            int[] N = new int[5] { rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10) };
            IVector[] vectors = new IVector[5];
            vectors[0] = new ArrayVector(N[0]);
            vectors[1] = new LinkedListVector(N[1]);
            vectors[2] = new ArrayVector(N[2]);
            vectors[3] = new LinkedListVector(N[3]);
            vectors[4] = new ArrayVector(N[4]);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < N[i]; j++)
                {
                    vectors[i][j] = rnd.Next(-10, 10);
                }
            }
            Console.WriteLine("Массив векторов:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(vectors[i]);
            }
            Console.WriteLine();
            max = vectors[0];
            min = vectors[0];
            for (int i = 1; i < 5; i++)
            {
                if (max.CompareTo(vectors[i]) < 0)
                {
                    max = vectors[i];
                }
                if (min.CompareTo(vectors[i]) > 0)
                {
                    min = vectors[i];
                }
            }
            int L1 = max.Length;
            int L2 = min.Length;
            Console.WriteLine();
            Console.WriteLine("Максимальные по числу координат векторы:");
            for (int i = 0; i < 5; i++)
            {
                if (vectors[i].Length == L1)
                {
                    Console.WriteLine(vectors[i]);
                }
            }
            Console.WriteLine("Минимальные по числу координат векторы:");
            for (int i = 0; i < 5; i++)
            {
                if (vectors[i].Length == L2)
                {
                    Console.WriteLine(vectors[i]);
                }
            }
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
        }

        public static void Task6()
        {
            Random rnd = new Random();
            Console.WriteLine("++Проверка наследования от ICloneable");
            Console.WriteLine("Создадим массив из 5 векторов разных типов:");
            int[] N = new int[5] { rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10) };
            IVector[] vectors = new IVector[5];
            vectors[0] = new ArrayVector(N[0]);
            vectors[1] = new LinkedListVector(N[1]);
            vectors[2] = new ArrayVector(N[2]);
            vectors[3] = new LinkedListVector(N[3]);
            vectors[4] = new ArrayVector(N[4]);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < N[i]; j++)
                {
                    vectors[i][j] = rnd.Next(-10, 10);
                }
            }
            Console.WriteLine("Массив векторов:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(vectors[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Вектор для клонирования:");
            IVector first = vectors[rnd.Next(0, 4)];
            Console.WriteLine(first);
            Console.WriteLine();
            Console.WriteLine("Клон:");
            IVector clone = (IVector)first.Clone();
            Console.WriteLine(clone);
            Console.WriteLine();
            Console.WriteLine("Изменённый клон:");
            Console.WriteLine(Vectors.NumberMul(clone, 2));
            Console.WriteLine();
            Console.WriteLine("Клонируемый вектор:");
            Console.WriteLine(first);
            Console.WriteLine();
            Array.Sort(vectors, new VectorCompare());
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
        }
    }
}
