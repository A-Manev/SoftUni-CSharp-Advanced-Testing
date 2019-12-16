using System;
using System.Linq;

namespace _3._Primary_Diagonal
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

            int currentRow = 0;
            int currentCol = 0;

            int sum = 0;
            while (true)
            {
                if (currentRow >= matrix.GetLength(0) ||
                    currentCol >= matrix.GetLength(1))
                {
                    break;
                }

                sum += matrix[currentRow, currentCol];

                currentRow++;
                currentCol++;
            }

            Console.WriteLine(sum);

            //int diagonalSum = 0;

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        diagonalSum += matrix[row, col];
            //        row++;
            //    }
            //}

            //Console.WriteLine(diagonalSum);
        }
    }
}
