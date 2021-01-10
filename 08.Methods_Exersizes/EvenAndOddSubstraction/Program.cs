using System;
using System.Linq;

namespace EvenAndOddSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int even = 0;
            int odd = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int current = number[i];

                if (current % 2 == 1)
                {
                    odd += current;
                }
                else
                {
                    even += current;
                }
            }

            int diff = even - odd;
            Console.WriteLine(diff);
        }
    }
}
