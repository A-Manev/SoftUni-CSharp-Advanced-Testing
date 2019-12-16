using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int sizeOfTheGunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelligence = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(bullets);
            Queue<int> queue = new Queue<int>(locks);

            int barrelBullets = 0;
            while (stack.Count > 0 && queue.Count > 0)
            {
                int bullet = stack.Pop();
                int @lock = queue.Peek();

                if (bullet <= @lock)
                {
                    Console.WriteLine("Bang!");
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                intelligence -= bulletPrice;
                barrelBullets++;

                if (barrelBullets == sizeOfTheGunBarrel && stack.Count > 0)
                {
                    barrelBullets = 0;
                    Console.WriteLine("Reloading!");
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine($"{stack.Count} bullets left. Earned ${intelligence}");

            }
            else if (stack.Count == 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queue.Count}");
            }
        }
    }
}
