using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leeson04_09._03._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Создание матрицы \n Введите колличество строк \n");
            var a = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов\n");
            var b = int.Parse(Console.ReadLine());
            int sum = 0;
            int[,] matrix = new int[a,b];

            Random r = new Random();

            
            for (int i = 0; i < a; i++)
            {
                
                for (int j = 0; j < b; j++)
                {
                    matrix[i, j] = r.Next(1, 10);
                    
                    Console.Write($"{matrix[i, j]} ");
                }
                    Console.WriteLine();
            }
            foreach (int e in matrix)
            {
                sum += e;
            }
            Console.WriteLine("Cумма всех чисел в матрице = " +sum);
            Console.ReadKey();


        }
    }
}
