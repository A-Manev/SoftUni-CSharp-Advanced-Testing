using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main()
        {
            HashSet<string> cars = new HashSet<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                string[] commandArguments = command.Split(", ");

                string carDirection = commandArguments[0];
                string carNumber = commandArguments[1];

                if (carDirection == "IN")
                {
                    cars.Add(carNumber);
                }
                else if (carDirection == "OUT")
                {
                    cars.Remove(carNumber);
                }
            }

            if (cars.Count > 0)
            {
                foreach (var carNumber in cars)
                {
                    Console.WriteLine(carNumber);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
