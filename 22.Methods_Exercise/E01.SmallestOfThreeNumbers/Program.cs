using System;

namespace E01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method to print the smallest of three integer numbers. Use appropriate name for the method.

            int n = int.Parse(Console.ReadLine());
            int result = GetTheSmallestNumber(n);

            Console.WriteLine(result);
        }

        static int GetTheSmallestNumber(int nums)
        {
            int minNumber = int.MaxValue;
            for (int i = 0; i < nums; i++)
            {
                int curNum = int.Parse(Console.ReadLine());

                if (curNum < minNumber)
                {
                    minNumber = curNum;
                }
            }
            return minNumber;
        }
    }
}
