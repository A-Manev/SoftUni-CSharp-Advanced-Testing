using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    while (queue.Count > 0)
                    {
                        string name = queue.Dequeue();
                        Console.WriteLine(name);
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
