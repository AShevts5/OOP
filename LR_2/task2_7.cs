using System;
using static System.Console;

namespace OOP 
{
    class task2_7
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 15; i <= 90; i++)
            {
                sum += (i % 2 == 0) ? i*2 : 0;
            }

            WriteLine($"Результат = {sum}");
        }
    }
}