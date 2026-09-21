using System;
using static System.Console;

namespace OOP
{
    class task_3_13
    {
        static void Main(string[] args)
        {
            double salary, u;

            WriteLine("Введите изначальную сумму зарплаты:");
            while (!double.TryParse(ReadLine(), out salary))
            {
                WriteLine("Ошибка, введите число ещё раз");
            }

            WriteLine("Введите сумму удержаний:");
            while (!double.TryParse(ReadLine(), out u))
            {
                WriteLine("Ошибка, введите число ещё раз");
            }

            salary -= u;
            WriteLine($"Величина запрлаты с учетом вычета всех удержаний: {salary}");

        }
    }
}