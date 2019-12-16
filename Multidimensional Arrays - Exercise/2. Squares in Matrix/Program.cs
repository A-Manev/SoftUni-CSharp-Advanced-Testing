using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensons = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensons[0];
            int cols = dimensons[1];

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] character = Console.ReadLine().ToCharArray().Where(c => c != ' ').ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = character[col];
                }
            }

            int all2x2matrix = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char ch1 = matrix[row, col];
                    char ch2 = matrix[row, col + 1];
                    char ch3 = matrix[row + 1, col];
                    char ch4 = matrix[row + 1, col + 1];

                    if (ch1 == ch2 && ch1 == ch3 && ch1 == ch4)
                    {
                        all2x2matrix++;
                    }
                }
            }

            Console.WriteLine(all2x2matrix);
        }
    }
}
