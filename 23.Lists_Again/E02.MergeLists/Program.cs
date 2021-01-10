using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.MergeLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine(string.Join(" ", MergeLists(firstList, secondList)));
        }

        static List<int> MergeLists(List<int> first, List<int> second)
        {
            int count = Math.Max(first.Count, second.Count);

            List<int> merged = new List<int>();
            for (int i = 0; i < count; i++)
            {
                if (first.Count > i)
                {
                    merged.Add(first[i]);
                }
                if (second.Count > i)
                {
                    merged.Add(second[i]);
                }
            }

            return merged;
        }
    }
}
