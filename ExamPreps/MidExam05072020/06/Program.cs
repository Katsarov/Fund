using System;
using System.Collections.Generic;
using System.Linq;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split().ToArray();

                if (tokens[0] == "swap")
                {
                    int indexOne = int.Parse(tokens[1]);
                    int indexTwo = int.Parse(tokens[2]);

                    int temp = list[indexOne];
                    list[indexOne] = list[indexTwo];
                    list[indexTwo] = temp;
                }

                else if (tokens[0] == "multiply")
                {
                    int indexOne = int.Parse(tokens[1]);
                    int indexTwo = int.Parse(tokens[2]);

                    list[indexOne] = list[indexOne] * list[indexTwo];
                }

                else if (tokens[0] == "decrease")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i]--;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
