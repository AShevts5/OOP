using System;
using static System.Console;
using static System.Math; 

namespace OOP 
{
    class Task2_10
    {
        static void Main(string[] args)
        {
            double[] arr = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Write($"Введите {i}-й элемент массива: "); 
                arr[i] = Convert.ToDouble(ReadLine());
            }
            
            double max_num = arr[0];
            foreach (double i in arr)
            {
                max_num = (i > max_num) ? i : max_num;
            }

            WriteLine($"Наибольшее число = {max_num}");
            
        }
    }
}