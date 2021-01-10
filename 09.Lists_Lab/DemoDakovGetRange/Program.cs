using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoDakovGetRange
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();

            var newList = list.GetRange(1, 3);

            Console.WriteLine(string.Join(" , ", newList));
        }
    }
}
