using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            Console.WriteLine("Введите число\n");
            int n = int.Parse(Console.ReadLine());
            int i = 2;
            while (i <= n - 1)
            {
                if (n % i == 0)
                {
                    check = false;
                    break;
                }
                i++;
            }
            if (check)
            {
                Console.WriteLine("Число простое");
            }
            else
            {
                Console.WriteLine("Число составное");
            }
            Console.ReadKey();




        }
    }
}
