using System;

namespace OOP 
{
    class task_3_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите z: ");
            int z = Convert.ToInt32(Console.ReadLine());

            double sr = (x+y+z)/3;
            Console.Write($"Среднее арифметическое чисел {x}, {y}, {z} = {sr}");
        }
    }
}