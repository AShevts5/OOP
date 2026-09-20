using System;
using static System.Math;

namespace OOP
{
    class task_2_1 {
        static void Main(string[] args) {
            const double eps = 1e-9;
            double x, c1, z1, c2, z2, Y;

            while (true)
            {
                Console.Write("Введите x: ");
                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.Write("Окак, ошибочка! Введите число ещё раз: ");
                };

                // подкоренное выражение в знаменателе дроби 1
                var p = 4*Pow(x, 2) - 3*x + 1;

                if (p < 0)
                {
                    Console.WriteLine("Ошибка: подкоренное выражение отрицательно. Попробуйте другое значение x.");
                    continue;
                }

                // дробь 1
                c1 = 2*x - Pow(3, x);
                z1 = Sqrt(podkorennoe);

                // дробь 2
                c2 = Pow(3, x+1) + Pow(3, x-2) + 2;
                z2 = Pow(Sin(2+Pow(x, 2)), 2);

                if (Abs(z1) < eps || Abs(z2) < eps)
                {
                    Console.WriteLine("Ошибка: деление на ноль при данном значении x. Попробуйте другое значение.");
                    continue;
                }

                Y = c1/z1 + c2/z2;
                Console.Write($"Y = {Y}");
                break;
            }
        }
    }
}