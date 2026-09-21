using System;
using static System.Console;
using static System.Math;

namespace OOP 
{
    class task2_1 
    {
        static void Main(string[] args)
        {
            double a, b;

            Write("Введите первое число: ");
            while (!double.TryParse(ReadLine(), out a))
            {
                WriteLine("Окак, ошибочка! Введите число ещё раз: ");
            }

            Write("Введите второе число: ");
            while (!double.TryParse(ReadLine(), out b))
            {
                WriteLine("Окак, ошибочка! Введите число ещё раз: ");
            }

            double max_c = Max(a, b) + 1;
            WriteLine($"Большее число {Max(a, b)} + 1 = {max_c}");
        }
    }
}