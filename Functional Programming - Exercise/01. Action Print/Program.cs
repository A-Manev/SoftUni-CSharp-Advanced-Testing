using System;

namespace ActionPrint
{
    class Program
    {
        static void Main()
        {
            Action<string[]> print = items => Console.WriteLine(string.Join(Environment.NewLine, items));

            string[] input = Console.ReadLine()
                .Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries);

            print(input);
        }
    }
}
