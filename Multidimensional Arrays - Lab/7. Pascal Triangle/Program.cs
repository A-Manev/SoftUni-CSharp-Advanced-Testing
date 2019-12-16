using System;

namespace _7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            long[][] pascalTriangle = new long[rows][];

            for (int i = 0; i < pascalTriangle.Length; i++)
            {
                pascalTriangle[i] = new long[i + 1];
            }

            for (int i = 0; i < pascalTriangle.Length; i++)
            {
                pascalTriangle[i][0] = 1;
                pascalTriangle[i][pascalTriangle[i].Length - 1] = 1;

                for (int j = 1; j < pascalTriangle[i].Length - 1; j++)
                {
                    pascalTriangle[i][j] =
                        pascalTriangle[i - 1][j - 1] +
                        pascalTriangle[i - 1][j];
                }
            }

            foreach (var row in pascalTriangle)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
