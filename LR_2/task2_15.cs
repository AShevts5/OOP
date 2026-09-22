using System;
using static System.Console;

namespace OOP 
{
    class Task2_15
    {
        static void Main(string[] args)
        {            
            for (double i = 2; i <= 4; i += 0.3)
            {
                double S = i*i;
                WriteLine($"Площадь квадрата со стороной {i:F1}: {S:F1}");
            }
        }
    }
}