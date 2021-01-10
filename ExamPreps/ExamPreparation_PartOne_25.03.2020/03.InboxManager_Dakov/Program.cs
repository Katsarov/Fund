using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.InboxManager_Dakov
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();
            while (command != "Statistics")
            {
                var split = command.Split("->");
                if (command.Contains("Add"))
                {
                    if (users.ContainsKey(split[1]))
                    {
                        Console.WriteLine($"{split[1]} is already registered");
                    }
                    else
                    {
                        users.Add(split[1], new List<string>());
                    }
                }

                if (command.Contains("Send"))
                {
                    users[split[1]].Add(split[2]);
                }

                if (command.Contains("Delete"))
                {
                    if (users.ContainsKey(split[1]))
                    {
                        users.Remove(split[1]);
                    }

                    else
                    {
                        Console.WriteLine($"{split[1]} not found!");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {users.Count}");

            var sortedUsers = users.OrderByDescending(m => m.Value.Count).ThenBy(u => u.Key).ToList();

            foreach (var user in sortedUsers)
            {
                Console.WriteLine($"{user.Key}");

                for (int i = 0; i < user.Value.Count; i++)
                {
                    Console.WriteLine($" - {user.Value[i]}");
                }
            }
        }
    }
}
