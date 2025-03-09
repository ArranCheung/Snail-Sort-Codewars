using System;
using System.Collections.Generic;

namespace Snail_sort
{
    internal class Program
    {
        static void Print(int[,] mat)
        {
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write($"{mat[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintList(List<int> list)
        {
            foreach (int num in list)
            {
                Console.Write($"{num} ");
            }
        }

        static int[,] Rotate(int[,] mat)
        {
            int rows = mat.GetLength(1); int cols = mat.GetLength(0) - 1;
            int[,] result = new int[rows, cols];

            int x = 0; int y = 0;
            for (int i = mat.GetLength(1) - 1; i >= 0; i--)
            {
                for (int j = 1; j < mat.GetLength(0); j++)
                {
                    result[y, x] = mat[j, i];
                    x++;
                }
                x = 0;
                y++;
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[,] ints = new int[,] { { 1, 2, 3, 1 }, { 4, 5, 6, 4 }, { 7, 8, 9, 7 }, { 7, 8, 9, 7 } };
            List<int> result = new List<int>();
            int length = ints.Length;

            while (length > 1)
            {
                Print(ints);
                for (int i = 0; i < ints.GetLength(1); i++)
                {
                    result.Add(ints[0, i]);
                }
                ints = Rotate(ints);
                length = ints.Length;
            }
            if (length == 1) { result.Add(ints[0, 0]); }
            PrintList(result);

            Console.ReadKey();
        }
    }
}
