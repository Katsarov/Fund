using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.InboxManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> people = new Dictionary<string, List<string>>();
            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[] newCommand = command.Split("->");

                string action = newCommand[0];

                if (action.Contains("Add"))
                {
                    string username = newCommand[1];
                    if (!people.ContainsKey(username))
                    {
                        people.Add(username, new List<string>());
                    }

                    else 
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                }

                if (action.Contains("Send"))
                {
                    string username = newCommand[1];
                    string email = newCommand[2];

                    people[username].Add(email);
                }

                if (action.Contains("Delete"))
                {
                    string username = newCommand[1];
                    if (people.ContainsKey(username))
                    {
                        people.Remove(username);
                    }

                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                }

                command = Console.ReadLine();
            }

            var sortedList = people.OrderByDescending(m => m.Value.Count).ThenBy(n => n.Key);
            Console.WriteLine($"Users count: " + sortedList.Count());

            foreach (var (username, email) in sortedList)
            {
                Console.WriteLine($"{username}");
                for (int i = 0; i < email.Count; i++)
                {
                    Console.WriteLine($" - {email[i]}");
                }
            }
        }
    }
}
