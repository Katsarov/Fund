using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine(Console.ReadLine().Split().Select(int.Parse).Max());

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var num = numbers.Max();

            Console.WriteLine(num);
        }
    }
}
