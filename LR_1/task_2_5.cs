using System;
using static System.Math;

namespace OOP
{
    class task_2_5
    {
        static void Main(string[] args)
        {
            double x;

            while (true)
            {
                Console.Write("Введите x: ");
                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Окак, ошибочка! Введите число ещё раз: ");
                };

                var y1 = Pow(Cos(3*PI/8 - x/4), 2);
                var y = y1 - Pow(Cos(11*PI/8 + x/4), 2);
                Console.Write($"y = {y}");
                break;
            }
        }
    }
}