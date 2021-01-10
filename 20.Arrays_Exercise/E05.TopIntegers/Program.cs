using System;
using System.Linq;

namespace E05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program to find all the top integers in an array. A top integer is an integer which is bigger than all the elements to its right. 

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                bool isTopInteger = true;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        isTopInteger = false;
                        break;
                    }

                }

                if (isTopInteger)
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
