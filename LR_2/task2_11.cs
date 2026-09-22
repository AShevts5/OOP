using System;
using static System.Console;
using static System.Math; 

namespace OOP 
{
    class Task2_11
    {
        static void Main(string[] args)
        {
            double[] arr = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Write($"Введите {i}-й элемент массива: "); 
                arr[i] = Convert.ToDouble(ReadLine());
            }
            
            int cnt = 0;
            foreach (double i in arr)
            {
                cnt += (i < 0) ? 1 : 0;
            }

            WriteLine($"Количество отрицательных чисел = {cnt}");
            
        }
    }
}