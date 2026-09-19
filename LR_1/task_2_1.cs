using System;
using System.Security.Cryptography;
using static System.Math;

namespace OOP;
    class task_2_1 {
        static void Main(string[] args) {
            double x;
            
            Console.Write("Введите x: ");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Окак, ошибочка! Введите число ещё раз: ");
            };

            // дробь 1
            // числитель
            var c1 = 2*x - Pow(3, x);
            // знаменатель
            var z1 = Sqrt(4*Pow(x, 2) - 3*x + 1);

            // дробь 2
            // числитель
            var c2 = Pow(3, x+1) + Pow(3, x-2) + 2;
            var z2 = Pow(Sin(2+Pow(x, 2)), 2);

            var Y = c1/z1 + c2/z2;

            Console.Write($"Y = {Y}");
        }
    }
