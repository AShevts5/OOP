using System;
using static System.Console;

namespace OOP
{

    class Task3_9
    {
        static void Main(string[] args)
        {
            double[] A = new double[4];
            double[] B = new double[8];

            ArrayOperations.InputArray(A, "A");
            ArrayOperations.InputArray(B, "B");

            ArrayOperations.PrintArray(A, "Исходный массив A:");
            ArrayOperations.PrintArray(B, "Исходный массив B:");

            int cnt = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    cnt += 1;
                }
            }
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] > 0)
                {
                    cnt += 1;
                }
            }

            double[] C = new double[cnt];
            int k = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    C[k] = A[i];
                    k += 1;
                }
            }
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] > 0)
                {
                    C[k] = B[i];
                    k += 1;
                }
            }

            ArrayOperations.PrintArray(C, "Полученный массив C:");
        }
    }
}