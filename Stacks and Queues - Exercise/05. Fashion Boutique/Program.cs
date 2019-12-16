using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacity = int.Parse(Console.ReadLine());

            Stack<int> box = new Stack<int>(clothes);

            int rack = 0;
            int racksCount = 1;

            while (true)
            {
                if (box.Count == 0)
                {
                    break;
                }

                int element = box.Pop();

                if (rack + element <= capacity)
                {
                    rack += element;
                }
                else
                {
                    rack = 0;
                    racksCount++;
                    box.Push(element);
                }
            }

            Console.WriteLine(racksCount);
        }
    }
}
