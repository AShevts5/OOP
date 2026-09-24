using System;
using static System.Console;

namespace OOP
{
    class Task3_1
    {
        static void Main(string[] args)
        {
            double[] arr = new double[10];

            for (int i = 0; i < 10; i++)
            {
                Write($"Введите {i}-й элемент массива: ");
                arr[i] = Convert.ToDouble(ReadLine());
            }

            WriteLine("Исходный массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Write($"{arr[i]}");
                }
                else
                {
                    Write($"{arr[i]}, ");

                }
            }
            WriteLine();
            double sum = 0;
            foreach (double num in arr)
            {
                sum += num;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] /= sum;
            }

            WriteLine($"Сумма элементов массива = {sum}");

            WriteLine("Преобразованный массив:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Write($"{arr[i]:F6}");
                }
                else
                {
                    Write($"{arr[i]:F6}, ");

                }
            }
            
        }
    }
}