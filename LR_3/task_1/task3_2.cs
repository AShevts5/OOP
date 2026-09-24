using System;
using static System.Console;

namespace OOP
{
    class Task3_2
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
            double p = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    p *= arr[i];
                }
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] /= p;
            }

            WriteLine($"Произведение нечетных элементов массива = {p}");

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