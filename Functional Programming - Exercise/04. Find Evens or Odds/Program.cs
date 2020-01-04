using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main()
        {
            Predicate<int> isEven = num => num % 2 == 0;

            Action<List<int>> print = x => Console.WriteLine(string.Join(" ", x));

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int start = input[0];
            int end = input[1];

            List<int> numbers = new List<int>();

            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);     
            }

            string command = Console.ReadLine();

            if (command == "odd")
            {
                numbers.RemoveAll(isEven);
            }
            else if (command == "even")
            {
                numbers.RemoveAll(x => !isEven(x));
            }

            print(numbers);
        }
    }
}
