using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoDakovRemoveAll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            list.RemoveAll(x => x % 2 == 0 || x % 3 == 0);

            Console.WriteLine(string.Join(" , ", list));
        }
    }
}
