using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Введите число: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(a % 2 == 0 ? "Четное число" : "Нечетное число");
            Console.ReadKey();
            
        }
    }
}
