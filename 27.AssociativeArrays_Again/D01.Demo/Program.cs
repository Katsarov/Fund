using System;
using System.Collections.Generic;
using System.Linq;

namespace D01.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 8 2.5 2.5 8 2.5

            var numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
            Dictionary<double, int> dict = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!dict.ContainsKey(numbers[i]))
                {
                    dict.Add(numbers[i], 1);
                }
                else
                {
                    dict[numbers[i]]++;
                }
            }

            var sortedDict = dict.OrderBy(x => x.Key);
            foreach (var item in sortedDict)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
