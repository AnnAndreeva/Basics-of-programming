using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР06_extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дополнительное задание к лабораторной работе № 6");
            Console.WriteLine("Сортировка групп 6 факультета по среднему баллу");
            GroupsArray groupsArray = new GroupsArray();
            Student[][] Groups = groupsArray.InputGroupsArr();
            bool key = false;
            while (key == false)
            {
                Console.WriteLine("1 - сортировка внутри группы по возрастанию");
                Console.WriteLine("2 - сортировка внутри группы по убыванию");
                Console.WriteLine("3 - сортировка всех групп по возрастанию");
                Console.WriteLine("4 - сортировка всех групп по убыванию\n");
                Console.Write("Выбор - ");
                string menu1 = Console.ReadLine();
                Console.WriteLine();
                switch (menu1)
                {
                    case "1":
                        {
                            
                            Groups = groupsArray.SortGroupUp(Groups);
                            groupsArray.OutputGroups(Groups);
                            
                            Console.WriteLine();
                            Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                            Console.ReadLine();
                            
                            break;
                        }
                    case "2":
                        {

                            Groups = groupsArray.SortGroupDown(Groups);
                            groupsArray.OutputGroups(Groups);

                            Console.WriteLine();
                            Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                            Console.ReadLine();
                            
                            break;
                        }
                    case "3":
                        {

                            Groups = groupsArray.SortGroupsUp(Groups);
                            groupsArray.OutputGroups(Groups);
                            Console.WriteLine();
                            Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                            Console.ReadLine();
                            
                            break;
                        }
                    case "4":
                        {

                            Groups = groupsArray.SortGroupsDown(Groups);
                            groupsArray.OutputGroups(Groups);
                            Console.WriteLine();
                            Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                            Console.ReadLine();
                            
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Введено значение, не соответствующее ни одному пункту меню.");
                            Console.WriteLine("Для возвращения в главное меню нажмите Enter");
                            Console.ReadLine();
                            
                            break;
                        }
                }
            }

        }
       
    }
}
