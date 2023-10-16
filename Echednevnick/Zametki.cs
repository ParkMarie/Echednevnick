using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echednevnick
{
    internal class Program
    {
        static DateTime data1 = DateTime.Now;

        static void Main(string[] args)
        {
            int min = 2;
            int max = 6;
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
                        Console.SetCursorPosition(2, 0);
                        Console.WriteLine(data1);
                    }
                    else if (key.Key == ConsoleKey.LeftArrow)
                    {
                        data1 = data1.AddDays(-1);
                        Console.SetCursorPosition(2, 0);
                        Console.WriteLine(data1);
                    }
                    Console.SetCursorPosition(0, a);
                    Console.WriteLine("->");
                    key = Console.ReadKey();


                }


                Console.SetCursorPosition(0, 8);
                Console.Clear();
                Console.WriteLine("Дедлайн, ю ноу: " + data1);
                if (a == 2)
                {
                    Console.WriteLine("Что тут написано вообще ^.^?");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Название: Уборка.");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Описание: Протереть пыль, помыть полы");
                    Console.WriteLine("-----------------------------");
                }
                else if (a == 3)
                {
                    Console.WriteLine("Что тут написано вообще ^.^?");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Название: Кушать - это важно ;3");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Описание: В меню у нас сегодня онигири :0");
                    Console.WriteLine("-----------------------------");
                }
                else if (a == 4)
                {

                    Console.WriteLine("Что тут написано вообще ^.^?");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Название: Практос.");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Описание: Окееееей, летс гооооооууууу");
                    Console.WriteLine("-----------------------------");
                }
                else if (a == 5)
                {

                    Console.WriteLine("Что тут написано вообще ^.^?");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Название: Игрульки.");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Описание: Ура! Победа!");
                    Console.WriteLine("-----------------------------");
                }
                else if (a == 6)
                {

                    Console.WriteLine("Что тут написано вообще ^.^?");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Поработали, можно и отдохнуть.");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Где там мой гусь-обнимусь -_-?");
                    Console.WriteLine("-----------------------------");
                }
                Console.ReadKey();
                Console.Clear();


            }

        }

        static void Zametki()
        {
            Console.WriteLine("  " + data1);
            Console.WriteLine("  Добро пожаловать в ваш ежедневник :3");
            Console.WriteLine("  1.Убраться дома.");
            Console.WriteLine("  2.Приготовить покушать.");
            Console.WriteLine("  3.Сделать практос.");
            Console.WriteLine("  4.Пойти поиграть.");
            Console.WriteLine("  5.Лечь поспать.");

        }

    }
}