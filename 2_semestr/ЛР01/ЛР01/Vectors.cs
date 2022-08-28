using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР01
{
    class Vectors
    {
        public Vectors()
        {

        }
        static public ArrayVector Sum(ArrayVector v1, ArrayVector v2)
        {
            ArrayVector v3 = new ArrayVector();
            if (v1.arr.Length == v2.arr.Length) {
                for (int i = 0; i < v1.arr.Length; i++)
                {
                    v3.arr[i] = v1.arr[i] + v2.arr[i];
                }
            }
            else v3 = null;
            return v3;
        }
        static public double Scalar(ArrayVector v1, ArrayVector v2)
        {
            double scalar = 0;
            if (v1.arr.Length == v2.arr.Length)
            {
                for (int i = 0; i < v1.arr.Length; i++)
                {
                    scalar += v1.arr[i] * v2.arr[i];
                }
            }
            else throw new NullReferenceException();
            return scalar;
        }

        static public ArrayVector NumberMul(ArrayVector v1, double m)
        {
            ArrayVector v3 = new ArrayVector();
            for (int i = 0; i < v1.arr.Length; i++) { 
                {
                    v3.arr[i] = Convert.ToInt32(v1.arr[i] * m);
                }
            }
            return v3;
        }

        static public double GetNorm(ArrayVector v1)
        {
            double norm = 0;
            for (int i = 0; i < v1.arr.Length; i++)
            {
                norm += Convert.ToInt32(Math.Pow(v1.arr[i], 2));
            }
            norm = Convert.ToInt32(Math.Sqrt(norm));
            return norm;           
        }
    }
}
