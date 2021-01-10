using System;
using System.Collections.Generic;
using System.Linq;

namespace _00.DemoAllDigitsGreaterThanGivenDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            int digit = int.Parse(Console.ReadLine());

            var result = nums.FindAll(x => x > digit);

            result.Sort();

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
