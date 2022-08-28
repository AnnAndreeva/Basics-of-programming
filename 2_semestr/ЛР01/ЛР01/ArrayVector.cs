using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР01
{
    class ArrayVector
    {
        public int[] arr;
        public ArrayVector()
        {
            arr = new int[5];
        }
        public ArrayVector(int n)
        {
            arr = new int[n];
        }
       

        public int[] SetElement(int index, int newElement)
        {
            if ((index <= arr.Length) && (index >= 0))
            {
                arr[index] = newElement;
            }
            else
            {
                Console.WriteLine("Элемент с таким индексом невозможно установить");
            }
            return arr;
        }

        public void GetElement(int index)
        {
                Console.Write(arr[index]+" ");            
        }

        public int GetNorm()
        {
            int norm = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                norm += Convert.ToInt32(Math.Pow(arr[i], 2));
            }
            norm = Convert.ToInt32(Math.Sqrt(norm));
            return norm;
        }

        public int SumPositivesFromChetIndex()
        {
            int s = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                {
                    s += arr[i];
                }
            }
            return s;
        }

        public int SumLessFromNechetIndex()
        {
            int abs = 0, s = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                abs += Convert.ToInt32(Math.Abs(arr[i]));
            }
            abs = abs / arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((i % 2 != 0)&&(arr[i]<abs))
                {
                    s += arr[i];
                }
            }
            return s;
        }

        public int MulChet()
        {
            int  m = 1;
            
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] % 2 == 0) && (arr[i] > 0))
                {
                    m *= arr[i];
                }
            }
            return m;
        }

        public int MulNechet()
        {
            int m = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] % 3 != 0) && (arr[i] % 2 != 0))
                {
                    m *= arr[i];
                }
            }
            return m;
        }

        public void SortUp()
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
        }

        public void SortDown()
        {
            int v, i, j;
            for (i = 0; i < arr.Length; i++)
            {
                v = arr[i];
                for (j = i - 1; (j >= 0) && (arr[j] < v); j--)
                {
                    arr[j + 1] = arr[j];
                }

                arr[j + 1] = v;
            }
        }
    }
}
