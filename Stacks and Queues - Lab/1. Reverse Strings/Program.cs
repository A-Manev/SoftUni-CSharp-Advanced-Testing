using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _1.Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>(input);

            while (stack.Count > 0)
            {
                char ch = stack.Pop();

                Console.Write(ch);
            }
        }
    }
}
