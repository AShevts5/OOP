using System;
using static System.Math;

namespace OOP
{
    class task_2_7
    {
        static void Main(string[] args)
        {
            double x, r;
            const double eps = 1e-9;

            while (true)
            {
                Console.Write("Введите x: ");
                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Окак, ошибочка! Введите число ещё раз: ");
                };

                double cosx = Cos(x);
                if (Abs(cosx) < eps)
                {
                    Console.WriteLine("Ошибка: cos(x) = 0, деление на ноль. Попробуйте другое значение x.");
                    continue;
                }

                double odz1 = Sin(x) + 1/cosx;
                if (Abs(odz1) < eps)
                {
                    Console.WriteLine("Ошибка: знаменатель внутренней дроби равен нулю. Попробуйте другое значение x.");
                    continue;
                }

                double odz2 = 1 + 1/odz1;
                if (Abs(odz2) < eps)
                {
                    Console.WriteLine("Ошибка: знаменатель равен нулю. Попробуйте другое значение x.");
                    continue;
                }

                r = ( Sin(x) + Cos(0.5*x) + Sin(x) - Pow(x, 2) ) / odz2;
                Console.Write($"r = {r}");
                break;
            }
        }
    }
}