using System;
using static System.Console;
using static System.Math;

namespace OOP
{
    class Task3_5
    {
        static void Main(string[] args)
        {
            double[] arr = new double[10];

            ArrayOperations.InputArray(arr, "arr");
            ArrayOperations.PrintArray(arr, "Исходный массив:");

            int cnt = 0;
            double sum = 0;
            double p = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 5)
                {
                    cnt += 1;
                    sum += arr[i];
                    p *= arr[i];
                }
            }

            WriteLine($"Количество элементов, равных 5: {cnt}");
            WriteLine($"Сумма элементов, равных 5: {sum}");
            WriteLine($"Произведение элементов, равных 5: {p}");

            double min = cnt;
            if (sum < cnt) {
                min = sum;
            }
            else if (p < cnt)
            {
                min = p;
            }

            WriteLine($"Минимальное значение: {min}");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= min;
            }

            ArrayOperations.PrintArray(arr, "Преобразованный массив:");
        }
    }
}