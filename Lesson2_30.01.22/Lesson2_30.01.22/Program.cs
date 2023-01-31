using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_30._01._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region

            string fullName = "Васильев Василий Васильевич";
            byte age = 25;
            string email = "vasya@vasya.ru";
            double programmingPoints = 77.5;
            double mathPoints = 88.4;
            double physicsPoints = 81.6;


            Console.WriteLine("ФИО: {0} \nВозраст: {1} \nЭлектронная почта: {2} \nБаллы по программированию: {3} \nБаллы по математике: {4} \nБаллы по физике {5}", 
                fullName, 
                age,
                email, 
                programmingPoints,
                mathPoints, 
                physicsPoints);

            #endregion
            Console.ReadKey();
            double a = (programmingPoints + mathPoints + physicsPoints);
            double b = (a / 3);



            Console.WriteLine("Общий бал: {0} \nСредний бал:{1}", a, b);
            Console.ReadKey();

        }

    }
}
