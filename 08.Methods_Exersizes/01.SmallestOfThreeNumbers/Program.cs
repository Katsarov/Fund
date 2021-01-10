using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int smallest = SmallestOfThreeNumbers(num1, num2, num3);
            Console.WriteLine(smallest);
        }

        static int SmallestOfThreeNumbers(int n1, int n2, int n3)
        {
            int smallestDigit = int.MaxValue;

            if (n1 <= n2 && n1 <= n3)
            {
                smallestDigit = n1;
            }
            else if (n2 <= n1 && n2 <= n3)
            {
                smallestDigit = n2;
            }
            else
            {
                smallestDigit = n3;
            }

            return smallestDigit;
        }
    }
}
