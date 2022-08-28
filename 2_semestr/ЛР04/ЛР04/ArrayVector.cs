using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР04
{
    class ArrayVector : IVector
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

        public double this[int id]
        {
            get
            {
                try
                { return arr[id]; }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Неверный индекс");
                    return 0.0;
                }
            }
            set
            {
                try
                { arr[id] = value; }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Неверный индекс");
                }
            }
        }

        public double GetNorm()
        {
            double norm = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                norm += Math.Pow(arr[i], 2);
            }
            norm = Math.Sqrt(norm);
            return norm;
        }
        public override string ToString()
        {
            string v = "";
            for (int i = 0; i < Length; i++) {
                v += arr[i] + " ";
            }
            return "Число координат вектора: " + arr.Length + ", координаты вектора через пробел:" + v + ".";
        }
    }
}

