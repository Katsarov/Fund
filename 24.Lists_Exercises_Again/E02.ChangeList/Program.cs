using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] elements = command.Split();

                if (elements[0].Contains("Delete"))
                {
                    int element = int.Parse(elements[1]);
                    list.RemoveAll(x => x == element);
                }

                if (elements[0].Contains("Insert"))
                {
                    int element = int.Parse(elements[1]);
                    int position = int.Parse(elements[2]);

                    list.Insert(position, element);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
