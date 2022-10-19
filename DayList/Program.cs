using System;
using System.Linq;

namespace DayList
{
    public class Program
    {
        public static int kursor = 1;
        public static int MoveDay = 0;
        public static DateTime time = DateTime.Now;


        static void Main()
        {
            Console.WriteLine("Это ежедневник , Для выхода нажми ESC Зайка \n\r\n__**_**\r\n_**___**\r\n_**___**_________****\r\n_**___**_______**___****\r\n_**__**_______*___**___**\r\n__**__*______*__**__***__**\r\n___**__*____*__**_____**__*\r\n____**_**__**_**________**\r\n____**___**__**\r\n___*___________*\r\n__*_____________*\r\n_*____0_____0____*\r\n_*_______@_______*\r\n_*_______________*\r\n___*_____v_____*\r\n_____**_____**\r\n");
            MyTask gun = new MyTask();
            gun.Day = 19;
            gun.Month = 10;
            gun.Name = "Сделать с#";
            gun.Description = "понял что ничего не понял ";
            MyTask.MyTasks.Add(gun);
            MyTask pop = new MyTask()
            {
                Day = 18,
                Month = 10,
                Name = "пойти в магаз ",
                Description = "купил поесть и Купить Энергос Софье Алексеевне)   ",
            };
            MyTask.MyTasks.Add(pop);
            MyTask r = new MyTask()
            {
                Day = 20,
                Month = 10,
                Name = "пойти на пары ",
                Description = " не хочууууу....",
            };
            MyTask.MyTasks.Add(r);
            MyTask camel = new MyTask()
            {
                Day = 17,
                Month = 10,
                Name = "сходить в туалет ",
                Description = "капец там херасима нагасаки ",

            };
            MyTask.MyTasks.Add(camel);
            MyTask WTF = new MyTask()
            {
                Day = 21,
                Month = 10,
                Name = "Посмотреть Брат ",
                Description = "Большие города , пустые поезда .....",
            };
             MyTask.MyTasks.Add(WTF);
            while (true)
            {
                Smotri();
                ConsoleKeyInfo key = Console.ReadKey();
                Knopki(key);
            }


        }

        private static void Smotri()
        {
            Console.SetCursorPosition(0, 1);
            Console.WriteLine($"Выбрана дата: {time.AddDays(MoveDay).Day}.{time.Month}.{time.Year}");
            Console.SetCursorPosition(3, 2);
            int n = 0;
            foreach (var item in MyTask.MyTasks)
            {
                if (item.Day == time.AddDays(MoveDay).Day)
                {
                    Console.WriteLine($"{n+1}. {item.Name}");

                }
            }
            Console.SetCursorPosition(0, kursor);
        }
        static void Knopki(ConsoleKeyInfo Key)
        {
            switch (Key.Key)
            {
                case ConsoleKey.LeftArrow:
                    MoveDay = MoveDay - 1;
                    break;
                case ConsoleKey.RightArrow:
                    MoveDay = MoveDay + 1;
                    break;
                case ConsoleKey.UpArrow:
                    if (kursor < 2)
                    {
                        kursor= 2;
                    }
                    else
                    {
                    kursor = kursor - 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (kursor > MyTask.MyTasks.Where(i => i.Day == MoveDay).ToList().Count+1)
                    {
                    }
                    else
                    {
                        kursor = kursor + 1;
                    }
                    break;
                case ConsoleKey.Enter:
                    Console.Clear();
                    Console.SetCursorPosition(2, 2);
                    Fully();
                    break;
                case ConsoleKey.Escape:
                    System.Environment.Exit(0);
                    break;

            }

            Kursorchik();

        }

        private static void Fully()
        {
            int n = 0;
            foreach (var item in MyTask.MyTasks)
            {
                if (item.Day == time.AddDays(MoveDay).Day)
                {
                    Console.WriteLine($"{item.Name}\n    Поддробности: {item.Description}");

                }
            }
            Console.ReadKey();
        }

        private static void Kursorchik()
        {
            Console.Clear();
            Console.SetCursorPosition(0, kursor);
            Console.Write("=>");
        }
    }
}
