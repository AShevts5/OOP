using System;

namespace OOP 
{
    class task_3_9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму за воду: ");
            double water = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сумму за газ: ");
            double gas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сумму за электроэнергию: ");
            double electricity = Convert.ToInt32(Console.ReadLine());

            double cost = water + gas + electricity;
            Console.Write($"Общая сумма коммунальных платежей: {cost}");
        }
    }
}