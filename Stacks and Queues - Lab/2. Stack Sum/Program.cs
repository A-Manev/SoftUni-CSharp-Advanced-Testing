using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>(input);

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] cmdArgs = command.Split();
                string arguments = cmdArgs[0];

                if (arguments == "add")
                {
                    numbers.Push(int.Parse(cmdArgs[1]));
                    numbers.Push(int.Parse(cmdArgs[2]));
                }
                else if (arguments == "remove")
                {
                    int numbersForRemove = int.Parse(cmdArgs[1]);

                    if (numbers.Count >= numbersForRemove)
                    {
                        for (int i = 0; i < numbersForRemove; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            Console.WriteLine("Sum: " + numbers.Sum());
        }
    }
}
