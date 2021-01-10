using System;
using System.Text.RegularExpressions;

namespace _02.Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"U\$([A-Z][a-z]{2,})U\$P@\$([A-Za-z0-9]{5,}[0-9])P@\$";

            int totalCount = 0;

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Regex regex = new Regex(pattern);

                Match matches = regex.Match(input);

                int count = 0;

                if (matches.Success)
                {
                    count++;
                    Console.WriteLine("Registration was successful");

                    var username = matches.Groups[1].Value;
                    var password = matches.Groups[2].Value;
                    Console.WriteLine($"Username: {username}, Password: {password}");
                    totalCount += count;
                }

                else
                {
                    Console.WriteLine("Invalid username or password");

                }
            }

            Console.WriteLine($"Successful registrations: {totalCount}");
        }
    }
}
