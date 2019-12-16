using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            double[][] matrix = new double[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
            }

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                if (matrix[row].Length == matrix[row + 1].Length)
                {
                    matrix[row] = matrix[row].Select(x => x * 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    matrix[row] = matrix[row].Select(x => x / 2).ToArray();
                    matrix[row + 1] = matrix[row + 1].Select(x => x / 2).ToArray();
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string arguments = command[0];

                if (arguments == "End")
                {
                    break;
                }

                int row = int.Parse(command[1]);
                int column = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row >= 0 && row < matrix.Length &&
                    column >= 0 && column < matrix[row].Length)
                {
                    if (arguments == "Add")
                    {
                        matrix[row][column] += value;
                    }
                    else if (arguments == "Subtract")
                    {
                        matrix[row][column] -= value;
                    }
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
