using System;
using static System.Console;

namespace OOP
{
    class task_3_11
    {
        static void Main(string[] args)
        {
            var sale = 70 * 10/100;
            var cost = 5 * 48.5 + 5 * 82.2 + 5 * (70-sale);
            WriteLine($"Общая сумма затрат на покупки = {cost}");
        }
    }
}