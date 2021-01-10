using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            string pattern = @"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b";

            Regex regex = new Regex(pattern);

            var matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.Write($"{match.Value} ");
            }
            Console.WriteLine();
        }
    }
}
