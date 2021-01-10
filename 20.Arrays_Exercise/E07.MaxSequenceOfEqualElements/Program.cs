using System;
using System.Linq;

namespace E07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that finds the longest sequence of equal elements in an array of integers. If several longest sequences exist, print the leftmost one.

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int maxLength = 0;
            int length = 1;

            int start = 0;
            int bestStart = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    length++;
                }
                else
                {
                    length = 1;
                    start = i;   // Показва ни индекса, от който започва поредицата
                }

                if (length > maxLength)
                {
                    maxLength = length;
                    bestStart = start;  // Дава ни първоначалния индекс на най-дългата поредица
                }
            }

            for (int i = bestStart; i < bestStart + maxLength; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
