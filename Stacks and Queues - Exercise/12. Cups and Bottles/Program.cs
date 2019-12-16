using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottels = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(cups);
            Stack<int> stack = new Stack<int>(bottels);

            int wastedWater = 0;
            int cupValue = 0;
            bool needMoreWatter = false;

            while (queue.Count > 0 && stack.Count > 0)
            {
                if (!needMoreWatter)
                {
                    cupValue = queue.Peek();
                }
                int bottel = stack.Pop();

                if (cupValue - bottel <= 0)
                {
                    wastedWater += cupValue - bottel;
                    queue.Dequeue();
                    needMoreWatter = false;
                }
                else
                {
                    needMoreWatter = true;
                    cupValue -= bottel;
                }
            }

            if (stack.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", stack)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", queue)}");
            }

            Console.WriteLine($"Wasted litters of water: {Math.Abs(wastedWater)}");
        }
    }
}
