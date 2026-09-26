using System;
using static System.Console;

namespace OOP
{
    class Task3_4
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
                if (arr[i] % 2 == 0)
                {
                    sum += arr[i];
                    cnt += 1;
                }
            }
            double sr = sum / cnt;
            WriteLine($"Ср.арифм. четных чисел: {sr}");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= sr;
            }

            ArrayOperations.PrintArray(arr, "Преобразованный массив:");
        }
    }
}