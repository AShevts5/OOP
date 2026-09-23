using System;
using static System.Console;
using static System.Math;

namespace OOP 
{
    class Task2_18
    {
        static void Main(string[] args)
        {            
            double y;
            for (double x = -5; x < 5; x += 0.2)
            {
                if (x < -3)
                {
                    y = x + 1;
                }
                else if (x >= -3 && x < 2)
                {
                    y = 2*x + 1;
                }
                else 
                {
                    y = 3*x;
                }

                WriteLine($"y({x:F1}) = {y:F1}");
            }
        }
    }
}