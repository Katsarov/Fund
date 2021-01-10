using System;
using System.Diagnostics.CodeAnalysis;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            int result = GetMultipleOfEvenAndOdds(n);
            Console.WriteLine(result);
            //Console.WriteLine(GetMultipleOfEvenAndOdds(n));
        }

        static int GetMultipleOfEvenAndOdds(int num)
        {
            return GetSumOfEvenDigits(num) * GetSumOfOddDigits(num); 
        }

        static int GetSumOfEvenDigits(int num)
        {
            int sumEvenDigits = 0;
            while (num > 0)
            {
                int number = num % 10;
                num /= 10;

                if (number % 2 == 0)
                {
                    sumEvenDigits += number;
                }
            }
            return sumEvenDigits;
        }

        static int GetSumOfOddDigits(int num)
        {
            int sumOddDigits = 0;
            while (num > 0)
            {
                int number = num % 10;
                num /= 10;

                if (number % 2 == 1)
                {
                    sumOddDigits += number;
                }
            }
            return sumOddDigits;
        }
    }
}
