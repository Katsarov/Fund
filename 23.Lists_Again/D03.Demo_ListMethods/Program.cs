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

            // Премахва името "pesho" всеки път, щом го срещне

            while (list.Remove("pesho"))
            {
                Console.WriteLine("Removed pesho!!!");
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
