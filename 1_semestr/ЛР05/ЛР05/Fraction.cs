using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР05
{
    class Fraction
    {
        int x, y;
        public Fraction()
        {
        }
        public Fraction(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }        public int X
        {
            get { return x; }
            set { x = value; }
        }
        // - Свойство доступа к y
        public int Y
        {
            get { return y; }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Один из знаменателей равен 0. Его значение изменено на 1. ");
                    y = 1;
                }
                else
                {
                    y = value;
                }
            }
        }

        // Метод сложения дробей
        public void Summa(Fraction f)
        {
            if (y == f.y)
            {
                x = x + f.x;
            }
            else
            {

                x = x * f.y + x * y;
                y = y * f.y;
            }


        }
        // Метод сложения дробей
        public Fraction SummaS(Fraction f)
        {
            Fraction f0 = new Fraction();
            if (f0.y == f.y)
            {
                f0.x = x + f.x;
            }
            else
            {
                f0.x = x * f.y + f.x * y;
                f0.y = y * f.y;
            }
            return f0;
        }
        //Статический метод сложения дробей
        static public Fraction SummaSt(Fraction f1, Fraction f2)
        {
            if (f1.y == f2.y)
            {
                return new Fraction(f1.x + f2.x, f1.y);
            }
            else
            {
                return new Fraction(f1.x * f2.y + f2.x * f1.y, f1.y * f2.y);
            }
        }
        // Метод вычитания дробей
        public void Dif(Fraction f)
        {
            if (y == f.y)
            {
                x = x - f.x;
            }
            else
            {
                x = x * f.y - f.x * y;
                y = y * f.y;
            }

        }
        // Метод вычитания дробей
        public Fraction DifS(Fraction f)
        {
            Fraction f0 = new Fraction();
            if (f0.y == f.y)
            {
                f0.x = x + f.x;
            }
            else
            {
                f0.x = x * f.y - f.x * y;
                f0.y = y * f.y;
            }
            return f0;
        }
        //Статический метод вычитания дробей
        static public Fraction DifSt(Fraction f1, Fraction f2)
        {
            if (f1.y == f2.y)
            {
                return new Fraction(f1.x - f2.x, f1.y);
            }
            else
            {
                return new Fraction(f1.x * f2.y - f2.x * f1.y, f1.y * f2.y);
            }
        }
        // Метод умножения дробей
        public void Multi(Fraction f)
        {
            x = x * f.x;
            y = y * f.y;
        }
        // Метод умножения дробей
        public Fraction MultiS(Fraction f)
        {
            Fraction f0 = new Fraction();
            f0.x = x * f.x;
            f0.y = y * f.y;
            return f0;
        }
        //Статический метод умножения дробей
        static public Fraction MultiSt(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.x * f2.x, f1.y * f2.y);

        }
        // Метод деления дробей
        public void Div(Fraction f)
        {
            x = x * f.y;
            y = y * f.x;
        }
        // Метод деления дробей
        public Fraction DivS(Fraction f)
        {
            Fraction f0 = new Fraction();

            f0.x = x * f.y;
            f0.y = y * f.x;
            return f0;
        }
        //Статический метод деления дробей
        static public Fraction DivSt(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.x * f2.y, f1.y * f2.x);
        }
        // Переопределение операции  сложения
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            if (f1.y == f2.y)
            {
                return new Fraction(f1.x + f2.x, f1.y);
            }
            else
            {
                return new Fraction(f1.x * f2.y + f2.x * f1.y, f1.y * f2.y);
            }
        }
        // Переопределение операции вычитания
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            if (f1.y == f2.y)
            {
                return new Fraction(f1.x - f2.x, f1.y);
            }
            else
            {
                return new Fraction(f1.x * f2.y - f2.x * f1.y, f1.y * f2.y);
                
            }
        }
        // Переопределение операции умножения
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.x * f2.x, f1.y * f2.y);
        }        // Переопределение операции деления
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.x * f2.y, f1.y * f2.x);
        }

        // Метод cокращения дробей
        public static Fraction Reduction(Fraction f)
        {
            int n = NOD(f.x, f.y);
            if (n != 0)
            {
                return new Fraction(f.x / n, f.y / n);
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
            Console.WriteLine(f.x);
            Console.WriteLine("—");
            Console.WriteLine(f.y);
        }
    }
}
