using System;
using static System.Console;
using static System.Math;

namespace OOP
{
    class task_3_5
    {
        static void Main(string[] args)
        {
            double a, b, y, z, r;
            WriteLine("Введите значение a: ");
            while (!double.TryParse(ReadLine(), out a))
            {
                WriteLine("Бро, ошибочка) Введите число ещё раз");
            }
            WriteLine("Введите значение b: ");

            while (!double.TryParse(ReadLine(), out b))
            {
                WriteLine("Бро, ошибочка) Введите число ещё раз");
            }

            y = Pow((a+b), 2);
            z = Pow((a-b), 2);
            r = Pow((a*b), 2);

            WriteLine($"y = {y}, z = {z}, r = {r}");
        }
    }
}