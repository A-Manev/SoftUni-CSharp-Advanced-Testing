using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (command.Length == 2)
                {
                    int number = command[1];
                    stack.Push(number);
                }
                else
                {
                    int arguments = command[0];
                    if (arguments == 2)
                    {
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                    }
                    else if (arguments == 3)
                    {
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                    }
                    else if (arguments == 4)
                    {
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
