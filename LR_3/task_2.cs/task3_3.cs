using System;
using static System.Console;
using static System.Math;


namespace OOP
{
    class Task32_3
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(2, 6); 
            int m = random.Next(2, 6);

            int[,] matrix = new int[n, m];
            ArrayOperations.FillRandom(matrix, -100, 100);

            ArrayOperations.PrintMatrix(matrix, $"Исходная матрица A({n},{m}):");

            int[] vector = new int[n];

            for (int i = 0; i < n; i++)          
            {
                double maxN = Abs(matrix[i, 0]); 
                int maxIndex = 0;                      

                for (int j = 1; j < m; j++)            
                {
                    if (Abs(matrix[i, j]) > maxN)
                    {
                        maxN = Abs(matrix[i, j]);
                        maxIndex = j;
                    }
                }

                vector[i] = matrix[i, maxIndex]; 
            }

            WriteLine("Векторный столбец (наибольшие по модулю элементы строк):");
            for (int i = 0; i < vector.Length; i++)
            {
                WriteLine($"{vector[i]}");
            }
        }
    }
}