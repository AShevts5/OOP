using System;
using static System.Console;

namespace OOP 
{
    class Task2_13
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10]; 

            for (int i = 0; i < 10; i++)
            {
                Write($"Введите {i}-й элемент массива: ");
                arr[i] = Convert.ToInt32(ReadLine());

            }

            double sum = 0;
            int cnt = 0;
            
            foreach (int num in arr)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                    cnt++;
                }
            }
            
            double sr = (cnt > 0) ? (sum / cnt) : 0;

            WriteLine($"Сумма нечётных чисел = {sum}, их сред.арифм. = {sr}");
        }
    }
}