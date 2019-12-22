using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Revision")
                {
                    break;
                }

                string[] commandArguments = command.Split(", ");
                string shopName = commandArguments[0];
                string productName = commandArguments[1];
                double price = double.Parse(commandArguments[2]);

                if (!shops.ContainsKey(shopName))
                {
                    shops.Add(shopName, new Dictionary<string, double>());
                }

                var shop = shops[shopName];

                if (!shop.ContainsKey(productName))
                {
                    shop.Add(productName, price);
                }
            }

            foreach (var shop in shops.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
