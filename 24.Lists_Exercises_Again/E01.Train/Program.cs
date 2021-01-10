using System;
using System.Collections.Generic;
using System.Linq;

namespace E01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] elements = command.Split();
                
                if (elements[0].Contains("Add"))
                {
                    int people = int.Parse(elements[1]);
                    train.Add(people);

                }

                else
                {
                    int people = int.Parse(elements[0]);

                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + people <= maxCapacity)
                        {
                            train[i] += people;
                            break;
                        }
                    }
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}
