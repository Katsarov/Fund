using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());

            double dollarExchangeRate = 1.31;

            decimal amount = pounds * (decimal)dollarExchangeRate;

            Console.WriteLine($"{amount:f3}");
        }
    }
}
