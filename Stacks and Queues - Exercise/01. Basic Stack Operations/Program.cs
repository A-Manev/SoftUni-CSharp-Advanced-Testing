using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersRepresentCommand = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            int elementsToPush = numbersRepresentCommand[0];
            int elementsToPop = numbersRepresentCommand[1];
            int elemetToLookFor = numbersRepresentCommand[2];

            for (int i = 0; i < elementsToPop; i++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }

            if (stack.Contains(elemetToLookFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
