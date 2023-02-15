using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество цифр в последовательности\n");
            int c = Int32.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int value = 0;
            for (; c > 0; c--)
            {
                Console.Write("Введите число: \n");
                value = Int32.Parse(Console.ReadLine());
                min = min > value ? value : min;
            }
            Console.WriteLine($"Минимальное число: {min}");

            Console.ReadKey();
        }
    }
}
