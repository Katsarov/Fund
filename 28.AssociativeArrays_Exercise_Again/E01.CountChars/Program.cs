using System;
using System.Collections.Generic;

namespace E01.CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> charsCount = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (symbol == ' ')
                {
                    continue;
                }

                if (!charsCount.ContainsKey(symbol))
                {
                    charsCount.Add(symbol, 1);  
                }
                else
                {
                    charsCount[symbol]++;
                }
            }

            foreach (var item in charsCount)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
