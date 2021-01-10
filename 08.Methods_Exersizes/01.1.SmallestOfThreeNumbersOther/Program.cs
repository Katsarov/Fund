using System;

namespace _01._1.SmallestOfThreeNumbersOther
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
            int smallest = Math.Min(n1, Math.Min(n2, n3));
            return smallest;
        }
    }
}
