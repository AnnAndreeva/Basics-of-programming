using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ЛР06
{
    class Program
    {
        static void Main(string[] args)
        {
            bool key = false;
            while (key == false)
            {

                Console.WriteLine("Лабораторная работа №6. Выполнила: Андреева Анна. Группа: 6113-020302D");
                Console.WriteLine("Выберите задание");
                Console.WriteLine("1 - ArrayVector");
                Console.WriteLine("2 - LinkedListVector");
                Console.WriteLine("3 - Vectors");
                Console.WriteLine("4 - Проверка метода Equals()");
                Console.WriteLine("5 - Проверка наследования от IComparable");
                Console.WriteLine("6 - Проверка наследования от ICloneable");
                Console.WriteLine("7 - Работа с байтовым потоком");
                Console.WriteLine("8 - Работа с текстовым потоком");
                Console.WriteLine("9 - Сериализация \n");
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
                            Console.WriteLine("Класс “Vectors”");
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
                                        Task3a();
                                        Console.WriteLine();
                                        Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                                        Console.ReadLine();
                                        break;
                                    }
                                case "2":
                                    {
                                        Task3b();
                                        Console.WriteLine();
                                        Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                                        Console.ReadLine();
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
                    case "7":
                        {
                            Task7();
                            Console.WriteLine();
                            Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "8":
                        {
                            Task8();
                            Console.WriteLine();
                            Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    case "9":
                        {
                            Task9();
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
            int N = 0, newElement;
            Console.WriteLine("Класс “ArrayVector” ");
            Console.WriteLine("Введите размерность вектора(массива)");
            ArrayVector arr;
            try
            {
                N = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверная длина. Будет создан вектор длины 5.");
                N = 5;
            }
            try
            {
                arr = new ArrayVector(N);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Неверная длина. Будет создан вектор длины 5.");
                arr = new ArrayVector();
            }
            Console.WriteLine("Введите массив:");
            try
            {
                for (int j = 0; j < N; j++)
                {
                    arr[j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный формат входных данных. Будет присвоено значение по умолчанию.");
                for (int j = 0; j < N; j++)
                {
                    arr[j] = 0.0;
                }
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
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
        }

        public static void Task2()
        {
            Console.WriteLine("Класс “LinkedListVector”");
            Console.WriteLine("Введите размер списка:");
            LinkedListVector list;
            int n = 0;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверная длина. Будет создан список длины 5.");
                n = 5;
            }
            try
            {
                list = new LinkedListVector(n);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Неверная длина. Будет создан список длины 5.");
                list = new LinkedListVector();
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
                for (int i = 0; i < n; i++)
                    list[i] = 0.0;
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

        public static void Task3a()
        {
            int N1, N2, newElement;
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
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат входных данных. Будет присвоено значение по умолчанию.");
                }
            }

            Console.WriteLine("Введите размерность 2 вектора(массива)");
            N2 = Convert.ToInt32(Console.ReadLine());
            ArrayVector arr2 = new ArrayVector(N2);
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

        public static void Task3b()
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
        public static void Task4()
        {
            int N1, N2, newElement;
            Console.WriteLine("Проверка метода Equals()");
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
            Console.WriteLine("Для возвращения в меню нажмите Enter");
            Console.WriteLine();
            Console.ReadLine();
        }
        public static void Task5()
        {
            IVector max, min;
            Random rnd = new Random();
            Console.WriteLine("Проверка наследования от IComparable");
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
        }

        public static void Task6()
        {
            Random rnd = new Random();
            Console.WriteLine("Проверка наследования от IComparable");
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

            Console.ReadLine();
        }

        public static void Task7()
        {
            
            Random rnd = new Random();
            Console.WriteLine("Работа с байтовым потоком");
            int[] N = new int[3] { rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10)};
            IVector[] vectors = new IVector[3];
            vectors[0] = new ArrayVector(N[0]);
            vectors[1] = new LinkedListVector(N[1]);
            vectors[2] = new ArrayVector(N[2]);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < N[i]; j++)
                {
                    vectors[i][j] = rnd.Next(0, 20);
                }
            }
            Console.WriteLine("Массив векторов:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(vectors[i]);
            }
            FileStream Bf = new FileStream("byte.txt", FileMode.Create, FileAccess.ReadWrite);
            for (int i = 0; i < 3; i++) {
                Vectors.InputVector(vectors[i], Bf);
            }

            Console.WriteLine("Векторы записаны в файл");
            Bf.Position = 0;
            Console.WriteLine("....................................");
            Console.WriteLine("Читаем векторы из файла");
            IVector[] Nvectors = new IVector[3];
            for (int i = 0; i < 3; i++)
            {
               Nvectors[i] = Vectors.OutputVector(Bf);
               Console.WriteLine(Nvectors[i].ToString());
            }
            Bf.Close();           
            Console.ReadLine();
        }

        public static void Task8()
        {
            
            Random rnd = new Random();
            Console.WriteLine("Работа с текстовым потоком");
            int[] N = new int[3] { rnd.Next(1, 10), rnd.Next(1, 10), rnd.Next(1, 10) };
            IVector[] vectors = new IVector[3];
            vectors[0] = new ArrayVector(N[0]);
            vectors[1] = new LinkedListVector(N[1]);
            vectors[2] = new ArrayVector(N[2]);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < N[i]; j++)
                {
                    vectors[i][j] = rnd.Next(0, 20);
                }
            }
            Console.WriteLine("Массив векторов:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(vectors[i]);
            }

            TextWriter Tw = File.CreateText("text.txt");
            for (int i = 0; i < 3; i++)
            {
                Vectors.WriteVector(vectors[i], Tw);
            }
            Console.WriteLine("Текст записан в файл");
            Tw.Close();

            Console.WriteLine("----------------------");
            TextReader Tr = File.OpenText("text.txt");
            IVector[] Nvectors = new IVector[3];
            for (int i = 0; i < 3; i++)
            {
                Nvectors[i] = Vectors.ReadVector(Tr);
                Console.WriteLine(Nvectors[i].ToString());
            }
            Tr.Close();

            Console.ReadLine();
        }

        public static void Task9()
        {
            Console.WriteLine("Сериализация");
            Random rnd = new Random();
            int[] N = new int[2] { rnd.Next(1, 10), rnd.Next(1, 10)};
            ArrayVector arr = new ArrayVector(N[0]);
            LinkedListVector list = new LinkedListVector(N[1]);
            for (int i = 0; i < N[0]; i++)
            {
                    arr[i] = rnd.Next(-10, 10);                
            }
            for (int i = 0; i < N[1]; i++)
            {
                list[i] = rnd.Next(-10, 10);
            }           

            FileStream fs = File.Create("arr.bin");
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, arr);
            fs.Close();
            fs = File.OpenRead("arr.bin");
            ArrayVector Carr = (ArrayVector)bf.Deserialize(fs);
            fs.Close();

            fs = File.Create("list.bin");
            bf.Serialize(fs, list);
            fs.Close();
            fs = File.OpenRead("list.bin");
            LinkedListVector Clist = (LinkedListVector)bf.Deserialize(fs);
            fs.Close();

            Console.WriteLine("----------------------");
            Console.WriteLine("Исходный ArrayVector:");
            Console.WriteLine(arr.ToString());
            Console.WriteLine("Считанный ArrayVector:");
            Console.WriteLine(Carr.ToString());

            Console.WriteLine("----------------------");
            Console.WriteLine("Исходный LinkedListVector:");
            Console.WriteLine(list.ToString());
            Console.WriteLine("Считанный LinkedListVector:");
            Console.WriteLine(Clist.ToString());

            Console.ReadLine();
        }
    }
}

