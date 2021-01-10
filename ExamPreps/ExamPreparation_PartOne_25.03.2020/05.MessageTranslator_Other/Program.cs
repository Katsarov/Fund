using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.MessageTranslator_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\!(?<command>[A-Z][a-z]{2,})\!\:\[(?<number>[A-Za-z]{8,})\]";

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();

                bool isValid = Regex.IsMatch(input, pattern);

                if (!isValid)
                {
                    Console.WriteLine("The message is invalid.");
                    continue;
                }

                string[] inputInfo = input.Split(':');
                string command = inputInfo[0].Replace("!", " ");
                string message = inputInfo[1].Replace("[", "").Replace("]", "");

                // VARIANT 1
                //string result = string.Empty;
                //for (int k = 0; k < message.Length; k++)
                //{
                //    result += (int)message[k] + " ";
                //}

                //Console.WriteLine($"{command}: {result}");

                // VARIANT 2
                int[] result = message.Select(x => (int)x).ToArray();

                Console.WriteLine($"{command}: {string.Join(" ", result)}");
            }
        }
    }
}
