using System;
using System.Linq;

namespace _06.EvenOrOddSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumEvenNums = 0;
            int sumOddNums = 0;
            int difference = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEvenNums += numbers[i];
                }
                else
                {
                    sumOddNums += numbers[i];
                }
            }

            difference = sumEvenNums - sumOddNums;

            Console.WriteLine(difference);
        }
    }
}
