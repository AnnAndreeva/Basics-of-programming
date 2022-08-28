using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР06
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

        static public void InputVector(IVector v, FileStream Bf) {
            Bf.Seek(0, SeekOrigin.End);
            byte[] vec = new byte[v.Length + 1];
            vec[0] = (byte)v.Length;
            for (int i = 1; i < vec.Length; ++i)
            {
                vec[i] = (byte)v[i-1];
            }
            Bf.Write(vec, 0, vec.Length);
        }

        static public IVector OutputVector(FileStream Bf)
        {
            int b = Bf.ReadByte();
            IVector v = new ArrayVector(b);
            byte[] y = new byte[b];
            Bf.Read(y, 0, y.Length);
            for (int i = 0; i < b; i++)
            {
                v[i] = y[i];
            }
            return v;
        }

        static public void WriteVector(IVector v, TextWriter Tw) {
            Tw.WriteLine(v.ToString());
        }
    

    static public IVector ReadVector(TextReader Tr)
        {
            string s = Tr.ReadLine();
            s = s.Replace("Число координат вектора: ", "");
            s = s.Replace(", координаты вектора через пробел:", " ");
            string[] words = s.Split(' ');
            IVector v = new ArrayVector(Convert.ToInt32(words[0]));
            for (int i = 0; i < v.Length; i++) {
                v[i] = Convert.ToDouble(words[i+1]);
            }
            return v;
        }
    }
}
