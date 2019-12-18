using System;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] matrix = new int[rows][];

            InitializeMatrix(matrix);

            string[] bombs = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            InitializeBombCoordinates(matrix, bombs);

            PrintMatrixInfo(matrix);

            PrintMatrix(matrix);
        }

        private static void InitializeBombCoordinates(int[][] matrix, string[] bombs)
        {
            for (int i = 0; i < bombs.Length; i++)
            {
                int[] coordinates = bombs[i]
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int row = coordinates[0];
                int col = coordinates[1];

                BombCells(matrix, row, col);
            }
        }

        private static void InitializeMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
        }

        private static void BombCells(int[][] matrix, int row, int col)
        {
            int bombPower = matrix[row][col];
            if (bombPower > 0)
            {
                isInside(matrix, row - 1, col - 1, bombPower);
                isInside(matrix, row - 1, col, bombPower);
                isInside(matrix, row - 1, col + 1, bombPower);
                isInside(matrix, row, col + 1, bombPower);
                isInside(matrix, row + 1, col + 1, bombPower);
                isInside(matrix, row + 1, col, bombPower);
                isInside(matrix, row + 1, col - 1, bombPower);
                isInside(matrix, row, col - 1, bombPower);

                matrix[row][col] = 0;
            }
        }

        private static void isInside(int[][] matrix, int row, int col, int bombPower)
        {
            if (row >= 0 && row < matrix.Length &&
                col >= 0 && col < matrix[row].Length && matrix[row][col] > 0)
            {
                matrix[row][col] -= bombPower;
            }
        }

        private static void PrintMatrixInfo(int[][] matrix)
        {
            int aliveCells = 0;
            int sum = 0;

            foreach (var row in matrix)
            {
                foreach (var col in row)
                {
                    if (col > 0)
                    {
                        aliveCells++;
                        sum += col;
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");
        }

        private static void PrintMatrix(int[][] matrix)
        {
            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
