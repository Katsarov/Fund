using System;
using System.Collections.Generic;
using System.Linq;

namespace D13.Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            //numbers.Sort();
            //numbers.Reverse();

            numbers = numbers.OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(" ", numbers));

            numbers = numbers.OrderByDescending(x => x).ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
