using System;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(\+359 2 [0-9]{3} [0-9]{4})|(\+359-2-[0-9]{3}-[0-9]{4})\b";

            Regex regex = new Regex(pattern);

            var results = regex.Matches(input);

            Console.WriteLine(string.Join(", ", results));
        }
    }
}
