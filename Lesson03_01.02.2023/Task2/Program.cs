using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число карт на руке: ");
            int handCard = int.Parse(Console.ReadLine());
            int handValue = 0;

            for (int i = 1; i <= handCard; i++)
            {
                Console.WriteLine($"Введите номинал {i}-й карты: ");
                string Value = Console.ReadLine();
                switch (Value)
                {
                    case "2": Console.WriteLine($"Ваш текущий номинал карт = {handValue += 2}"); break;
                    case "3": Console.WriteLine($"Ваш текущий номинал карт = {handValue += 3}"); break;
                    case "4": Console.WriteLine($"Ваш текущий номинал карт = {handValue += 4}"); break;
                    case "5": Console.WriteLine($"Ваш текущий номинал карт = {handValue += 5}"); break;
                    case "6": Console.WriteLine($"Ваш текущий номинал карт = {handValue += 6}"); break;
                    case "7": Console.WriteLine($"Ваш текущий номинал карт = {handValue += 7}"); break;
                    case "8": Console.WriteLine($"Ваш текущий номинал карт = {handValue += 8}"); break;
                    case "9": Console.WriteLine($"Ваш текущий номинал карт = {handValue += 9}"); break;
                    case "10": Console.WriteLine($"Ваш текущий номинал карт = {handValue += 10}"); break;
                    case "J": Console.WriteLine($"Ваш текущий номинал карт = {handValue += 10}"); break;
                    case "Q": Console.WriteLine($"Ваш текущий номинал карт = {handValue += 10}"); break;
                    case "K": Console.WriteLine($"Ваш текущий номинал карт = {handValue += 10}"); break;
                    case "T": Console.WriteLine($"Ваш текущий номинал карт = {handValue += 10}"); break;
                    default:
                        Console.WriteLine("Допустимы номиналы 2-10, J, Q, K, T");
                        break;
                }
            }
            if (handValue <= 21)
            {
                Console.WriteLine($"Ваш результат {handValue}.");
            }
            else Console.WriteLine($"Ваш результат {handValue}, вы проиграли.");


            Console.ReadKey();


        }

    }

}