using System;
using static System.Console;
using static System.Math;

namespace OOP 
{
    class task2_4 
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

            double min_c = Min(a, b) * Max(a, b);
            double max_c = Max(a, b) / Min(a, b);
            WriteLine($"Большее число, деленное на меньшее ({Max(a, b)} / {Min(a, b)}) = {max_c}");
            WriteLine($"Меньшее число, умноженное на большее ({Min(a, b)} * {Max(a,b)}) = {min_c}");
        }
    }
}