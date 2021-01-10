using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commands = input.Split();
                string operation = commands[0];

                if (operation.Contains("Add"))
                {
                    int number = int.Parse(commands[1]);
                    list.Add(number);
                }

                else if (operation.Contains("Insert"))
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);

                    if (index >= 0 && index < list.Count)
                    {
                        list.Insert(index, number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }

                else if (operation.Contains("Remove"))
                {
                    int index = int.Parse(commands[1]);

                    if (index >= 0 && index < list.Count)
                    {
                        list.RemoveAt(index);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }

                else if (operation.Contains("Shift"))
                {
                    int count = int.Parse(commands[2]);
                    if (commands[1] == "left")
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int firstNum = list[0];
                            list.Add(firstNum);
                            list.RemoveAt(0);
                        }
                    }

                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            int lastNum = list[list.Count - 1];
                            list.Insert(0, lastNum);
                            list.RemoveAt(list.Count - 1);
                        }
                    }


                }
                input = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
