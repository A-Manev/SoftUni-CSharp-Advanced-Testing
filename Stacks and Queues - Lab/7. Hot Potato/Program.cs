using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            int n = int.Parse(Console.ReadLine());

            Queue<string> childrens = new Queue<string>(names);

            while (childrens.Count != 1)
            {
                for (int i = 1; i < n; i++)
                {
                    childrens.Enqueue(childrens.Dequeue());
                }

                Console.WriteLine("Removed " + childrens.Dequeue());
            }

            Console.WriteLine("Last is " + childrens.Dequeue());
        }
    }
}
