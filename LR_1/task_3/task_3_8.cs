using System;
using static System.Console;

namespace OOP
{
    class task_3_8
    {
        static void Main(string[] args)
        {
            double price, cost, V;

            WriteLine("Введите объем расходованного газа:");
            while (!double.TryParse(ReadLine(), out V))
            {
                WriteLine("Ошибка, введите число ещё раз");
            }

            WriteLine("Введите тариф оплаты:");
            while (!double.TryParse(ReadLine(), out price))
            {
                WriteLine("Ошибка, введите число ещё раз");
            }

            cost = price * V;
            WriteLine($"Значение оплаты: {cost}");

        }
    }
}