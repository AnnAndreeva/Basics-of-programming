using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР02
{
    class ArrayVector
    {
        public double[] arr;
        public ArrayVector()
        {
            arr = new double[5];
        }
        public ArrayVector(int n)
        {
            arr = new double[n];
        }

        public int Length
        {
            get { return arr.Length; }
            
        }

        public double[] SetElement(int index, int newElement)
        {
           try {

                arr[index] = newElement;
            }
            catch(IndexOutOfRangeException) {

                Console.WriteLine("Элемент с таким индексом невозможно установить");
            }
            return arr;
        }

        public void GetElement(int index)
        {
            try
            {
                Console.Write(arr[index] + " ");
            }
            catch (IndexOutOfRangeException)
            {

                Console.WriteLine("Неверный индекс");
            }
           
        }

        public double GetNorm()
        {
            double norm = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                norm += Convert.ToInt32(Math.Pow(arr[i], 2));
            }
            norm = Convert.ToInt32(Math.Sqrt(norm));
            return norm;
        }
    }
}
