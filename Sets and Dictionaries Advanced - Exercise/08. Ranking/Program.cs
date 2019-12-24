using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();

            string command = Console.ReadLine();

            while (command != "end of contests")
            {
                string[] commandArgs = command.Split(":");
                string contest = commandArgs[0];
                string password = commandArgs[1];

                if (!contests.ContainsKey(contest))
                {
                    contests[contest] = password;
                }

                command = Console.ReadLine();
            }

            Dictionary<string, List<Exam>> exams = new Dictionary<string, List<Exam>>();

            string input = Console.ReadLine();

            while (input != "end of submissions")
            {
                string[] tokens = input.Split("=>");
                string examName = tokens[0];
                string examPassowrd = tokens[1];
                string studentName = tokens[2];
                int studentPoints = int.Parse(tokens[3]);

                Exam exam = new Exam(examName, studentPoints);

                if (contests.ContainsKey(examName) && contests[examName] == examPassowrd)
                {
                    if (!exams.ContainsKey(studentName))
                    {
                        exams.Add(studentName, new List<Exam>());
                        exams[studentName].Add(exam);
                    }
                    else

                    if (!exams[studentName].Any(x => x.Name == examName))
                    {
                        exams[studentName].Add(exam);
                    }
                    else
                    {
                        var point = exams[studentName].FirstOrDefault(x => x.Name == examName);

                        if (point.StudentPoints < studentPoints)
                        {
                            point.StudentPoints = studentPoints;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            string bestCandidate = string.Empty;
            int maxPoints = int.MinValue;
            foreach (var item in exams)
            {
                int MaxPoint = 0;
                foreach (var point in item.Value)
                {
                    MaxPoint += point.StudentPoints;
                    if (maxPoints < MaxPoint)
                    {
                        maxPoints = MaxPoint;
                        bestCandidate = item.Key;
                    }
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {maxPoints} points.");

            Console.WriteLine("Ranking: ");

            foreach (var student in exams.OrderBy(x => x.Key))
            {
                Console.WriteLine(student.Key);

                foreach (var exam in student.Value.OrderByDescending(x => x.StudentPoints))
                {
                    Console.WriteLine($"#  {exam.Name} -> {exam.StudentPoints}");
                }
            }
        }
    }

    public class Exam
    {
        public Exam(string name, int studentPoints)
        {
            Name = name;
            StudentPoints = studentPoints;
        }

        public string Name { get; set; }

        //public string Password { get; set; }

        //public string StudentName { get; set; }

        public int StudentPoints { get; set; }
    }
}
