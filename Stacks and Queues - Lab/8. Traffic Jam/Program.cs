using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> carsInQueue = new Queue<string>();


            int n = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int count = 0;
            while (input != "end")
            {
                if (input != "green")
                {
                    carsInQueue.Enqueue(input);
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (carsInQueue.Count <= 0)
                        {
                            break;
                        }

                        count++;
                        string car = carsInQueue.Dequeue();
                        Console.WriteLine(car + " passed!");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(count + " cars passed the crossroads.");
        }
    }
}
