using System;
using static System.Console;
using static System.Math;

namespace OOP 
{
    class Task2_17
    {
        static void Main(string[] args)
        {            
            for (double i = 5; i <= 8; i += 0.2)
            {
                double V = Pow(i, 3);
                WriteLine($"Объем куба (сторона = {i:F1}): {V:F1}");
            }
        }
    }
}