using System;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            StringBuilder text = new StringBuilder();
            Stack<string> versions = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string commandArgs = command[0];

                switch (commandArgs)
                {
                    case "1":
                        versions.Push(text.ToString());
                        string someString = command[1];
                        text.Append(someString);
                        break;
                    case "2":
                        versions.Push(text.ToString());
                        int count = int.Parse(command[1]);
                        text.Remove(text.Length - count, count);
                        break;
                    case "3":
                        int index = int.Parse(command[1]) - 1;
                        Console.WriteLine(text[index]);
                        break;
                    case "4":
                        text.Clear();
                        text.Append(versions.Pop());
                        break;
                }
            }
        }
    }
}
