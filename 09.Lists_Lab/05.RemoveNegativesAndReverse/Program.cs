using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            list.RemoveAll(x => x < 0);

            if (list.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                list.Reverse();
                Console.WriteLine(string.Join(" ", list));
            }

        }
    }
}
