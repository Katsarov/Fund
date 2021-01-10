using System;

namespace _05.AddAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine(SumAndSubtract(num1, num2, num3));
        }

        static int SumAndSubtract(int n1, int n2, int n3)
        {
            int result = n1 + n2 - n3;
            return result;
        }
    }
}
