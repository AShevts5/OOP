using System;
using static System.Math;

namespace OOP {
    class task_2 {
        static void Main1(string[] args) {
            double Y, x;
            
            Console.Write("Введите x: ");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Окак, ошибочка! Введите число ещё раз: ");
            }

            Console.Write("Введите y: ");
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.Write("Окак, ошибочка! Введите число ещё раз: ");
            }

            // числитель
            double c = Sin(2*x) * Cos(x) - 2.4 * Log(x) - Tan(x);
            // знаменатель
            double z = Sin(x) * Cos(x) - (Pow(x, 2)/Abs(x));

            Y = c/z;
            Console.Write("Y = " + Y);
        }
    }
}