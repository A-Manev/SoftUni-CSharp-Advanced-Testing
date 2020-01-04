using System;
using System.Collections.Generic;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main()
        {
            Action<List<int>> print = x => Console.WriteLine(string.Join(" ", x));

            Func<int, int> add = x => x + 1;
            Func<int, int> multiply = x => x *= 2;
            Func<int, int> subtract = x => -1;

            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        input = input.Select(add).ToList();
                        break;
                    case "multiply":
                        input = input.Select(multiply).ToList();
                        break;
                    case "subtract":
                        input = input.Select(subtract).ToList();
                        break;
                    case "print":
                        print(input);
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
