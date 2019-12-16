using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] matrix = new char[rows, cols];

            string text = Console.ReadLine();

            int count = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    count++;
                    if (count >= text.Length)
                    {
                        count = 0;
                    }

                    matrix[row, col] = text[count];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row, col]);
                    }

                    Console.WriteLine();
                }
                else
                {
                    for (int col = matrix.GetLength(1)- 1; col >= 0; col--)
                    {
                        Console.Write(matrix[row, col]);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
