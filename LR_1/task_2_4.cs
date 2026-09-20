using System;
using static System.Math;

namespace OOP
{

    class task_2_4
    {
        static void Main(string[] args)
        {
            double Y, x;

            Console.Write("Введите x: ");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Окак, ошибочка! Введите число ещё раз: ");
            }

            if (x <= 0)
            {
                Console.WriteLine("Ошибка: x должен быть больше нуля");
                return;
            }

            double c = Sin(2 * x) * Cos(x) - 2.4 * Log(x) - Tan(x);
            double z = Sin(x) * Cos(x) - (Pow(x, 2) / Abs(x));

            if (z == 0)
            {
                Console.WriteLine("Ошибка: деление на ноль");
            }
            else
            {
                Y = c / z;
                Console.WriteLine($"Y = {Y}"); 
            }
        }
    }
}