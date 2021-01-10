using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";

            double totalSum = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of shift")
                {
                    break;
                }
                
                if (Regex.IsMatch(input,pattern))
                {
                    Match match = Regex.Match(input, pattern);

                    var customer = match.Groups["customer"].Value;
                    var product = match.Groups["product"].Value;
                    int count = int.Parse(match.Groups["count"].Value);
                    double price = double.Parse(match.Groups["price"].Value);

                    double sum = count * price;
                    totalSum += sum;

                    Console.WriteLine($"{customer}: {product} - {sum:f2}");
                }
            }

            Console.WriteLine($"Total income: {totalSum:f2}");
        }
    }
}
