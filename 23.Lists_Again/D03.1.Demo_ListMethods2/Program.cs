using System;
using System.Collections.Generic;
using System.Linq;

namespace D03.Demo_ListMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();

            // Премахва името "pesho" първият път, щом го срещне

            if (list.Remove("pesho"))
            {
                Console.WriteLine("Removed pesho!!!");
            }
            else
            {
                Console.WriteLine("No pesho found!");
            }

            PrintList(list);
        }

        static void PrintList(List<string> name)
        {
            for (int i = 0; i < name.Count; i++)
            {
                Console.WriteLine($"List[{i}] = {name[i]}");
            }
        }
    }
}

