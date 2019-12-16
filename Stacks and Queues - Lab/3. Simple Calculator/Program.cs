using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<string> stack = new Stack<string>(input.Reverse());

            int result = 0;

            while (stack.Count > 0)
            {
                string element = stack.Pop();

                if (element == "+")
                {
                    string number = stack.Pop();
                    result += int.Parse(number);
                }
                else if (element == "-")
                {
                    string number = stack.Pop();
                    result -= int.Parse(number);
                }
                else
                {
                    result = int.Parse(element);
                }
            }

            Console.WriteLine(result);
        }
    }
}
