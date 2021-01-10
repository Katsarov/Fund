using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoDakovContains
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine().Split().ToList();

            if (inputList.Contains("pesho"))
            {
                Console.WriteLine("pesho go ima");
            }
        }
    }
}
