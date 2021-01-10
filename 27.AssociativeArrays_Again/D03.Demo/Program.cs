using System;
using System.Linq;

namespace D03.Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split().ToList();

            input = input.OrderBy(x => x.Length).ThenBy(x => x[0]).ToList();

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
