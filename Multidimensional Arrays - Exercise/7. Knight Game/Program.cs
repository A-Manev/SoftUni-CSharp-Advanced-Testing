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

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'K')
                    {

                    }
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine($"{string.Join(" ", row)} ");
            }
        }
    }
}
