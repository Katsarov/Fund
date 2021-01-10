using System;
using System.Linq;

namespace _0.TestMultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            // 1
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine(sum);

            //-----------------------------------------------------------------------------------------

            // 2
            //int number = int.Parse(Console.ReadLine());
            //int result = num.ToString().Sum(c => c - '0');
            //Console.WriteLine(result);


            //--------------------------------------------------------


            // 3 Method
            Console.WriteLine(SumOfDigits(number));
        }

        static int SumOfDigits(int num)
        {
            string oneNumber = num.ToString();

            int sum = 0;

            for (int i = 0; i < oneNumber.Length; i++)
            {
                sum += int.Parse(Convert.ToString(oneNumber[i]));
            }
            return sum;
        }
    }
}
