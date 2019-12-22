using System;
using System.Collections.Generic;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            Dictionary<string, int> numbers = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                string number = input[i];

                if (!numbers.ContainsKey(number))
                {
                    numbers.Add(number, 0);
                }

                numbers[number]++;
            }

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
