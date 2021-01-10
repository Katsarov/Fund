using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new string[] { " " },StringSplitOptions.RemoveEmptyEntries).ToList();

            string text = FormText(input).ToString();

            Dictionary<char, int> countOfChars = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (countOfChars.ContainsKey(symbol))
                {
                    countOfChars[symbol]++;
                }
                else
                {
                    countOfChars.Add(symbol, 1);
                }   
            }
            foreach (var pair in countOfChars)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }

        static StringBuilder FormText(List<string> input)
        {
            StringBuilder result = new StringBuilder();

            foreach (var item in input)
            {
                result.Append(item);
            }

            return result;
        }
    }
}
