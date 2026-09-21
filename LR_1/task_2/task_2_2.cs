using System;
using static System.Math;

namespace OOP
{
    class task_2_2
    {
        static void Main(string[] args)
        {
            double x, y;
            const double eps = 1e-9;

            while (true)
            {
                Console.Write("Введите x: ");
                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Окак, ошибочка! Введите число ещё раз: ");
                };

                double p = x + 2;

                if (p < 0)
                {
                    Console.WriteLine("Ошибка: подкоренное выражение не может быть отрицательным. Попробуйте другое значение x.");
                    continue;
                }
                else if (Abs(p) < eps)
                {
                    Console.WriteLine("Ошибка: деление на ноль при данном значении x. Попробуйте другое значение.");
                    continue;
                }

                var y1 = Cos(Pow(4, x) + Pow(2, x+1) - 8*x);
                y = y1 + Sin(2/Sqrt(p));
                Console.Write($"y = {y}");
                break;
            }
        }
    }
}