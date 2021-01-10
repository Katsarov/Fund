using System;
using System.Collections.Generic;
using System.Linq;

namespace _00.Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){ 22, 4, 54, 3, 9, 67, 32, 15 };

            List<int> sortedList = numbers.OrderByDescending(x => x).ToList();

            Console.WriteLine(string.Join(" , ", sortedList));
        }
    }
}
