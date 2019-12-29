using System;
using System.Linq;

namespace SumNumbers
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(input.Length);
            Console.WriteLine(input.Sum());
        }
    }
}
