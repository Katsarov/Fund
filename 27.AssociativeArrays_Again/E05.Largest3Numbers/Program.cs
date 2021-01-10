using System;
using System.Linq;

namespace E05.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
