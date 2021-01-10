using System;

namespace E01.SmallestOfthreeNumbers_Light
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());


            int result = GetTheSmallestDigit(num1, num2, num3);
            Console.WriteLine(result);
        }

        static int GetTheSmallestDigit(int n1, int n2, int n3)
        {
            return Math.Min(Math.Min(n1, n2), n3);
        }
    }
}
