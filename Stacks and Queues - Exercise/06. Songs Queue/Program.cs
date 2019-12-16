using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ");

            Queue<string> queue = new Queue<string>(songs);

            string input = Console.ReadLine();

            while (true)
            {
                string[] arguments = input.Split();
                string command = arguments[0];

                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command == "Add")
                {
                    StringBuilder songName = new StringBuilder();

                    for (int i = 1; i < arguments.Length; i++)
                    {
                        songName.Append(arguments[i]);
                        if (i < arguments.Length -1)
                        {
                            songName.Append(" ");
                        }
                    }

                    if (!queue.Contains(songName.ToString()))
                    {
                        queue.Enqueue(songName.ToString());
                    }
                    else
                    {
                        Console.WriteLine($"{songName} is already contained!");
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", queue));
                }

                if (queue.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
