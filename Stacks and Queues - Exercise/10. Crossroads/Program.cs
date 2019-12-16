using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            string input = Console.ReadLine();
            int totalCarsPassed = 0;

            while (input != "END")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    int greenLight = greenLightSeconds;
                    int moreTime = freeWindow;

                    while (cars.Count > 0 && greenLight > 0)
                    {
                        string car = cars.Dequeue();
                        totalCarsPassed++;
                        greenLight -= car.Length;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
        }
    }
}
