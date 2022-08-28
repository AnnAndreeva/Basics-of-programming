using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР06
{
    class StepArray
    {
        public int N ;
        public int n, m;
        public StepArray()
        { }
        public StepArray(int N)
        {
            this.N = N;
        }


        public int[][] InputStepArr(int N)
        {
            int[][] sArr = new int[N][];
            for (int i = 0; i < N; i++) {
                int n, k = i;
                Console.Write("Введите размер {0}-го массива: ", k++);
                n = Convert.ToInt32(Console.ReadLine());
                sArr[i] = new int[n];
                Console.WriteLine("Введите {0}-й массив:", k--);
                for (int j = 0; j < n; j++)
                {
                    Console.SetCursorPosition(j * 3, 12 + k + 2 * i);
                    sArr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return sArr;
        }

        public int[][] OutputStepArr( int[][] sArr)
        {

            for (int i = 0; i < sArr.Length; i++)
            {
                int  k = i;
                Console.WriteLine("{0}-й массив:", k++ );
                k--;
                for (int j = 0; j < sArr[i].Length; j++)
                {
                    Console.SetCursorPosition(j * 3, 19 + 2 * i);
                    Console.WriteLine(sArr[i][j]);
                }

            }
            return sArr;
        }

        static int[] StepArrToArr( int[][] sArr)
        {
            int s = 0;
            for (int k = 0; k < sArr.Length; k++)
            {
                s += sArr[k].Length;
            }
            int[] b = new int[s];
            Sort sort = new Sort();
            int m = 0;
            for (int i = 0; i < sArr.Length; i++)
            {
                for (int j = 0; j < sArr[i].Length; j++)
                {
                    b[m] += sArr[i][j];
                    m++;
                }
            }
            b = sort.ShakerSort(b);
            return b;
        }
        public int[][] ArrToStepArr( int[][] sArr)
        {
            int s = 0;
            for (int k = 0; k < sArr.Length; k++)
            {
                s += sArr[k].Length;
            }
            int[] b = new int[s];
            b = StepArrToArr(sArr);
            for (int i = 0; i < sArr.Length; i++)
            {
                for (int j = 0; j < sArr[i].Length; j++)
                {
                    sArr[i][j] = b[m]  ;
                    m++;
                }
            }
            return sArr;
        }

    }
}
