using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> records = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string studentName = input[0];
                double studentGrade = double.Parse(input[1]);

                if (!records.ContainsKey(studentName))
                {
                    records.Add(studentName, new List<double>());
                }

                records[studentName].Add(studentGrade);
            }

            foreach (var student in records.OrderBy(x=>-x.Value.Average()))
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(x=>x.ToString("F2")))} (avg: {student.Value.Average():F2})");
            }
        }
    }
}
