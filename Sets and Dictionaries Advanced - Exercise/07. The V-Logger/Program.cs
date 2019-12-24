using System;
using System.Collections.Generic;
using System.Linq;

namespace TheVLogger
{
    class Program
    {
        static void Main()
        {
            List<Vlogger> vloggers = new List<Vlogger>();

            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[] commandArgs = command.Split();
                string name = commandArgs[0];
                string action = commandArgs[1];

                if (action == "joined" && !vloggers.Any(x => x.Name == name))
                {
                    Vlogger vlogger = new Vlogger(name);
                    vloggers.Add(vlogger);
                }
                else if (action == "followed")
                {
                    string followerName = commandArgs[0];
                    string followingName = commandArgs[2];

                    var follower = vloggers.FirstOrDefault(x => x.Name == followerName);
                    var following = vloggers.FirstOrDefault(x => x.Name == followingName);

                    if (follower != null && following != null && follower != following)
                    {
                        follower.Following.Add(followingName);
                        following.Followers.Add(followerName);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            int count = 1;

            foreach (var user in vloggers.OrderByDescending(x => x.Followers.Count).ThenBy(x=>x.Following.Count))
            {
                Console.WriteLine($"{count}. {user.Name} : {user.Followers.Count} followers, {user.Following.Count} following");

                if (count == 1)
                {
                    foreach (var item in user.Followers.OrderBy(x => x))
                    {
                        Console.WriteLine($"*  " + item);
                    }
                }

                count++;
            }
        }
    }

    public class Vlogger
    {
        private HashSet<string> followers;
        private HashSet<string> following;

        public Vlogger(string name)
        {
            Name = name;
            followers = new HashSet<string>();
            following = new HashSet<string>();
        }

        public string Name { get; set; }

        public HashSet<string> Followers => followers;

        public HashSet<string> Following => following;
    }
}
