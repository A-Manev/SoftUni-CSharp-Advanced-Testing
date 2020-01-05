using System;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split();

            Func<string, bool> func = x => x.Length <= lenght;

            names = names.Where(x => func(x)).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
