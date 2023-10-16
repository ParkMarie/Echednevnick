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
        static void Main()
        {
            int a = 1;
            Zametki();
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                Console.SetCursorPosition(0, a);
                Console.WriteLine("  ");

                if (key.Key == ConsoleKey.UpArrow)
                {
                    a = a - 1;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    a = a + 1;
                }
                Console.SetCursorPosition(0, a);
                Console.WriteLine("->");
                key = Console.ReadKey();

            }

            Console.SetCursorPosition(0, 7);
            if (a == 2)
            {
                DateTime data1 = new DateTime(2023, 10, 13);
                Console.WriteLine("  " + data1);
                Console.WriteLine(" Протереть пыль, помыть полы");
            }
            else if (a == 3)
            {
                DateTime data1 = new DateTime(2023, 10, 13);
                Console.WriteLine("  " + data1);
                Console.WriteLine("В меню у нас сегодня онигири :0");
            }
            else if (a == 4)
            {
                DateTime data1 = new DateTime(2023, 10, 13);
                Console.WriteLine("  " + data1);
                Console.WriteLine("Ну...так надо.");
            }
            else if (a == 5)
            {
                DateTime data1 = new DateTime(2023, 10, 13);
                Console.WriteLine("  " + data1);
                Console.WriteLine("Ура! Победа!");
            }
            else if (a == 6)
            {
                DateTime data1 = new DateTime(2023, 10, 13);
                Console.WriteLine("  " + data1);
                Console.WriteLine("Где там мой гусь-обнимусь -_-?");
            }
            
        }
        
       public static void Zametki()
        {
            DateTime data1 = new DateTime(2023, 10, 13);
            Console.WriteLine("  " + data1);
            Console.WriteLine("  Добро пожаловать в ваш ежедневник :3");
            Console.WriteLine("  1.Убраться дома.");
            Console.WriteLine("  2.Приготовить покушать.");
            Console.WriteLine("  3.Сделать практос");
            Console.WriteLine("  4.Пойти поиграть.");
            Console.WriteLine("  5.Лечь поспать");

            
        }
        

       
    }
}
