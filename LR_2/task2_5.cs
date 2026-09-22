using System;
using static System.Console;
using static System.Math;

namespace OOP 
{
    class task2_5
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

            double min_c = Min(a, b) * 5;
            double max_c = Max(a, b) / 5;
            WriteLine($"Большее число ({Max(a,b)}) / 5 = {max_c}");
            WriteLine($"Меньшее число ({Min(a, b)}) * 5 = {min_c}");
        }
    }
}