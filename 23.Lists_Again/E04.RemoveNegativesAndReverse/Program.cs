using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> positiveNumbers = new List<int>();
            int count = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    positiveNumbers.Add(numbers[i]);
                    count++;
                }
            }

            positiveNumbers.Reverse();
            if (count > 0)
            {
                Console.WriteLine(string.Join(" ", positiveNumbers));
            }

            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
