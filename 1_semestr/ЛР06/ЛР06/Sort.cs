using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР06
{
    class Sort
    {
        public int n;
        public Sort()
        {
        }

        public Sort(int n)
        {
            this.n = n;

        }

        public int[] InputArr(int n)
        {
            int[] arr = new int[n];
            Console.WriteLine("Введите массив:");
            for (int i = 0; i < n; i++)
            {
                Console.SetCursorPosition(i*3, 11);
                arr[i] = Convert.ToInt32(Console.ReadLine());

            }
            return arr;
        }
        public int[] OutputArr(int n, int[] arr, int k)
        {
            
            for (int i = 0; i < n; i++)
            {
                Console.SetCursorPosition(i*3 , k ); 
                Console.Write(arr[i]);
            }
            return arr;
        }

        public int[] ShakerSort(int[] arr)
        {
            int  b = 0;
            int left = 0;//Левая граница
            int right = arr.Length - 1;//Правая граница
            while (left < right)
            {
                for (int i = left; i < right; i++)//Слева направо...
                {
                    if (arr[i] > arr[i + 1])
                    {
                        b = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = b;
                        b = i;
                    }
                }
                right = b;//Сохраним последнюю перестановку как границу
                if (left >= right) break;//Если границы сошлись выходим
                for (int i = right; i > left; i--)//Справа налево...
                {
                    if (arr[i - 1] > arr[i])
                    {
                        b = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = b;
                        b = i;
                    }
                }
                left = b;//Сохраним последнюю перестановку как границу
            }
            return arr;
        }
            
        
        public int[] InsertianSort(int[] arr)
        {
            int v, i, j;
            for (i = 0; i < arr.Length; i++)
            {
                v = arr[i];
                for (j = i - 1; (j >= 0) && (arr[j] > v); j--)
                {
                    arr[j + 1] = arr[j];
                }

                arr[j + 1] = v;
            }
            return arr;
        }

        public int[] GnomeSort(int[] arr)
        {
            int i = 1;
            int j = 2;
            while (i < arr.Length)
            {
                if (arr[i - 1] <= arr[i])
                {
                    i = j;
                    j++;
                }
                else
                {
                    int b = arr[i - 1];
                    arr[i - 1] = arr[i];
                    arr[i] = b;
                    i--;
                    if (i == 0)
                    {
                        i = j;
                        j++;
                    }
                }
            }
            return arr;
        }
        
        public void QuickSort(int[] arr, int first, int last)
        {
            int v;
            int i = first, j = last;
            double mid = arr[(first + last) / 2];
            while (i <= j)
            {
                while (arr[i] < mid) ++i;
                while (arr[j] > mid) --j;
                if (i <= j)
                {
                    v = arr[i];
                    arr[i] = arr[j];
                    arr[j] = v;
                    ++i; --j;
                }
            }
            if (j > first) QuickSort(arr, first, j);
            if (i < last) QuickSort(arr, i, last);
        }
    }
}

