using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет! Игра: \"Угадай число\"");
            Random rnd = new Random();
            int iiNumber = rnd.Next(1, 101);
            int count = 0;
            int userNumber;

            do
            {
                Console.WriteLine("Введите число:\n");
                count++;
                userNumber = int.Parse(Console.ReadLine());
                if (userNumber < iiNumber)
                {
                    Console.WriteLine("Введённое число больше загаданного. Попробуйте еще раз.\n");
                }
                else if (userNumber > iiNumber)
                {
                    Console.WriteLine("Введенное число меньше загаданного. Попробуйте еще раз.\n");
                }
                else
                {
                    Console.WriteLine($"Число угадано! Число попыток {count}.\n");
                    Console.ReadKey();
                    break;
                }

            }
            while (true);
        }
    }
}
