using System;
using static System.Console;

namespace OOP
{
    class Task3
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[2][];
            jagged[0] = new int[5];
            jagged[1] = new int[7];

            Random random = new Random();
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    jagged[i][j] = random.Next(-10, 11);
                }
            }

            WriteLine("Исходный зубчатый массив:");
            for (int i = 0; i < jagged.Length; i++)
            {
                Write($"Массив {i}: ");
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Write($"{jagged[i][j]}");
                    if (j < jagged[i].Length - 1)
                        Write(", ");
                }
                WriteLine();
            }
            WriteLine();

            // Задание №1
            int sumP1 = 0;
            for (int j = 0; j < jagged[0].Length; j++)
            {
                if (jagged[0][j] > 0)
                    sumP1 += jagged[0][j];
            }

            long prodAll2 = 1; 
            for (int j = 0; j < jagged[1].Length; j++)
            {
                prodAll2 *= jagged[1][j];
            }

            WriteLine($"Сумма положительных элементов 1-го массива: {sumP1}");
            WriteLine($"Произведение всех элементов 2-го массива: {prodAll2}");
            WriteLine();

            // Задание №2
            int max1 = jagged[0][0];
            for (int j = 1; j < jagged[0].Length; j++)
            {
                if (jagged[0][j] > max1)
                    max1 = jagged[0][j];
            }

            int sumFL2 = jagged[1][0] + jagged[1][jagged[1].Length - 1];

            WriteLine($"Max значение элементов 1-го массива: {max1}");
            WriteLine($"Сумма 1-го и последнего элемента 2-го массива: {sumFL2}");
            WriteLine();

            // Задание №3
            int min1 = jagged[0][0];
            for (int j = 1; j < jagged[0].Length; j++)
            {
                if (jagged[0][j] < min1)
                    min1 = jagged[0][j];
            }

            int pr2 = jagged[1].Length - 2;

            WriteLine($"Min значение элементов 1-го массива: {min1}");
            WriteLine($"Индекс предпоследнего элемента 2-го массива: {pr2}");
            WriteLine($"Значение предпоследнего элемента 2-го массива: {jagged[1][pr2]}");
            WriteLine();

            // Задание №4
            int cntNeg1 = 0; 
            for (int j = 0; j < jagged[0].Length; j++)
            {
                if (jagged[0][j] < 0)
                    cntNeg1++;
            }

            long prodEven2 = 1; 
            bool hasEven2 = false;
            for (int j = 0; j < jagged[1].Length; j++)
            {
                if (jagged[1][j] % 2 == 0)
                {
                    prodEven2 *= jagged[1][j];
                    hasEven2 = true;
                }
            }

            WriteLine($"Количество отрицательных элементов 1-го массива: {cntNeg1}");
            if (hasEven2)
                WriteLine($"Произведение чётных элементов 2-го массива: {prodEven2}");
            else
                WriteLine("Чётных элементов во 2-м массиве нет.");
            WriteLine();

            // Задание №5
            int cntZero1 = 0; 
            for (int j = 0; j < jagged[0].Length; j++)
            {
                if (jagged[0][j] == 0)
                    cntZero1++;
            }

            int maxNeg2 = int.MinValue;
            bool hasNeg2 = false; 
            for (int j = 0; j < jagged[1].Length; j++)
            {
                if (jagged[1][j] < 0)
                {
                    if (!hasNeg2 || jagged[1][j] > maxNeg2)
                    {
                        maxNeg2 = jagged[1][j];
                        hasNeg2 = true;
                    }
                }
            }

            WriteLine($"Количество нулевых элементов 1-го массива: {cntZero1}");
            if (hasNeg2)
                WriteLine($"Max значение среди отрицательных элементов 2-го массива: {maxNeg2}");
            else
                WriteLine("Отрицательных элементов во 2-м массиве нет.");
            WriteLine();

            // Задание №6
            int cntEven1 = 0;
            for (int j = 0; j < jagged[0].Length; j++)
            {
                if (jagged[0][j] % 2 == 0)
                    cntEven1++;
            }

            long prodFirstLast2 = (long)jagged[1][0] * jagged[1][jagged[1].Length - 1]; 

            WriteLine($"Количество чётных элементов 1-го массива: {cntEven1}");
            WriteLine($"Произведение 1-го и последнего элементов 2-го массива: {prodFirstLast2}");
            WriteLine();

            // Задание №7
            int sumEvenPos1 = 0; 
            for (int j = 0; j < jagged[0].Length; j++)
            {
                if (jagged[0][j] > 0 && jagged[0][j] % 2 == 0)
                    sumEvenPos1 += jagged[0][j];
            }

            double div2 = 0;
            bool canDivide = jagged[1][0] != 0;
            if (canDivide)
                div2 = (double)jagged[1][jagged[1].Length - 1] / jagged[1][0];

            WriteLine($"Сумма чётных положительных элементов 1-го массива: {sumEvenPos1}");
            if (canDivide)
                WriteLine($"Результат деления последнего на первый (2-й массив): {div2:F3}");
            else
                WriteLine("Деление невозможно: первый элемент 2-го массива равен 0");
            WriteLine();

            // Задание №8
            int sumNeg1 = 0; 
            for (int j = 0; j < jagged[0].Length; j++)
            {
                if (jagged[0][j] < 0)
                    sumNeg1 += jagged[0][j];
            }

            int sub2 = jagged[1][0] - jagged[1][1];

            WriteLine($"Сумма отрицательных элементов 1-го массива: {sumNeg1}");
            WriteLine($"Результат вычитания 1 и 2 элементов 2-го массива: {sub2}");
            WriteLine();

            // Задание №9
            long prodNeg1 = 1;
            bool hasNeg1 = false;
            for (int j = 0; j < jagged[0].Length; j++)
            {
                if (jagged[0][j] < 0)
                {
                    prodNeg1 *= jagged[0][j];
                    hasNeg1 = true;
                }
            }

            int countFive2 = 0;
            for (int j = 0; j < jagged[1].Length; j++)
            {
                if (jagged[1][j] == 5)
                    countFive2++;
            }

            if (hasNeg1)
                WriteLine($"Произведение отрицательных элементов 1-го массива: {prodNeg1}");
            else
                WriteLine("Отрицательных элементов в 1-м массиве нет.");
            WriteLine($"Количество элементов, равных 5, во 2-м массиве: {countFive2}");
            WriteLine();

            // Задание №10
            int maxFirst4 = jagged[0][0];
            for (int j = 1; j < 4 && j < jagged[0].Length; j++)
            {
                if (jagged[0][j] > maxFirst4)
                    maxFirst4 = jagged[0][j];
            }

            int sumAll2 = 0;
            for (int j = 0; j < jagged[1].Length; j++)
            {
                sumAll2 += jagged[1][j];
            }

            WriteLine($"Max значение первых четырёх элементов 1-го массива: {maxFirst4}");
            WriteLine($"Сумма элементов 2-го массива: {sumAll2}");
        }
    }
}