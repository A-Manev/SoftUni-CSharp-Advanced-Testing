using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(numbers);

            List<int> evenNumbers = new List<int>();

            while (queue.Count > 0)
            {
                int num = queue.Dequeue();
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
            }

            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
