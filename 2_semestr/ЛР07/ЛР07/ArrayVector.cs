using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР07
{
    class ArrayVector : IVector, IComparable, ICloneable
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
            for (int i = 0; i < Length; i++)
            {
                v += arr[i] + " ";
            }
            return "Число координат вектора: " + arr.Length + ", координаты вектора через пробел:" + v + ".";
        }

        public override bool Equals(object obj)
        {
            IVector v = (IVector)obj;
            int k = 0;
            for (int i = 0; i < Length; i++)
            {
                if (this[i] == v[i])
                    k++;
            }
            if ((this.Length == v.Length) && (k == v.Length))
                return true;
            else return false;
        }

        public override int GetHashCode()
        {
            return Length.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            IVector v = (IVector)obj;
            if (v == null)
            {
                throw new ArgumentException("Объект не вектор.");
            }
            else
            {
                if (this.Length > v.Length) return 1;
                else if (this.Length < v.Length) return -1;
                else return 0;
            }
        }

        public object Clone()
        {
            ArrayVector a = new ArrayVector(Length);
            for (int i = 0; i < Length; i++)
            {
                a[i] = arr[i];
            }
            return a;
        }
    }
}
