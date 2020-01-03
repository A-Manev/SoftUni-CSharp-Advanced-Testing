using System;
using System.Linq;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main()
        {
            // Action<string[]> action = x => Console.WriteLine($"Sir {string.Join(Environment.NewLine, x)}");

            //string[] input = Console.ReadLine()
            //    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //action(input);

            Action<string> print = item => Console.WriteLine("Sir " + item);

            Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(print);

            //foreach (var item in input)
            //{
            //    Console.WriteLine("Sir " + item);
            //}
        }
    }
}
