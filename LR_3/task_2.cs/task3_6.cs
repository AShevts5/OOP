using System;
using static System.Console;

namespace OOP
{
    class Task32_6
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(2, 6); 

            int[,] matrix = new int[n, n];
            ArrayOperations.FillRandom(matrix, 0, 100);

            ArrayOperations.PrintMatrix(matrix, $"Исходная матрица A({n},{n}):");

            double p = 1;
            double maxD = 0;

            for (int i = 0; i < n; i++)
            {
                int j = n - 1 - i; 
                double numD = matrix[i, j];
                
                p *= numD;
                
                if (numD > maxD)
                {
                    maxD = numD;
                }
            }

            double result = 0;
            if (maxD != 0)
            {
                result = p / maxD;
            }
            else
            {
                WriteLine("Максимальный элемент вспомогательной диагонали равен 0");
            }

            WriteLine($"Произведение элементов вспомогательной диагонали: {p}");
            WriteLine($"Максимальный элемент вспомогательной диагонали: {maxD}");
            WriteLine($"Результат: {result:F3}");
        }
    }
}