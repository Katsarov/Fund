using System;
using System.Linq;

namespace E03.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program which creates 2 arrays. You will be given an integer n. On the next n lines you get 2 integers. Form 2 arrays as shown below.
            int n = int.Parse(Console.ReadLine());

            int[] arrOne = new int[n];
            int[] arrTwo = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                // Ако реда е нечетен

                if (i % 2 == 0)
                {
                    arrOne[i] += numbers[0];
                    arrTwo[i] += numbers[1];
                }
                else
                {
                    arrOne[i] += numbers[1];
                    arrTwo[i] += numbers[0];
                }
            }

            Console.WriteLine(string.Join(" ", arrOne));
            Console.WriteLine(string.Join(" ", arrTwo));
        }
    }
}
