using System;
using static System.Console;
using static System.Math; 

namespace OOP 
{
    class Task2_9
    {
        static void Main(string[] args)
        {
            double[] arr = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Write($"Введите {i}-й элемент массива: "); 
                arr[i] = Convert.ToDouble(ReadLine());
            }
            
            double min_num = arr[0];
            foreach (double i in arr)
            {
                min_num = (i < min_num) ? i : min_num;
            }

            WriteLine($"Наименьшее число = {min_num}");
            
        }
    }
}