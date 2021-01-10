using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Threading.Tasks.Dataflow;

namespace _00.TestLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "one", "two", "three", "four", "five" };

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine("arr[{0}] = {1}", i, list[i]);
            //}

            Console.WriteLine(string.Join("; ", list));

            // --------------------------------------------------------------------
            //List<int> list1 = new List<int>();
            //List<int> list2 = new List<int>() { 1, 2, 3, 4 };

            //list1.AddRange(list2);
            //list1.Add(5);
            //list1.AddRange(list2);

            //Console.WriteLine(string.Join(" ", list1));
        }
    }
}
