using System;
using static System.Console;

namespace OOP
{
    class task_3_7
    {
        static void Main(string[] args)
        {
            double price, cost, kV;

            WriteLine("Введите количество расходованных кВ:");
            while (!double.TryParse(ReadLine(), out kV))
            {
                WriteLine("Ошибка, введите число ещё раз");
            }

            WriteLine("Введите тариф оплаты:");
            while (!double.TryParse(ReadLine(), out price))
            {
                WriteLine("Ошибка, введите число ещё раз");
            }

            cost = price * kV;
            WriteLine($"Значение оплаты: {cost}");

        }
    }
}