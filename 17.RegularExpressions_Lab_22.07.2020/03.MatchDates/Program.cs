using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            Regex regex = new Regex(pattern);

            var result = regex.Matches(input);

            foreach (Match match in result)
            {
                Console.WriteLine($"Day: {match.Groups["day"].Value}, Month: {match.Groups["month"].Value}, Year: {match.Groups["year"].Value}");
            }
        }
    }
}
