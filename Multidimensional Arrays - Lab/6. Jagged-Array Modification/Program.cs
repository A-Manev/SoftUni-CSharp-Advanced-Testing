using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jaggedArray[i] = numbers;
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                string arguments = command[0];
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (row < 0 || row >= jaggedArray.Length ||
                    col < 0 || col >= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                    command = Console.ReadLine().Split();
                    continue;
                }

                if (arguments == "Add")
                {
                    jaggedArray[row][col] += value;
                }
                else if (arguments == "Subtract")
                {
                    jaggedArray[row][col] -= value;
                }

                command = Console.ReadLine().Split();
            }

            foreach (var numbers in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
