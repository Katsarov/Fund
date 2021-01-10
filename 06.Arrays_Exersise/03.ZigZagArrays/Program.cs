using System;
using System.Linq;

namespace _03.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arrayOne = new int[n];
            int[] arrayTwo = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currentElement = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 == 0)
                {
                    arrayOne[i] = currentElement[0];
                    arrayTwo[i] = currentElement[1];
                }
                else
                {
                    arrayOne[i] = currentElement[1];
                    arrayTwo[i] = currentElement[0];
                }
            }

            Console.WriteLine(string.Join(" ", arrayOne));
            Console.WriteLine(string.Join(" ", arrayTwo));
        }
    }
}
