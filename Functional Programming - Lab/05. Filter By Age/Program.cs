using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(", ");

                string personName = command[0];
                int personAge = int.Parse(command[1]);

                Person person = new Person(personName, personAge);
                people.Add(person);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> predicate = x => true;

            if (condition == "younger")
            {
                predicate = x => x.Age <= age;
            }
            else if (condition == "older")
            {
                predicate = x => x.Age >= age;
            }

            var filteredPeople = people.Where(predicate);

            foreach (var person in filteredPeople)
            {
                if (format == "name age")
                {
                    Console.WriteLine($"{person.Name} - {person.Age}");
                }
                else if (format == "name")
                {
                    Console.WriteLine($"{person.Name}");
                }
                else if (format == "age")
                {
                    Console.WriteLine($"{person.Age}");
                }
            }
        }
    }

    public class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}
