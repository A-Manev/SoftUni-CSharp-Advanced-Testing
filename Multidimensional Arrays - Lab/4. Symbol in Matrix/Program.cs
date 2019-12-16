using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());

            char[,] matrix = new char[squareMatrixSize, squareMatrixSize];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string text = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = text[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            bool isSymbolCantains = false;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        Console.Write($"({row}, {col})");
                        isSymbolCantains = true;
                        return;
                    }
                }
            }

            if (!isSymbolCantains)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
