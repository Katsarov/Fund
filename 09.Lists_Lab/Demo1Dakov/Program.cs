using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo1Dakov
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> inputList = Console.ReadLine().Split().ToList();


            PrintList(inputList);
            if (inputList.Remove("pesho"))
            {
                //Console.WriteLine("pesho removed!");
            }
            else
            {
                //Console.WriteLine("No pesho found :(");
            }
            
            Console.WriteLine("------------------");
            PrintList(inputList);

            
        }

        static void PrintList(List<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"List[{i}] = {list[i]}");
            }
        }
    }
}
