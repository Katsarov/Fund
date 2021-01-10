using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _05.MessageTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"\!(?<command>[A-Z][a-z]{2,})\!\:\[(?<number>[A-Za-z]{8,})\]";

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();

                Regex regex = new Regex(pattern);

                Match match = regex.Match(message);

                if (!match.Success)
                {
                    Console.WriteLine("The message is invalid");
                }

                else
                {
                    var number = match.Groups["number"].Value;
                    var command = match.Groups["command"].Value;
                    string encrNumbers = string.Empty;
                    for (int j = 0; j < number.Length; j++)
                    {
                        encrNumbers += ((int)number[j] + " ");
                    }

                    Console.WriteLine($"{command}: {encrNumbers}");
                }
            }
        }
    }
}
