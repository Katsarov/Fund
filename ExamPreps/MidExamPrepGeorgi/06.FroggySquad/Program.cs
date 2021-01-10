using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FroggySquad
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frogNames = Console.ReadLine().Split().ToList();

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "Print")
            {
                if (command[0] == "Join")
                {
                    string name = command[1];
                    frogNames.Add(name);
                }

                else if (command[0] == "Jump")
                {
                    int index = int.Parse(command[2]);
                    string frogName = command[1];
                    if (index >= 0 && index < frogNames.Count)
                    {

                        frogNames.Insert(index, frogName);
                    }
                }

                else if (command[0] == "Dive")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < frogNames.Count)
                    {

                        frogNames.RemoveAt(index);
                    }
                }

                else if (command[0] == "First")
                {
                    int count = int.Parse(command[1]);
                    if (count > frogNames.Count)
                    {
                        count = frogNames.Count;
                    }

                    for (int i = 0; i < count; i++)
                    {
                        Console.Write(frogNames[i] + " ");
                    }
                    Console.WriteLine();
                }

                else if (command[0] == "Last")
                {
                    int count = int.Parse(command[1]);
                    if (count > frogNames.Count)
                    {
                        count = frogNames.Count;
                    }

                    for (int i = count; i > 0; i--)
                    {
                        Console.Write(frogNames[frogNames.Count - i] + " ");
                    }
                    Console.WriteLine();
                }

                command = Console.ReadLine().Split().ToArray();
            }

            if (command[1] == "Normal")
            {
                Console.WriteLine($"Frogs: {string.Join(" ", frogNames)}");
            }

            else
            {
                frogNames.Reverse();
                Console.WriteLine($"Frogs: {string.Join(" ", frogNames)}");
            }
        }
    }
}
