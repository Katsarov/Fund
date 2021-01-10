using System;
using System.Collections.Generic;
using System.Linq;

namespace D05.Demo_Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = Console.ReadLine().Split().ToList();
            int from = int.Parse(Console.ReadLine());
            int to = int.Parse(Console.ReadLine());

            // Размяна на местата на 2 елемента

            string temp = myList[from];
            myList[from] = myList[to];
            myList[to] = temp;

            Console.WriteLine(string.Join(" ", myList));

        }
    }
}
