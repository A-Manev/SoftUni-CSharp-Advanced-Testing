using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] number = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = number[col];
                }
            }

            int maxSum = int.MinValue;
            int subMatrixRows = 2;
            int subMatrixCols = 2;
            int maxSumRow = 0;
            int maxSumCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - subMatrixRows + 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - subMatrixRows + 1; col++)
                {
                    var subMatrixSum = 0;

                    for (int subRow = 0; subRow < subMatrixRows; subRow++)
                    {
                        for (int subCol = 0; subCol < subMatrixCols; subCol++)
                        {
                            subMatrixSum += matrix[row + subRow, col + subCol];
                        }
                    }

                    if (subMatrixSum > maxSum)
                    {
                        maxSum = subMatrixSum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }

            for (int row = 0; row < subMatrixRows; row++)
            {
                for (int col = 0; col < subMatrixCols; col++)
                {
                    Console.Write(matrix[maxSumRow + row, maxSumCol + col] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
