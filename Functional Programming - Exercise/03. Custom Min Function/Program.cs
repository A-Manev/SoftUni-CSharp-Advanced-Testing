using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main()
        {
            Func<int[], int> func = x => x.Min();

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(func(numbers));
        }
    }
}
