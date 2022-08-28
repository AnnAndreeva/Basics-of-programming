using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР06
{
    class MyArray
    {
        public int n, m;
        public MyArray()
        { }
        public MyArray(int n, int m)
        {
            this.n = n;
            this.m = m;
        }
        public int[,] InputMatr(int n, int m)
        {
            int[,] matr = new int[m, n];
            Random rand = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matr[i, j] = rand.Next(-100, 100);
                }
            }
            return matr;
        }
        public int[,] OutputMatr(int n, int m, int[,] matr, int k)
        {
            Console.WriteLine();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.SetCursorPosition( 5 * j, i + 5 + k); ;
                    Console.Write(matr[i, j]);
                }
            }
            return matr;
        }

        static int[] SumMas(int[,] matr, int m, int n)
        {
            int s = 0;
            int[] b = new int[n];
            for (int j = 0; j < n; j++)
            {
                s = 0;
                for (int i = 0; i < m; i++)
                {
                    s += matr[i, j];
                }
                b[j] = s;
            }
            return b;
        }


        public int[,] SortMatrUP(int n, int m, int[,] matr)
        {
            int[] b = new int[n];
            b = SumMas(matr, m, n);
            int i = 1, j = 2, v;
            while (i < n )
            {
                if (b[i - 1] <= b[i])
                {
                    i = j;
                    j++;
                }
                else
                {
                    v = b[i - 1];
                    b[i - 1] = b[i];
                    b[i] = v;
                    for (int k = 0; k < m; k++)
                    {
                        v = matr[k, i  - 1];
                        matr[k, i - 1] = matr[k, i];
                        matr[k, i] = v;
                    }
                    i--;
                    if (i == 0)
                    {
                        i = j;
                        j++;
                    }
                }
            }
            return matr;
        }

        public int[,] SortMatrDown(int n, int m, int[,] matr)
        {
            int[] b = new int[n];
            b = SumMas(matr, m, n);
            int i = 1, j = 2, v;
            while (i < n)
            {
                if (b[i - 1] >= b[i])
                {
                    i = j;
                    j++;
                }
                else
                {
                    v = b[i - 1];
                    b[i - 1] = b[i];
                    b[i] = v;
                    for (int k = 0; k < m; k++)
                    {
                        v = matr[k, i - 1];
                        matr[k, i - 1] = matr[k, i];
                        matr[k, i] = v;
                    }
                    i--;
                    if (i == 0)
                    {
                        i = j;
                        j++;
                    }
                }
            }

            return matr;

        }
    }


}




