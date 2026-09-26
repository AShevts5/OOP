using System;
using static System.Console;

namespace OOP
{
    class Task32_8
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(2, 6); 

            int[,] matrix = new int[n, n];
            ArrayOperations.FillRandom(matrix, -100, 100);

            ArrayOperations.PrintMatrix(matrix, $"Исходная матрица A({n},{n}):");

            double max = double.MinValue;
            bool found = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++) 
                {
                    if (!found || matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                        found = true;
                    }
                }
            }

            if (found)
            {
                WriteLine($"Максимальный элемент ниже главной диагонали: {max}");
            }
            else
            {
                WriteLine("Элементов ниже главной диагонали нет");
            }
        }
    }
}