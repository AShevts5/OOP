using System;
using static System.Console;

namespace OOP
{
    class Task32_9
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(2, 6); 

            int[,] matrix = new int[n, n];
            ArrayOperations.FillRandom(matrix, -100, 100);

            ArrayOperations.PrintMatrix(matrix, $"Исходная матрица A({n},{n}):");

            double max = matrix[0, 0];
            for (int i = 1; i < n; i++)
            {
                if (matrix[i, i] > max)
                {
                    max = matrix[i, i];
                }
            }

            double min = matrix[0, n - 1];
            for (int i = 1; i < n; i++)
            {
                if (matrix[i, n - 1 - i] < min)
                {
                    min = matrix[i, n - 1 - i];
                }
            }

            double diff = max - min;

            WriteLine($"Максимальный элемент главной диагонали: {max}");
            WriteLine($"Минимальный элемент вспомогательной диагонали: {min}");
            WriteLine($"Разность: {diff}");
        }
    }
}