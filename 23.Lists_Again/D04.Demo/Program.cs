using System;
using System.Collections.Generic;
using System.Linq;

namespace D04.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = Console.ReadLine().Split().ToList();

            if (myList.Contains("pesho"))
            {
                Console.WriteLine("Pesho go ima!");
            }
            else
            {
                Console.WriteLine("Pesho go nyama!!!");
            }
        }
    }
}
