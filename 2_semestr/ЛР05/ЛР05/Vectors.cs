using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР05
{
    class Vectors
    {
        public Vectors()
        {

        }
        static public IVector Sum(IVector v1, IVector v2)
        {
            IVector v3;
            if (v1.Length == v2.Length)
            {
                v3 = new ArrayVector(v1.Length);
                for (int i = 0; i < v1.Length; i++)
                {
                    v3[i] = v1[i] + v2[i];
                }
            }
            else v3 = null;
            return v3;
        }
        static public double Scalar(IVector v1, IVector v2)
        {
            double scalar = 0;
            if (v1.Length == v2.Length)
            {
                for (int i = 0; i < v1.Length; i++)
                {
                    scalar += v1[i] * v2[i];
                }
            }
            else throw new NullReferenceException();
            return scalar;
        }

        static public IVector NumberMul(IVector v1, double m)
        {
            IVector v3 = new ArrayVector(v1.Length);
            for (int i = 0; i < v1.Length; i++)
            {
                {
                    v3[i] = Convert.ToInt32(v1[i] * m);
                }
            }
            return v3;
        }

        static public double GetNorm(IVector v1)
        {
            double norm = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                norm += Math.Pow(v1[i], 2);
            }
            norm = Math.Sqrt(norm);
            return norm;
        }
    }
}
