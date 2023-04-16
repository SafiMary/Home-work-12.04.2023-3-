using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_work_12._04._2023__3_
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine("Нажмите ENTER  чтобы начать забег по кругу, для выхода нажмите ПРОБЕЛ");
            do
            {
                 key = Console.ReadKey();
                switch (key.Key)
                {
                    case ConsoleKey.Enter:
                        {
                            DateTime startTime = DateTime.Now;
                            Console.WriteLine(startTime.ToString("yyyy.MM.dd HH:mm:ss.ffffff"));
                            Console.WriteLine("Начало забега по кругу");
                            Console.ReadKey();
                            DateTime stopTime = DateTime.Now;
                            TimeSpan timeSpan = stopTime - startTime;
                            Console.WriteLine($"\nКруг пробежал за {timeSpan.ToString("ss")} секунд");
                            Console.ReadKey();
                            break;
                        }
                   
                }
            } while (key.Key != ConsoleKey.Spacebar);

        }
    }
}
