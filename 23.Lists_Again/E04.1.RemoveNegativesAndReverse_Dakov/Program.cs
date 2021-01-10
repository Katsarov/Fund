using System;
using System.Collections.Generic;
using System.Linq;

namespace E04._1.RemoveNegativesAndReverse_Dakov
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i--);
                }
            }

            numbers.Reverse();

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
