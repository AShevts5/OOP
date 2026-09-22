using System;
using static System.Console;

namespace OOP 
{
    class Task2_16
    {
        static void Main(string[] args)
        {            
            for (double i = 3; i <= 6; i += 0.2)
            {
                double S = 4*i;
                WriteLine($"Площадь прямоугольника (основание = {i:F1}): {S:F1}");
            }
        }
    }
}