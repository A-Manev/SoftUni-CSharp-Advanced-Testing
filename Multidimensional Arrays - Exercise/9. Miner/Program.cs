using System;
using System.Linq;

namespace _9._Miner
{
    class Program
    {
        static char[,] matrix;
        static int minorRow;
        static int minorCol;
        static int coals;

        static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            string[] directions = Console.ReadLine().Split();

            matrix = new char[size, size];

            InitializeMatrix(matrix);

            foreach (var currentDirections in directions)
            {
                switch (currentDirections)
                {
                    case "up":
                        Move(-1, 0);
                        break;
                    case "down":
                        Move(1, 0);
                        break;
                    case "right":
                        Move(0, 1);
                        break;
                    case "left":
                        Move(0, -1);
                        break;
                }
            }

            Console.WriteLine($"{coals} coals left. ({minorRow}, {minorCol})");
        }

        private static void Move(int row, int col)
        {
            if (IsInside(minorRow + row, minorCol + col))
            {
                minorRow += row;
                minorCol += col;

                if (matrix[minorRow,minorCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({minorRow}, {minorCol})");
                    Environment.Exit(0);
                }

                if (matrix[minorRow, minorCol] == 'c')
                {
                    coals--;
                    matrix[minorRow, minorCol] = '*';

                    if (coals == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({minorRow}, {minorCol})");
                        Environment.Exit(0);
                    }
                }
            }
        }

        private static void InitializeMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray().Where(c => c != ' ').ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 's')
                    {
                        minorRow = row;
                        minorCol = col;
                    }

                    if (matrix[row, col] == 'c')
                    {
                        coals++;
                    }
                }
            }
        }

        private static bool IsInside(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                col >= 0 && col < matrix.GetLength(1);
        }
    }
}
