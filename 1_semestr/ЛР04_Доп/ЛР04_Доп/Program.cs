using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР04_Доп
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;
            Console.WriteLine("Календарь 2015\n");
            Console.WriteLine("Январь = 1,\nФевраль = 2,\nМарт = 3,\nАпрель = 4,");
            Console.WriteLine("Май = 5,\nИюнь = 6,\nИюль = 7,\nАвгуст = 8,");
            Console.WriteLine("Сентябрь = 9,\nОктябрь = 10,\nНоябрь = 11,\nДекабрь = 12\n");            
            Console.Write("Введите номер месяца: ");
            month = Convert.ToInt32(Console.ReadLine());
            
            Calendar calendar = new Calendar();
            calendar.Output(month);
            Console.ReadLine();
        }
    }
}
