using System;
using static System.Console;

namespace OOP 
{
    class Task2_14
    {
        static void Main(string[] args)
        {            
            for (double i = 1; i <= 20; i += 0.5)
            {
                WriteLine($"{i} ^ 2 = {i * i}");
            }
        }
    }
}