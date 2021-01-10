using System;

namespace _02.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int searchedNum = 0;

            if (n % 10 == 0)
            {
                searchedNum = 10;
            }
            else if (n % 7 == 0)
            {
                searchedNum = 7;
            }
            else if (n % 6 == 0)
            {
                searchedNum = 6;
            }
            else if (n % 3 == 0)
            {
                searchedNum = 3;
            }
            else if (n % 2 == 0)
            {
                searchedNum = 2;
            }
            if (searchedNum == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {searchedNum}");
            }
        }
    }
}
