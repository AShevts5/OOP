using System;
using static System.Console;
using static System.Math;


namespace OOP
{
    class Task32_4
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(2, 6);
            int m = random.Next(2, 6);

            int[,] matrix = new int[n, m];
            ArrayOperations.FillRandom(matrix, -100, 100);

            ArrayOperations.PrintMatrix(matrix, $"Исходная матрица A({n},{m}):");

            int[] vector = new int[m];

            for (int j = 0; j < m; j++)          
            {
                double minN = Abs(matrix[0, j]); 
                int minIndex = 0;                        

                for (int i = 1; i < n; i++)              
                {
                    if (Abs(matrix[i, j]) < minN)
                    {
                        minN = Abs(matrix[i, j]);
                        minIndex = i;
                    }
                }

                vector[j] = matrix[minIndex, j]; 
            }

            WriteLine("Векторный столбец (наименьшие по модулю элементы столбцов):");
            for (int j = 0; j < vector.Length; j++)
            {
                WriteLine($"{vector[j]}");
            }
        }
    }
}