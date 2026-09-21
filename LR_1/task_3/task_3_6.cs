using System;
using static System.Console;

namespace OOP
{
    class task_3_6
    {
        static void Main(string[] args)
        {
            double price, cost, cnt;

            WriteLine("Введите цену за единицу товара:");
            while (!double.TryParse(ReadLine(), out price))
            {
                WriteLine("Ошибка, введите число ещё раз");
            }

            WriteLine("Введите количество товара:");
            while (!double.TryParse(ReadLine(), out cnt))
            {
                WriteLine("Ошибка, введите число ещё раз");
            }

            cost = price * cnt;
            WriteLine($"Стоимость товара: {cost}");

        }
    }
}