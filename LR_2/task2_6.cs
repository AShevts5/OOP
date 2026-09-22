using System;
using static System.Console;
using static System.Math;

namespace OOP 
{
    class task2_6
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double[] arr = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Write($"Введите {i}-й элемент массива: ");
                arr[i] = Convert.ToDouble(ReadLine());
                sum += arr[i];
            }

            WriteLine($"Сумма всех чисел = {sum}");
        }
    }
}