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
            string userNumber = "";
            int value = 0;

            do
            {
                count++;
                Console.WriteLine("Введите число:\n");
                userNumber = Console.ReadLine();


                if (int.TryParse(userNumber, out value))
                {
                    if (value == iiNumber)
                    {
                        Console.WriteLine($"Число угадано! Число попыток {count}.\n");
                    }
                    else
                    {
                        if (value > iiNumber)
                        {
                            Console.WriteLine("Введенное число больше загаданного. Попробуйте еще раз.\n");
                        }
                        else
                        {
                            Console.WriteLine("Введённое число меньше загаданного. Попробуйте еще раз.\n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Игра закончена! Загаданное число {iiNumber}\n");
                    break;
                }

            }
            while (true);
            Console.ReadKey();
        }
    }
}
