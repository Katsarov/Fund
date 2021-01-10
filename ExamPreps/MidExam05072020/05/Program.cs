using System;
using System.Collections.Generic;
using System.Linq;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            list.Sort();
            list.Reverse();
            int sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }

            int count = 0;

            for (int i = 0; i < list.Count; i++)
            {
                count++;
            }

            double average = 1.0 * sum / count;


            List<int> newList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > average)
                {

                    newList.Add(list[i]);
                }
            }

            if (newList.Count > 5)
            {
                newList.RemoveRange(5, newList.Count - 5);
            }

            if (newList.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", newList));
            }

        }
    }
}
