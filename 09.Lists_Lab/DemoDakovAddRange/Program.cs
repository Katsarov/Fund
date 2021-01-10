using System;
using System.Collections.Generic;

namespace DemoDakovAddRange
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> list = new List<string>();
            Console.WriteLine(list.Count);

            list.AddRange(new List<string>() { "1", "2", "3", "4", "5" });
            Console.WriteLine(string.Join(" , ", list));
            Console.WriteLine(list.Count);
        }
    }
}
