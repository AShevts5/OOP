using System;
using static System.Console;

namespace OOP
{
    class Task3_6
    {
        static void Main(string[] args)
        {
            double[] arr1 = new double[10];

            ArrayOperations.InputArray(arr1, "1");

            double[] arr2 = new double[10];

            ArrayOperations.InputArray(arr2, "2");

            ArrayOperations.PrintArray(arr1, "Исходный массив №1:");
            ArrayOperations.PrintArray(arr2, "Исходный массив №2:");


            double sum1 = 0, sum2 = 0, r1 = 0, r2 = 0;
            
            for (int i = 0; i < arr1.Length; i++)
            {
                sum1 += arr1[i];
                r1 -= arr1[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                sum2 += arr2[i];
                r2 -= arr2[i];
            }

            WriteLine($"Сумма и разность элементов массива 1 соответственно: {sum1} и {r1}");
            WriteLine($"Сумма и разность элементов массива 2 соответственно: {sum2} и {r2}");

        // или если в задании подразумевается найти сумму и разность элементов массивов, стоящих на одинаковых позициях:

            double[] arr_sum = new double[10];
            double[] arr_raz = new double[10];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr_sum[i] = arr1[i] + arr2[i];
                arr_raz[i] = arr1[i] - arr2[i];
            }
                    
            ArrayOperations.PrintArray(arr_sum, "Массив сумм элементов массивов, стоящих на одинаковых позициях:");
            ArrayOperations.PrintArray(arr_raz, "Массив разностей элементов массивов, стоящих на одинаковых позициях:");

            
        }
    }
}