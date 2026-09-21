using System;
using static System.Console;
using static System.Math;


namespace OOP
{
    class task_3_3
    {
        static void Main(string[] args)
        {
            double k1, k2;
            WriteLine("Введите длину первого катета: ");
            while (!double.TryParse(ReadLine(), out k1)) 
            {
                WriteLine("Окак, ошибочка! Введите длину первого катета ещё раз");
            }
            WriteLine("Введите длину второго катета: ");

            while (!double.TryParse(ReadLine(), out k2)) 
            {
                WriteLine("Окак, ошибочка! Введите длину второго катета ещё раз");
            }

            if (k1 < 0 || k2 < 0)
            {
                WriteLine("Ошибка: длина катета не может быть отрицательной");
                return;
            }

            var g = Sqrt(Pow(k1, 2) + Pow(k2, 2));
            var S = k1 * k2 / 2;
            var P = g + k1 + k2;
            
            WriteLine($"Площадь треугольника: {S}, периметр: {P}");
        }
    }
}