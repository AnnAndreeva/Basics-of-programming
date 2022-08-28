using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР04
{
    class Binary
    {
        public int a;
        public Binary()
        { }
        public Binary(int a)
        {
            this.a = a;
        }

        public int ToBinary(int a)
        {
            int c, b = 0;
            for (int i = 0; a > 0; i++)
            {
                c = a % 2;
                b += Convert.ToInt32(Math.Pow(10, i)) * c;
                a = a / 2;
            }
            return b;
        }

        public int Triads(int a)
        {
            int a1 = a;
            string str = Convert.ToString(a1);
            while ((str.Length < 9) || (str.Length % 3 != 0))  //догоняем триады
            {
                str = "0" + str;
            }

            char[] s = str.ToCharArray();
            for (int i = 0; i != 3; i++) //меняем триады
            {
                char v;
                v = s[i];
                s[i] = s[i + 6];
                s[i + 6] = v;
            }

            string newstr = "";
            int l = 0;
            while (s[l] == '0') //убираем незначащие 0
            {
                l++;
            }

            for (; l < str.Length; l++)
            {

                newstr += Convert.ToString(s[l]);
            }
            return Convert.ToInt32(newstr);
        }

        public int ToDecimal(int a)
        {
            int a1 = a, d, b = 0;
            for (int i = 0; a1 > 0; i++)
            {
                d = a1 % 10;
                if (d == 1)
                {
                    b = b + d * Convert.ToInt32(Math.Pow(2, i));
                }
                a1 /= 10;
            }
            return b;
        }
    }
}
