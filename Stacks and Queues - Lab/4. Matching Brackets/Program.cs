using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (symbol == '(')
                {
                    stack.Push(i);
                }
                else if (symbol == ')')
                {
                    int startIndex = stack.Pop();
                    int endIndex = i;
                    string expression = input.Substring(startIndex, endIndex - startIndex + 1);
                    Console.WriteLine(expression);
                }
            }
        }
    }
}
