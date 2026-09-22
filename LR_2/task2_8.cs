using System;
using static System.Console;

namespace OOP 
{
    class task2_8
    {
        static void Main(string[] args)
        {
            double p = 1;
            for (int i = 15; i <= 41; i++)
            {
                p *= i;
            }

            WriteLine($"Результат = {p}");
        }
    }
}