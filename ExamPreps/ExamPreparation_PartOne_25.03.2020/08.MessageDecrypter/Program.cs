using System;
using System.Text.RegularExpressions;

namespace _08.MessageDecrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"^([%$])([A-Z][a-z]{2,})(\1)\:\s\[(\d+)\]\|\[(\d+)\]\|\[(\d+)\]\|$";

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                Match match = Regex.Match(message, pattern);

                if (match.Success)
                {
                    string openingTag = match.Groups[1].Value;
                    string closingTag = match.Groups[3].Value;

                    if (openingTag == closingTag)
                    {
                        var tag = match.Groups[2].Value;
                        int group1 = int.Parse(match.Groups[4].Value);
                        int group2 = int.Parse(match.Groups[5].Value);
                        int group3 = int.Parse(match.Groups[6].Value);

                        char gr1 = (char)group1;
                        char gr2 = (char)group2;
                        char gr3 = (char)group3;


                        Console.WriteLine($"{tag}: {gr1}{gr2}{gr3}");
                    }
                    else
                    {
                        Console.WriteLine("Valid message not found!");
                    }

                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
            }
    }
}
