using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] elements = command.Split();

                if (elements[0] == "Delete")
                {
                    numbers.RemoveAll(x => x == int.Parse(elements[1]));
                }
                if (elements[0] == "Insert")
                {
                    numbers.Insert(int.Parse(elements[2]), int.Parse(elements[1]));
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
