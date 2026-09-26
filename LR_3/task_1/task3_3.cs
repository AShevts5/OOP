using System;
using static System.Console;

namespace OOP
{
    class Task3_3
    {
        static void Main(string[] args)
        {
            double[] arr = new double[10];

            ArrayOperations.InputArray(arr, "arr");
            ArrayOperations.PrintArray(arr, "Исходный массив:");

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


            ArrayOperations.PrintArray(arr, "Преобразованный массив: ");
            
            
        }
    }
}