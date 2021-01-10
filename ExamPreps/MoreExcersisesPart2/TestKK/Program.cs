using System;
using System.Diagnostics.CodeAnalysis;

namespace TestKK
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            // 145 % 10 = 5
            // 14 % 14 = 4
            // 1 % 10 = 1

            int tempNum = num;
            string strNum = string.Empty;
            strNum += num;  //"145"

            int sum = 0;

            for (int i = 0; i < strNum.Length; i++)
            {
                int currentDigit = tempNum % 10;  // ste vurne 5
                tempNum = tempNum / 10;

                //  5! = 1*2*3*4*5

                int factorial = 1;
                for (int j = 1; j <= currentDigit; j++)
                {
                    factorial *= j;
                }

                sum += factorial;
            }

            if (num == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
