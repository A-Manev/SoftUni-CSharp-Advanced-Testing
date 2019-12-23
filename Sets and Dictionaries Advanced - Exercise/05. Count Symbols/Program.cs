using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();

            SortedDictionary<char, int> characters = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char character = text[i];

                if (!characters.ContainsKey(character))
                {
                    characters.Add(character, 0);
                }

                characters[character]++;
            }

            foreach (var ch in characters)
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
