using System;
using System.Collections.Generic;
using System.Linq;

namespace D06.Demo_GetRange
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = Console.ReadLine().Split().ToList();

            var firstFiveelements = myList.GetRange(0, 5);
            Console.WriteLine(string.Join(" ", firstFiveelements));
        }
    }
}
