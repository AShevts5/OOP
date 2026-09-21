using System;
using static System.Math;

namespace OOP
{
    class task_2_4
    {
        static void Main(string[] args)
        {
            const double eps = 1e-9;
            double x, c, z, Y;

            while (true)
            {
                Console.Write("Введите x: ");
                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Окак, ошибочка! Введите число ещё раз: ");
                }

                if (x <= 0)
                {
                    Console.WriteLine("Ошибка: x должен быть больше нуля. Попробуйте снова.");
                    continue;
                }

                c = Sin(2 * x) * Cos(x) - 2.4 * Log(x) - Tan(x);
                z = Sin(x) * Cos(x) - (Pow(x, 2) / Abs(x));

                if (Abs(z) < eps)
                {
                    Console.WriteLine("Ошибка: деление на ноль при данном значении x. Попробуйте другое значение.");
                    continue;
                }

                Y = c / z;
                Console.WriteLine($"Y = {Y}");
                break;
            }
        }
    }
}