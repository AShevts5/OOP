using System;
using static System.Console;
using static System.Math;

namespace OOP
{
    class Task3_7
    {
        static void Main(string[] args)
        {
            double[] X = new double[10];
            double[] Y = new double[10];

            ArrayOperations.InputArray(X, "X");

            for (int i = 0; i < 10; i++)
            {
                Y[i] = 0.3 * Log(X[i]);
            }

            ArrayOperations.PrintArray(X, "Исходный массив X: ");
            ArrayOperations.PrintArray(Y, "Полученный массив Y: ");
        }
    }
}