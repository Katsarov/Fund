using System;
using System.Linq;

namespace _05.SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumEvenNums = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sumEvenNums += numbers[i];
                }
                else
                {
                    
                }
            }

            if (sumEvenNums > 0)
            {
                Console.WriteLine(sumEvenNums);
            }
            else if (sumEvenNums == 0)
            {
                Console.WriteLine("0");
            }
        }
    }
}
