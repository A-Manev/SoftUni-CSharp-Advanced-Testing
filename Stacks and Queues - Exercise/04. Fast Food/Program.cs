using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityFoodForADay = int.Parse(Console.ReadLine());

            int[] quantity = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(quantity);

            Console.WriteLine(queue.Max());

            for (int i = 0; i < queue.Count; i++)
            {
                if ((quantityFoodForADay - queue.Peek()) >= 0)
                {
                    quantityFoodForADay -= queue.Dequeue();
                    i--;
                }
                else
                {
                    break;
                }
            }

            if (quantityFoodForADay >= 0 && queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
        }
    }
}
