using System;
using static System.Console;

namespace OOP
{

    class Task32_2
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(2, 6); 

            int[,] matrix = new int[n, n];
            ArrayOperations.FillRandom(matrix, -100, 100);

            ArrayOperations.PrintMatrix(matrix, $"Исходная матрица A({n},{n}):");

            int[] Sum = new int[n];

            for (int i = 0; i < n; i++)          
            {
                for (int j = 0; j < n; j++)     
                {                                
                    Sum[i] += matrix[i, j];
                }
            }

            WriteLine("Суммы элементов по строкам:");
            for (int j = 0; j < n; j++)
            {
                WriteLine($"Строка {j}: {Sum[j]}");
            }
        }
    }
}