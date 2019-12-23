using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main()
        {
            HashSet<string> regularReservations = new HashSet<string>();
            HashSet<string> VipReservations = new HashSet<string>();

            bool reservation = true;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "END")
                {
                    break;
                }

                if (command == "PARTY")
                {
                    reservation = false;
                }

                if (reservation && command.Length == 8)
                {
                    if (char.IsDigit(command[0]))
                    {
                        VipReservations.Add(command);
                    }
                    else
                    {
                        regularReservations.Add(command);
                    }
                }
                else
                {
                    VipReservations.Remove(command);
                    regularReservations.Remove(command);
                }
            }

            Console.WriteLine(VipReservations.Count + regularReservations.Count);

            foreach (var guest in VipReservations)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in regularReservations)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
