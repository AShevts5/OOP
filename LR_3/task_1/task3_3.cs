using System;
using static System.Console;

namespace OOP
{
    class Task3_3
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


            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                {
                    cnt += 1;
                }
            }
            
            for (int i = 0; i < arr.Length; i++) 
            {
                arr[i] *= cnt;
            }

            WriteLine($"Количество элементов, равных 5: {cnt}");


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