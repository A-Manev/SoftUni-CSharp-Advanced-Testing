using System;
using System.Collections.Generic;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        public static object Dictionatry { get; private set; }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string continentName = input[0];
                string countryName = input[1];
                string cityName = input[2];

                if (!continents.ContainsKey(continentName))
                {
                    continents.Add(continentName, new Dictionary<string, List<string>>());
                }

                if (!continents[continentName].ContainsKey(countryName))
                {
                    continents[continentName].Add(countryName, new List<string>());
                }

                if (!continents[continentName][countryName].Contains(cityName))
                {
                    continents[continentName][countryName].Add(cityName);
                }
            }

            foreach (var continent in continents)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
