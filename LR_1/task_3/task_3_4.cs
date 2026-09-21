using System;
using static System.Console;

namespace OOP
{
    class task_3_4
    {
        static void Main(string[] args)
        {
            double x, y;
            WriteLine("Введите x: ");

            while (!double.TryParse(ReadLine(), out x))
            {
                WriteLine("Окак, ошибочка! Введите число ещё раз");
            }
            WriteLine("Введите y: ");

            while (!double.TryParse(ReadLine(), out y))
            {
                WriteLine("Окак, ошибочка! Введите число ещё раз");
            }

            WriteLine($"{x} + {y} = {x+y}; {x} - {y} = {x-y}; {x} * {y} = {x * y}");

        }
    }
}