using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР04_Доп
{
    class Calendar
    {
        int month, day;
        public Calendar() { }
        public Calendar(int month, int day)
        {
            this.month = month;
            this.day = day;
        }

        public void Output(int month)
        {
            switch (Convert.ToString(month)) {
                case "1": {
                        Console.SetCursorPosition(0, 16);
                        Console.WriteLine("Пн     5   12  19  26");
                        Console.WriteLine("Вт     6   13  20  27");
                        Console.WriteLine("Ср     7   14  21  28");
                        Console.WriteLine("Чт  1  8   15  22  29");
                        Console.WriteLine("Пт  2  9   16  23  30");
                        Console.WriteLine("Сб  3  10  17  24  31");
                        Console.WriteLine("Вс  4  11  18  25    ");
                        break;
                    }
                case "2":
                    {
                        Console.SetCursorPosition(0, 16);
                        Console.WriteLine("Пн     2   9   16  23");
                        Console.WriteLine("Вт     3   10  17  24");
                        Console.WriteLine("Ср     4   11  18  25");
                        Console.WriteLine("Чт     5   12  19  26");
                        Console.WriteLine("Пт     6   13  20  27");
                        Console.WriteLine("Сб     7   14  21  28");
                        Console.WriteLine("Вс  1  8   15  22    ");
                        break;
                    }
                case "3":
                    {
                        Console.SetCursorPosition(0, 16);
                        Console.WriteLine("Пн     2   9   16  23  30");
                        Console.WriteLine("Вт     3   10  17  24  31");
                        Console.WriteLine("Ср     4   11  18  25  ");
                        Console.WriteLine("Чт     5   12  19  26  ");
                        Console.WriteLine("Пт     6   13  20  27  ");
                        Console.WriteLine("Сб     7   14  21  28  ");
                        Console.WriteLine("Вс  1  8   15  22  29  ");
                        break;
                    }
                case "4":
                    {
                        Console.SetCursorPosition(0, 16);
                        Console.WriteLine("Пн     6   13  20  27");
                        Console.WriteLine("Вт     7   14  21  28");
                        Console.WriteLine("Ср  1  8   15  22  29");
                        Console.WriteLine("Чт  2  9   16  23  30");
                        Console.WriteLine("Пт  3  10  17  24  ");
                        Console.WriteLine("Сб  4  11  18  25  ");
                        Console.WriteLine("Вс  5  12  19  26  ");
                        break;
                    }
                case "5":
                    {
                        Console.SetCursorPosition(0, 16);
                        Console.WriteLine("Пн     4   11  18  25");
                        Console.WriteLine("Вт     5   12  19  26");
                        Console.WriteLine("Ср     6   13  20  27");
                        Console.WriteLine("Чт     7   14  21  28");
                        Console.WriteLine("Пт  1  8   15  22  29");
                        Console.WriteLine("Сб  2  9   16  23  30");
                        Console.WriteLine("Вс  3  10  17  24  31");
                        break;
                    }
                case "6":
                    {
                        Console.SetCursorPosition(0, 16);
                        Console.WriteLine("Пн  1  8   15  22  29");
                        Console.WriteLine("Вт  2  9   16  23  30");
                        Console.WriteLine("Ср  3  10  17  24  ");
                        Console.WriteLine("Чт  4  11  18  25  ");
                        Console.WriteLine("Пт  5  12  19  26  ");
                        Console.WriteLine("Сб  6  13  20  27  ");
                        Console.WriteLine("Вс  7  14  21  28  ");
                        break;
                    }
                    case "7":
                    {
                        Console.SetCursorPosition(0, 16);
                        Console.WriteLine("Пн     6   13  20  27");
                        Console.WriteLine("Вт     7   14  21  28");
                        Console.WriteLine("Ср  1  8   15  22  29");
                        Console.WriteLine("Чт  2  9   16  23  31");
                        Console.WriteLine("Пт  3  10  17  24  ");
                        Console.WriteLine("Сб  4  11  18  25  ");
                        Console.WriteLine("Вс  5  12  19  26  ");
                        break;
                    }

                case "8":
                    {
                        Console.SetCursorPosition(0, 16);
                        Console.WriteLine("Пн     3   10  17  24  31");
                        Console.WriteLine("Вт     4   11  18  25");
                        Console.WriteLine("Ср     5   12  19  26");
                        Console.WriteLine("Чт     6   13  20  27");
                        Console.WriteLine("Пт     7   14  21  28");
                        Console.WriteLine("Сб  1  8   15  22  29");
                        Console.WriteLine("Вс  2  9   16  23  30");
                        break;
                    }
                case "9":
                    {
                        Console.SetCursorPosition(0, 16);
                        Console.WriteLine("Пн     7   14  21  28");
                        Console.WriteLine("Вт 1   8   15  22  29");
                        Console.WriteLine("Ср 2   9   16  23  30");
                        Console.WriteLine("Чт 3   10  17  24  ");
                        Console.WriteLine("Пт 4   11  18  25  ");
                        Console.WriteLine("Сб 5   12  19  26  ");
                        Console.WriteLine("Вс 6   13  20  27  ");
                        break;
                    }
                case "10":
                    {
                        Console.SetCursorPosition(0, 16);
                        Console.WriteLine("Пн     5   12  19  26");
                        Console.WriteLine("Вт     6   13  20  27");
                        Console.WriteLine("Ср     7   14  21  28");
                        Console.WriteLine("Чт  1  8   15  22  29");
                        Console.WriteLine("Пт  2  9   16  23  30");
                        Console.WriteLine("Сб  3  10  17  24  31");
                        Console.WriteLine("Вс  4  11  18  25    ");
                        break;
                    }
                case "11":
                    {
                        Console.SetCursorPosition(0, 16);
                        Console.WriteLine("Пн     2   9   16  23  30");
                        Console.WriteLine("Вт     3   10  17  24  ");
                        Console.WriteLine("Ср     4   11  18  25  ");
                        Console.WriteLine("Чт     5   12  19  26  ");
                        Console.WriteLine("Пт     6   13  20  27  ");
                        Console.WriteLine("Сб     7   14  21  28  ");
                        Console.WriteLine("Вс  1  8   15  22  29  ");
                        break;
                    }
                case "12":
                    {
                        Console.SetCursorPosition(0, 16);
                        Console.WriteLine("Пн     7   14  21  28");
                        Console.WriteLine("Вт 1   8   15  22  29");
                        Console.WriteLine("Ср 2   9   16  23  30");
                        Console.WriteLine("Чт 3   10  17  24  31");
                        Console.WriteLine("Пт 4   11  18  25  ");
                        Console.WriteLine("Сб 5   12  19  26  ");
                        Console.WriteLine("Вс 6   13  20  27  ");
                        break;
                    }


            }
           
        }
    }
}


