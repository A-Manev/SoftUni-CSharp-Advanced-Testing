using System;
using System.Linq;

namespace VAT
{
    class Program
    {
        static void Main()
        {
            double[] input = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(x => x + (x * 0.2))
                .ToArray();

            foreach (var price in input)
            {
                Console.WriteLine($"{price:F2}");
            }
        }
    }
}
