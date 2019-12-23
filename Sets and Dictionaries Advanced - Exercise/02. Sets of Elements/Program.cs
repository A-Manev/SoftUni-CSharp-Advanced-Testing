using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main()
        {
            int[] numberElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int firstSetElements = numberElements[0];
            int secondSetElements = numberElements[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < firstSetElements; i++)
            {
                int number = int.Parse(Console.ReadLine());
                firstSet.Add(number);
            }

            for (int i = 0; i < secondSetElements; i++)
            {
                int number = int.Parse(Console.ReadLine());
                secondSet.Add(number);
            }

            foreach (var firstNum in firstSet)
            {
                foreach (var secondNum in secondSet)
                {
                    if (firstNum == secondNum)
                    {
                        Console.Write(firstNum + " ");
                    }
                }
            }
        }
    }
}
