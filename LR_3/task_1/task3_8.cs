using System;
using static System.Console;

namespace OOP
{
    class Task3_8
    {
        static void Main(string[] args)
        {
            double[] arr = new double[10];

            ArrayOperations.InputArray(arr, "arr");
            ArrayOperations.PrintArray(arr, "Исходный массив: ");

            double sum = 0;
            int cnt = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                    cnt += 1;
                }
            }

            double sr = 0;
            if (cnt > 0)
            {
                sr = sum / cnt;
            }

            double max = 0;
            bool hasN = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    max = arr[i];
                }
            }

            if (max < 0)
            {
                hasN = true;
            }

            if (cnt > 0)
            {
                WriteLine($"Среднее арифметическое положительных элементов: {sr:F6}");
            }
            else
            {
                WriteLine("Положительных элементов в массиве нет");
            }


            if (hasN)
            {
                WriteLine($"Максимальное среди отрицательных элементов: {max:F6}");
            }
            else
            {
                WriteLine("Отрицательных элементов в массиве нет");
            }
        }
    }
}