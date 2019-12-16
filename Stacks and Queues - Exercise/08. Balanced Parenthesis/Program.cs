using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> openingBracket = new Stack<char>();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                {
                    openingBracket.Push(input[i]);
                }
                else
                {
                    if ((openingBracket.Peek() == '(' && input[i] == ')'))
                    {
                        openingBracket.Pop();
                        continue;
                    }
                    else if ((openingBracket.Peek() == '[' && input[i] == ']'))
                    {
                        openingBracket.Pop();
                        continue;
                    }
                    else if ((openingBracket.Peek() == '{' && input[i] == '}'))
                    {
                        openingBracket.Pop();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }

            Console.WriteLine("YES");
        }
    }
}
