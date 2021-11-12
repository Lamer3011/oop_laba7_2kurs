using System;

namespace oop_laba7_2kurs
{
    class Program
    {
        static void Main()
        {
            double max = 0, current = 0;
            int row = 0, elements = 0;

            int[,] matrix = {
                {6, 14, -9, 5, 0},
                {78, -7, -2, -1, 11},
                {4, 1, -8, 12, -19},
                {4, 5, -6, -7, 8}};

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                elements = 0;
                current = 0d;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        elements++;
                        current += matrix[i, j];
                    }
                }
                current /= (double)elements;
                if (current > max)
                {
                    max = current;
                    row = i;
                }
            }
            
            int[] D = new int[5];
            for (int i = 0; i < matrix.GetLength(1); i++)
                D[i] = matrix[row, i];

            Console.WriteLine("String with the largest arithmetic mean of the positive elements:");
            for (int m = 0; m < D.GetLength(0); m++)
                Console.Write($"{D[m]} ");
            Console.ReadKey();
        }
    }
}
