using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[squareMatrixSize, squareMatrixSize];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int primaryDiagonalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    primaryDiagonalSum += matrix[row, col];
                    row++;
                }
            }

            int secondaryDiagonalSum = 0;

            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    secondaryDiagonalSum += matrix[row, col];
                    row--;
                }
            }

            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }
    }
}
