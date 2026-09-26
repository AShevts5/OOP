using System;
using static System.Console;
using static System.Math;


namespace OOP
{
    class Task32_5
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = random.Next(2, 6); 

            int[,] matrix = new int[n, n];
            ArrayOperations.FillRandom(matrix, 0, 100);

            ArrayOperations.PrintMatrix(matrix, $"Исходная матрица A({n},{n}):");

            double dSum = 0;
            int maxD = 0;

            for (int i = 0; i < n; i++)
            {
                int dNum = matrix[i, i]; 
                
                dSum += dNum;
                
                if (dNum > maxD)
                {
                    maxD = dNum;
                }
            }

            double res = 0;
            if (maxD != 0)
            {
                res = Abs(dSum) / Abs(maxD);
            }
            else
            {
                WriteLine("Максимальный диагональный элемент равен 0");
            }

            WriteLine($"Сумма элементов главной диагонали: {dSum}");
            WriteLine($"Максимальный элемент главной диагонали: {maxD}");
            WriteLine($"Результат: {res:F6}");
        }
    }
}