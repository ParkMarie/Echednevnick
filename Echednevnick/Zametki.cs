using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Zametki
{
    internal class Program
    {


        static DateTime data1 = new DateTime(2023, 10, 16);

        static void Main(string[] args)
        {
            int min = 1;
            int max = 2;
            int a = 1;
            while (true)
            {

                Zametki();

                ConsoleKeyInfo key = Console.ReadKey();
                while (key.Key != ConsoleKey.Enter)
                {
                    Console.SetCursorPosition(0, a);
                    Console.WriteLine("  ");

                    if (key.Key == ConsoleKey.UpArrow && a != min)
                    {
                        a = a - 1;
                    }
                    else if (key.Key == ConsoleKey.DownArrow && a != max)
                    {
                        a = a + 1;
                    }
                    else if (key.Key == ConsoleKey.RightArrow)
                    {
                        data1 = data1.AddDays(1);
                        Console.Clear();
                        Zametki();

                    }
                    else if (key.Key == ConsoleKey.LeftArrow)
                    {
                        data1 = data1.AddDays(-1);
                        Console.Clear();
                        Zametki();
                    }
                    Console.SetCursorPosition(0, a);
                    Console.WriteLine("->");
                    key = Console.ReadKey();


                }


                Console.SetCursorPosition(0, 8);
                Console.Clear();
                Console.WriteLine(data1);
                if (a == 1 && data1.Date == new DateTime(2023, 10, 17))
                {
                    Console.WriteLine("Что тут написано вообще ^.^?");
                    Console.WriteLine("Дедлайн, ю ноу: " + data1);
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Название: Уборка.");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Описание: Протереть пыль, помыть полы");
                    Console.WriteLine("-----------------------------");
                }

                else if (a == 2 && data1.Date == new DateTime(2023, 10, 17))
                {
                    Console.WriteLine("Что тут написано вообще ^.^?");
                    Console.WriteLine("Дедлайн, ю ноу: " + data1);
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Название: Кушать - это важно ;3");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Описание: В меню у нас сегодня онигири :0");
                    Console.WriteLine("-----------------------------");

                    
}
                else if (a == 1 && data1.Date == new DateTime(2023, 10, 18))
                {
                    Console.WriteLine("Что тут написано вообще ^.^?");
                    Console.WriteLine("Дедлайн, ю ноу: " + data1);
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Название: Практос.");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Описание: Окееееей, летс гооооооууууу");
                    Console.WriteLine("-----------------------------");
                }
                else if (a == 2 && data1.Date == new DateTime(2023, 10, 18))
                {
                    Console.WriteLine("Что тут написано вообще ^.^?");
                    Console.WriteLine("Дедлайн, ю ноу: " + data1);
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Название: Игрульки.");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Описание: Ура! Победа!");
                    Console.WriteLine("-----------------------------");
                }
                else if (a == 1 && data1.Date == new DateTime(2023, 10, 20))
                {
                    Console.WriteLine("Что тут написано вообще ^.^?");
                    Console.WriteLine("Дедлайн, ю ноу: " + data1);
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Название: Буль-буль.");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Описание: Только без потопа.");
                    Console.WriteLine("-----------------------------");
                }
                else if (a == 2 && data1.Date == new DateTime(2023, 10, 20))
                {
                    Console.WriteLine("Что тут написано вообще ^.^?");
                    Console.WriteLine("Дедлайн, ю ноу: " + data1);
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Название: Поработали можно и поспать.");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Описание: Где там мой гусь-обнимусь -_-?");
                    Console.WriteLine("-----------------------------");

                }
                Console.ReadKey();
                Console.Clear();


            }

        }

        static void Zametki()
        {
            Console.WriteLine("  " + data1);
            if (data1.Date == new DateTime(2023, 10, 17))
            {
                Console.WriteLine("  1.Убраться дома.");
                Console.WriteLine("  2.Приготовить покушать.");
            }
            else if (data1.Date == new DateTime(2023, 10, 18))
            {
                Console.WriteLine("  1.Сделать практос.");
                Console.WriteLine("  2.Пойти поиграть.");
            }
            else if (data1.Date == new DateTime(2023, 10, 20))
            {
                Console.WriteLine("  1.Принять пенную ванну.");
                Console.WriteLine("  2.Лечь поспать.");
            }

        }






    }



}