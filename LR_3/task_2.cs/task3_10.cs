using System;
using static System.Console;

namespace OOP
{
    class Task32_10
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(2, 6); 

            int[,] matrix = new int[n, n];
            ArrayOperations.FillRandom(matrix, -100, 100);

            ArrayOperations.PrintMatrix(matrix, $"Исходная матрица A({n},{n}):");

            double oddSum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        oddSum += matrix[i, j];
                    }
                }
            }

            double p = 1;
            for (int i = 0; i < n; i++)
            {
                p *= matrix[i, i];
            }

            WriteLine($"Сумма нечётных элементов матрицы: {oddSum}");
            WriteLine($"Произведение элементов главной диагонали: {p}");
        }
    }
}