using System;
using System.Numerics;

namespace _03.BigFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var output = Factorial.Calculate(n);
            Console.WriteLine(output);
        }
    }

    public class Factorial
    {
        public static BigInteger Calculate(int n)
        {
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }

    
}
