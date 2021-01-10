using System;
using System.Collections.Generic;
using System.Linq;

namespace D12.Demo_ReadNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());

            //List<int> list = new List<int>();
            //for (int i = 0; i < n; i++)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    list.Add(number);

            //}

            //Console.WriteLine(string.Join(" ", list));

            // -----------------------------------------------------------------------------------
            //List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            //Console.WriteLine(string.Join(", ", list));

            // -----------------------------------------------------------------------------------

            List<string> list = Console.ReadLine().Split().ToList();

            List<int> newList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                newList.Add(int.Parse(list[i]));
            }

            Console.WriteLine(string.Join(", ", newList));
        }
    }
}
