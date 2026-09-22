using System;
using static System.Console;
using static System.Math;

namespace OOP 
{
    class task2_2 
    {
        static void Main(string[] args)
        {
            double x, y;

            Write("Введите x: ");
            while (!double.TryParse(ReadLine(), out x))
            {
                WriteLine("Окак, ошибочка! Введите число ещё раз: ");
            }

            if (x < -3)
            {
                y = x + 1;
            }
            else if (-3 <= x && x < 2)
            {
                y = 2*x + 1;
            }
            else
            {
                y = 3*x;
            }

            Write($"y = {y}");
        }
    }
}