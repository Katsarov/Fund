using System;
using System.Collections.Generic;
using System.Linq;

namespace D07.Demo_RemoveAt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = Console.ReadLine().Split().ToList();

            Console.WriteLine(string.Join(" ", myList));
            myList.RemoveAt(2);
            Console.WriteLine(string.Join(" ", myList));
        }
    }
}
