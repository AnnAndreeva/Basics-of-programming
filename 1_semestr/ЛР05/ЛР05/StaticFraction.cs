using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР05
{
    class StaticFraction
    {
        
        public  StaticFraction()
        {
        }
        //Статический метод сложения дробей
        static public Fraction SummaSt(Fraction f1, Fraction f2)
        {
            if (f1.Y == f2.Y)
            {
                return new Fraction(f1.X + f2.X, f1.Y);
            }
            else
            {
                return new Fraction(f1.X * f2.Y + f2.X * f1.Y, f1.Y * f2.Y);
            }
        }
        //Статический метод вычитания дробей
        static public Fraction DifSt(Fraction f1, Fraction f2)
        {
            if (f1.Y == f2.Y)
            {
                return new Fraction(f1.X - f2.X, f1.Y);
            }
            else
            {
                return new Fraction(f1.X * f2.Y - f2.X * f1.Y, f1.Y * f2.Y);
            }
        }
        //Статический метод умножения дробей
        static public Fraction MultiSt(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.X * f2.X, f1.Y * f2.Y);

        }

        //Статический метод деления дробей
        static public Fraction DivSt(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.X * f2.Y, f1.Y * f2.X);
        }

        // Метод cокращения дробей
        public static Fraction Reduction(Fraction f)
        {
            int n = NOD(f.X, f.Y);
            if (n != 0)
            {
                return new Fraction(f.X / n, f.Y / n);
            }
            else
            {
                return new Fraction(0, 0);
            }
        }
        // НОД
        public static int NOD(int x, int y)
        {
            while ((x != 0) && (y != 0))
            {
                if (x > y)
                {
                    x = x % y;
                }
                else
                {
                    y = y % x;
                }
            }

            if (x + y != 0)
            {
                return x + y;
            }
            else
            {
                return 0;
            }
        }

        public static void OutputFr(Fraction f)
        {
            Console.WriteLine(f.X);
            Console.WriteLine("—");
            Console.WriteLine(f.Y);
        }
    }
}
