using System;
using System.Collections.Generic;

namespace D01.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Svetlin",
                "Georgi",
                "Maria",
                "Ana"
            };

            foreach (var element in names)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine();

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
