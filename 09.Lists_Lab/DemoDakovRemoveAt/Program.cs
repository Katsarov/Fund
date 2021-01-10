using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoDakovRemoveAt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split().ToList();
            
            Console.WriteLine(string.Join(" , ", list));
            list.RemoveAt(2);
            Console.WriteLine(string.Join(" , ", list));
        }
    }
}
