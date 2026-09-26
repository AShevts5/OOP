using System;
using static System.Console;

namespace OOP
{
    public static partial class ArrayOperations
    {
        public static void FillRandom(int[,] matrix, int minValue, int maxValue)
        {
            Random random = new Random();
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(minValue, maxValue);
                }
            }
        }

        public static void PrintMatrix(int[,] matrix, string text)
        {
            WriteLine(text);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Write($"{matrix[i, j]}\t");
                }
                WriteLine();
            }
            WriteLine();
        }
    }

    class Task32_1
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(2, 6); 

            int[,] matrix = new int[n, n];
            ArrayOperations.FillRandom(matrix, -100, 100);

            ArrayOperations.PrintMatrix(matrix, $"Исходная матрица A({n},{n}):");

            int[] Sum = new int[n];

            for (int j = 0; j < n; j++)          
            {
                for (int i = 0; i < n; i++)      
                {
                    Sum[j] += matrix[i, j];
                }
            }

            WriteLine("Суммы элементов по столбцам:");
            for (int j = 0; j < n; j++)
            {
                WriteLine($"Столбец {j}: {Sum[j]}");
            }
            WriteLine();
        }
    }
}