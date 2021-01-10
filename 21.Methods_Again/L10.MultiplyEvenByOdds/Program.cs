using System;
using System.Linq;

namespace L10.MultiplyEvenByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that multiplies the sum of all even digits of a number by the sum of all odd digits of the same number:
            // Create a method called GetMultipleOfEvenAndOdds()
            // Create a method GetSumOfEvenDigits()
            // Create GetSumOfOddDigits()
            // You may need to use Math.Abs() for negative numbers

            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);

            int result = GetSumOfEvenDigits(n) * GetSumOfOddDigits(n);
            Console.WriteLine(result);
        }

        static int GetSumOfEvenDigits(int num)
        {
            string number = num.ToString();  // Правим си числото на стринг
            int sumEven = 0;
            for (int i = 0; i < number.Length; i++)
            {
                // Текущото число number[i] е чар. Затова трябва да го парснем към int. Този чар да го направим отново на стринг, и него вече да го кастнем към число.
                int currentNumber = int.Parse(number[i].ToString());
                if (currentNumber % 2 == 0)
                {
                    sumEven += currentNumber;
                }
            }
            return sumEven;
        }

        static int GetSumOfOddDigits(int num)
        {
            string number = num.ToString();
            int sumOdd = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int currentNumber = int.Parse(number[i].ToString());
                if (currentNumber % 2 != 0)
                {
                    sumOdd += currentNumber;
                }
            }
            return sumOdd;
        }
    }
}
