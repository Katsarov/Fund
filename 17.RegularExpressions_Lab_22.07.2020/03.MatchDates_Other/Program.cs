using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates_Other
{
    class Program
    {
        static void Main(string[] args)
        {

            string pattern = @"\b(\d{2})\.([A-Za-z]{2})\2(\d{4})\b";

            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            var matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups[1].Value}, Month: {match.Groups[3].Value}, Year: {match.Groups[4].Value}");
            }
        }
    }
}
