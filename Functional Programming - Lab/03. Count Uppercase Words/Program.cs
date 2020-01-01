using System;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> isUpper = UppercaseString;

            foreach (var word in input)
            {
                if (isUpper(word))
                {
                    Console.WriteLine(word);
                }
            }
        }

        static bool UppercaseString(string inputString)
        {
            return char.IsUpper(inputString[0]) ? true : false;

            //if (char.IsUpper(inputString[0]))
            //{
            //    return true;
            //}

            //return false;
        }
    }
}
