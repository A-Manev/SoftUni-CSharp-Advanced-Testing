using System;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static char[,] matrix;
        static int playerRow;
        static int playerCol;
        static int bunnyRow;
        static int bunnyCol;

        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            matrix = new char[rows, cols];

            InitializeMatrix();

            string directions = Console.ReadLine();

            for (int i = 0; i < directions.Length; i++)
            {
                char currentDirectin = directions[i];

                switch (currentDirectin)
                {
                    case 'U':
                        Move(-1, 0);
                        break;
                    case 'D':
                        Move(1, 0);
                        break;
                    case 'R':
                        Move(0, 1);
                        break;
                    case 'L':
                        Move(0, -1);
                        break;
                }

                Clone();

                MakeAToB();

                bool isPlayerExist = false;

                foreach (var item in matrix)
                {
                    if (item == 'P')
                    {
                        isPlayerExist = true;
                        break;
                    }
                }

                if (!isPlayerExist)
                {

                    PrintMatrix();
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    Environment.Exit(0);
                }
            }
        }

        private static void Clone()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        bunnyRow = row;
                        bunnyCol = col;

                        CloneBunny(-1, 0);
                        CloneBunny(1, 0);
                        CloneBunny(0, 1);
                        CloneBunny(0, -1);
                    }
                }
            }
        }

        private static void PrintMatrix()
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write(matrix[r, c]);
                }

                Console.WriteLine();
            }
        }

        private static void MakeAToB()
        {
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    if (matrix[r, c] == 'A')
                    {
                        matrix[r, c] = 'B';
                    }
                }
            }
        }

        private static void CloneBunny(int row, int col)
        {
            if (IsInside(bunnyRow + row, bunnyCol + col) && matrix[bunnyRow + row, bunnyCol + col] != 'B')
            {
                matrix[bunnyRow + row, bunnyCol + col] = 'A';
            }
        }

        private static void Move(int row, int col)
        {
            if (!IsInside(playerRow + row, playerCol + col))
            {
                matrix[playerRow, playerCol] = '.';
                Clone();
                MakeAToB();
                PrintMatrix();
                Console.WriteLine($"won: {playerRow} {playerCol}");
                Environment.Exit(0);
            }

            if (matrix[playerRow + row, playerCol + col] == 'B')
            {
                Clone();
                MakeAToB();
                PrintMatrix();

                playerRow += row;
                playerCol += col;

                Console.WriteLine($"dead: {playerRow} {playerCol}");
                Environment.Exit(0);
            }

            matrix[playerRow, playerCol] = '.';
            playerRow += row;
            playerCol += col;
            matrix[playerRow, playerCol] = 'P';
        }

        private static bool IsInside(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) &&
                col >= 0 && col < matrix.GetLength(1);

        }

        private static void InitializeMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] input = Console.ReadLine().ToCharArray().Where(c => c != ' ').ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];

                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }
    }
}
