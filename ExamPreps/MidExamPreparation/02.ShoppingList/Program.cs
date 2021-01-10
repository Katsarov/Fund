using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split("!", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] commandElements = command.Split();

                if (commandElements[0] == "Urgent")
                {
                    if (!list.Contains(commandElements[1]))
                    {
                        list.Insert(0, commandElements[1]);
                    }
                }

                if (commandElements[0] == "Unnecessary")
                {
                    if (list.Contains(commandElements[1]))
                    {
                        list.Remove(commandElements[1]);
                    }

                }

                if (commandElements[0] == "Correct")
                {
                    if (list.Contains(commandElements[1]))
                    {
                        var index = list.IndexOf(commandElements[1]);
                        string elementTemp = commandElements[1];
                        commandElements[1] = commandElements[2];
                        commandElements[2] = elementTemp;

                        list.Insert(2, commandElements[1]);
                        list.RemoveAt(index);
                    }

                }

                if (commandElements[0] == "Rearrange")
                {
                    if (list.Contains(commandElements[1]))
                    {

                        list.Add(commandElements[1]);
                        list.Remove(commandElements[1]);
                    } 
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
