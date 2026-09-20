using System;
using static System.Math;

namespace OOP
{
    class task_2_3
    {
        static void Main(string[] args)
        {
            double x, y, z, u;

            while (true)
            {
                Console.Write("Введите x: ");
                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Окак, ошибочка! Введите число ещё раз: ");
                };

                if (x < 0)
                {
                    Console.WriteLine("Ошибка: x не может быть отрицательным (поскольку под корнем). Попробуйте снова.");
                    continue;
                }

                Console.Write("Введите y: ");
                while (!double.TryParse(Console.ReadLine(), out y))
                {
                    Console.Write("Окак, ошибочка! Введите число ещё раз: ");
                };

                if (y < 0)
                {
                    Console.WriteLine("Ошибка: y не может быть отрицательным (корень 4-й степени). Попробуйте снова.");
                    continue;
                }

                Console.Write("Введите z: ");
                while (!double.TryParse(Console.ReadLine(), out z))
                {
                    Console.Write("Окак, ошибочка! Введите число ещё раз: ");
                };

                double c = x*y*z - 3.3*Abs(x + Pow(y, 0.25));
                double z = Pow(10, 7) + Sqrt(x);

                u = c / z;
                Console.WriteLine($"u = {u}");
                break;
            }
        }
    }
}