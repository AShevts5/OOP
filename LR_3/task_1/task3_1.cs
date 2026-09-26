using System;
using static System.Console;

namespace OOP
{

    public static partial class ArrayOperations
        {
            public static void InputArray(double[] arr, string name)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Write($"Введите {i}-й элемент массива {name}: ");
                    arr[i] = Convert.ToDouble(ReadLine());
                }
            }

            public static void PrintArray(double[] arr, string title)
            {
                WriteLine(title);
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i == arr.Length - 1)
                    {
                        Write($"{arr[i]:F3}");
                    }
                    else
                    {
                        Write($"{arr[i]:F3}, ");
                    }
                }
                WriteLine();
            }
        }

    class Task3_1
    {
        static void Main(string[] args)
        {
            double[] arr = new double[10];

            ArrayOperations.InputArray(arr, "arr");
            ArrayOperations.PrintArray(arr, "Исходный массив: ");

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

            ArrayOperations.PrintArray(arr, "Преобразованный массив:");
            
        }
    }
}