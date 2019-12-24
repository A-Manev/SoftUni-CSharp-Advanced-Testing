using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<Clothes>> wardrobe = new Dictionary<string, List<Clothes>>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" -> ");

                string color = command[0];
                string[] items = command[1].Split(",");

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new List<Clothes>());
                }

                for (int j = 0; j < items.Length; j++)
                {
                    string clothesName = items[j];

                    Clothes clothes = new Clothes(clothesName, 1, "");

                    if (!wardrobe[color].Any(x => x.Name == clothesName))
                    {
                        wardrobe[color].Add(clothes);
                    }
                    else
                    {
                        var item = wardrobe[color].Find(x => x.Name == clothesName);

                        item.Count++;
                    }
                }
            }

            string[] pieceOfClothing = Console.ReadLine().Split();
            string itemColor = pieceOfClothing[0];
            string garment = pieceOfClothing[1];

            var foundItem = wardrobe[itemColor].Find(x => x.Name == garment);

            if (foundItem != null)
            {
                foundItem.IsFound = "(found!)";
            }

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var item in color.Value)
                {
                    Console.WriteLine($"* {item.Name} - {item.Count} {item.IsFound}");
                }
            }
        }
    }

    public class Clothes
    {
        public Clothes(string name, int count, string isFound)
        {
            Name = name;
            Count = count;
            IsFound = isFound;
        }

        public string Name { get; set; }

        public int Count { get; set; }

        public string IsFound { get; set; }
    }
}
