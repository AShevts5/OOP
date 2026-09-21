using System;
using static System.Math;

namespace OOP
{
    class task_3_2
    {
        static void Main(string[] args)
        {
            double R;

            Console.Write("Введите радиус: ");
            while (!double.TryParse(Console.ReadLine(), out R))
            {
                Console.Write("Окак, ошибочка! Введите число ещё раз: ");
            };

            if (R < 0)
            {
                Console.WriteLine("Ошибка: радиус не может быть отрицательным.");
                return;
            }

            double C = 2 * PI * R;
            double S = PI * Pow(R, 2);
            double V = (4 / 3) * PI * Pow(R, 3);

            Console.WriteLine($"Длина окружности: {C}");
            Console.WriteLine($"Площадь круга: {S}");
            Console.WriteLine($"Объём шара: {V}");
        }
    }
}