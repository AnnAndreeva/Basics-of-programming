using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР04
{
    class Matrix
    {
        public int n, m;
        public Matrix()
        { }
        public Matrix(int n, int m)
        {
            this.n = n;
            this.m = m;
        }    
        public double[,] InputMatr(int n, int m, int r, int p)
        {

            double[,] matr = new double[n, m];
            Console.SetCursorPosition(r, p + 1);
            Console.WriteLine("Введите матрицу:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.SetCursorPosition(4 * j + r ,  i + p + 2);
                    matr[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            return matr;
        }
        public double[,] OutputMatr(int n, int m, int p, double[,] matr)
        {
            Console.WriteLine();
            Console.SetCursorPosition(0, p + 11  + n);
            Console.WriteLine("Результат:");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.SetCursorPosition(4 * j, p + 12 + i + n); ;
                    Console.Write(matr[i, j]);
                }
            }
            return matr;
        }
        public void SumMatr(int n, int m, int p, double[,] matr1, double[,] matr2)
        {
            double[,] sum = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum[i, j] = matr1[i, j] + matr2[i, j];
                }
            }
            OutputMatr(n, m, p,  sum);
        }
        public void DifMatr(int n, int m, int p, double[,] matr1, double[,] matr2)
        {
            double[,] dif = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dif[i, j] = matr1[i, j] - matr2[i, j];
                }
            }
            OutputMatr(n, m, p, dif);
        }
        public void MultiMatr(int n, int m, int p, double[,] matr1, double[,] matr2)
        {
            double[,] multi = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    multi[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        multi[i, j] = multi[i, j] + matr1[i, k] * matr2[k, j];
                    }
                }
            }
            OutputMatr(n, m, p, multi);
        }
        public void MultiRMatr(int n1, int m1, int m2, int p, double[,] matr1, double[,] matr2)
        {
            double[,] multi = new double[n1, m2];
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < m2; j++)
                {
                    multi[i, j] = 0;
                    for (int k = 0; k < m1; k++)
                    {
                        multi[i, j] = multi[i, j] + matr1[i, k] * matr2[k, j];
                    }
                }
            }
            OutputMatr(n1, m2, p, multi);
        }

        public double DetMatr(int n, double[,] matr1)
        {
            int r, j;
            double c, M, max, det = 1;
            //Прямой ход метода Гаусса.
            for (int k = 0; k < n; k++)
            {
                max = Math.Abs(matr1[k, k]);
                r = k;
                for (int i = k + 1; i < n; i++)
                    if (Math.Abs(matr1[i, k]) > max)
                    {
                        max = Math.Abs(matr1[i, k]);
                        r = i;
                    }
                //Если строки менялись местами, то смена знака определителя.
                if (r != k) det = -1 * det;
                for (j = 0; j < n; j++)
                {
                    c = matr1[k, j];
                    matr1[k, j] = matr1[r, j];
                    matr1[r, j] = c;
                }
                for (int i = k + 1; i < n; i++)
                {
                    for (M = matr1[i, k] / matr1[k, k], j = k; j < n; j++)
                        matr1[i, j] -= M * matr1[k, j];
                }
            }
            //Вычисление определителя.
            for (int i = 0; i < n; i++)
            {
                det *= matr1[i, i];
            }
            return det;
        }
    }
}
