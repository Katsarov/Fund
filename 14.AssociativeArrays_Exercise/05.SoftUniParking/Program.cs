using System;
using System.Collections.Generic;
using System.Linq;


namespace DictExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> infoFile = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                string command = input[0];
                string name = input[1];



                if (command == "register")
                {
                    string plate = input[2];

                    if (!infoFile.ContainsKey(name))
                    {
                        infoFile.Add(name, plate);
                        Console.WriteLine($"{name} registered {plate} successfully");
                    }

                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {infoFile[name]}");
                    }

                }

                else if (command == "unregister")
                {
                    if (!infoFile.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }

                    else
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        infoFile.Remove(name);
                    }

                }
            }

            foreach (var item in infoFile)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}