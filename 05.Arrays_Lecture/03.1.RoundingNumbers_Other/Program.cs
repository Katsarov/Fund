using System;
using System.Linq;

namespace _03._1.RoundingNumbers_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            //  дава 75/100 точки
            decimal[] nums = Console.ReadLine().Split().Select(decimal.Parse).ToArray();

            foreach (double item in nums)
            {
                Console.WriteLine($"{item} => {Math.Round(item, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
