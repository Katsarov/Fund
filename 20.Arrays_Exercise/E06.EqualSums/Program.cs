using System;
using System.Linq;

namespace E06.EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that determines if there exists an element in the array such that the sum of the elements on its left is equal to the sum of the elements on its right (there will never be more than 1 element like that). If there are no elements to the left / right, their sum is considered to be 0. Print the index that satisfies the required condition or "no" if there is no such index.

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                // Правим си един цикъл за да обходим елементите в ляво от сегашния елемент
                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }

                // Правим си един втори цикъл за да обходим сега елементите в дясно от сегашния елемент
                for (int k = i + 1; k < array.Length; k++)
                {
                    rightSum += array[k];
                }

                if (leftSum == rightSum)
                {
                    // да отпечатаме индекса, не елемента
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
