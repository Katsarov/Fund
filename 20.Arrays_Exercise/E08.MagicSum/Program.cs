using System;
using System.Linq;

namespace E08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program, which prints all unique pairs in an array of integers whose sum is equal to a given number. 

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int sum = array[i] + array[j];
                    if (sum == n)
                    {
                        Console.WriteLine($"{array[i]} {array[j]}");
                    }
                }
            }
        }
    }
}
