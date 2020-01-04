using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main()
        {
            Action<List<int>> print = x => Console.WriteLine(string.Join(" ", x));

            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int divider = int.Parse(Console.ReadLine());

            Predicate<int> filter = x => x % divider != 0;
            Func<int, bool> filterFunc = x => filter(x);

            input = input.Where(filterFunc).ToList();
            input.Reverse();
            print(input);
        }
    }
}
