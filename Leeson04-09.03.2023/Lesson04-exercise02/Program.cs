using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04_exercise02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Привет, давай создадим матрицы \n");
            Console.WriteLine("Введите количество строк в матрице ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в матрице ");
            int b = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int[,] matrixA = new int[a, b];
            int[,] matrixB = new int[a, b];
            Console.Write("Первая матрица: \n");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    matrixA[i, j] = rnd.Next(0, 10);
                    Console.Write($"\t{matrixA[i, j]}");
                }
                Console.WriteLine();
                int[,] first = matrixA;
            }
            Console.WriteLine("\n");
            Console.Write("Вторая матрица: \n");
            for (int o = 0; o < a; o++)
            {
                for (int k = 0; k < b; k++)
                {
                    matrixB[o, k] = rnd.Next(0, 10);
                    Console.Write($"\t{matrixB[o, k]}");
                }
                Console.WriteLine();
                int[,] second = matrixB;
            }
            Console.WriteLine("\n");
            Console.Write("Сумма двух матриц: \n");
            int[,] matrixC = new int[a, b];
            for (int p = 0; p < a; p++)
            {
                for (int l = 0; l < b; l++)
                {
                    matrixC[p, l] = matrixA[p, l] + matrixB[p, l];
                    Console.Write($"\t{matrixC[p, l]}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();




        }

    }
}
