using System;
using System.Linq;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Its sum of digits is divisible by 8, e.g. 8, 16, 88.
            // Holds at least one odd digit, e.g. 232, 707, 87578.

            int number = int.Parse(Console.ReadLine());

            CheckAllNumbersInRange(number);
           
        }

        static void CheckAllNumbersInRange(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (HasOddDigit(i) && IsDigitSumDivisibleBy8(i))
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }
            
        }

        static bool IsDigitSumDivisibleBy8(int i)
        {
            int currNum = i;
            int digitSum = 0;
            while (currNum > 0)
            {
                int digit = currNum % 10;
                digitSum += digit;
                currNum /= 10;
            }

            if (digitSum % 8 == 0)
            {
                return true;
            }

            return false;
        }
        static bool HasOddDigit(int i)
        {
            int currNum = i;
            while (currNum > 0)
            {
                int digit = currNum % 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
                currNum /= 10;
            }
            return false;
        }

       

    }
}
