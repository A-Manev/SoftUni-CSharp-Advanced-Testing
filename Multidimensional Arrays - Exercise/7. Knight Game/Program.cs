using System;
using System.Linq;

namespace _7._Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            char[][] matrix = new char[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray().Where(x => x != ' ').ToArray();
            }
            int knightCount = 0;
            int maxAttacks = 0;
            int killerRow = 0;
            int killerCol = 0;

            while (true)
            {
                maxAttacks = 0;

                for (int row = 0; row < matrix.Length; row++)
                {
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        int currentKnightsAttacks = 0;

                        if (matrix[row][col] == 'K')
                        {
                            //down and right -> row + 2 , col + 1
                            if (IsInside(matrix, row + 2, col + 1) && matrix[row + 2][col + 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            // down and left -> row + 2 , col - 1
                            if (IsInside(matrix, row + 2, col - 1) && matrix[row + 2][col - 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            //up and right -> row - 2 , col + 1
                            if (IsInside(matrix, row - 2, col + 1) && matrix[row - 2][col + 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            //up and left -> row - 2 , col - 1
                            if (IsInside(matrix, row - 2, col - 1) && matrix[row - 2][col - 1] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            // left and up -> col + 2 , row  - 1
                            if (IsInside(matrix, row - 1, col - 2) && matrix[row - 1][col - 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            // left and down -> col + 2 , row  + 1
                            if (IsInside(matrix, row + 1, col - 2) && matrix[row + 1][col - 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            // right and up -> col + 2 , row  - 1
                            if (IsInside(matrix, row - 1, col + 2) && matrix[row - 1][col + 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }

                            // right and down -> col + 2 , row  + 1
                            if (IsInside(matrix, row + 1, col + 2) && matrix[row + 1][col + 2] == 'K')
                            {
                                currentKnightsAttacks++;
                            }
                        }

                        if (currentKnightsAttacks > maxAttacks)
                        {
                            maxAttacks = currentKnightsAttacks;
                            killerRow = row;
                            killerCol = col;
                        }
                    }
                }

                if (maxAttacks > 0)
                {
                    matrix[killerRow][killerCol] = '0';
                    knightCount++;
                }
                else
                {
                    Console.WriteLine(knightCount);
                    break;
                }
            }
        }

        private static bool IsInside(char[][] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.Length &&
           col >= 0 && col < matrix[row].Length;
        }
    }
}
