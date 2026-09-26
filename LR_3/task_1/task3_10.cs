using System;
using static System.Console;

namespace OOP
{
    class Task3_10
    {
        static void Main(string[] args)
        {
            double[] arr = new double[10];

            ArrayOperations.InputArray(arr, "arr");
            ArrayOperations.PrintArray(arr, "Исходный массив:");

            double sum = 0;
            int cnt = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0 && arr[i] % 2 == 0)
                {
                    sum += arr[i];
                    cnt += 1;
                }
            }

            double avg = 0;
            if (cnt > 0)
            {
                avg = sum / cnt;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= avg;
            }

            WriteLine($"Среднее арифметическое четных положительных элементов: {avg:F3}");
            WriteLine();

            ArrayOperations.PrintArray(arr, "Преобразованный массив:");
        }
    }
}