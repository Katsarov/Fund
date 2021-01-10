using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoDakovInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            numbers.Insert(2, 444);

            Console.WriteLine(string.Join(" , ", numbers));
        }
    }
}
