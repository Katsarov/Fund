using System;
using System.Collections.Generic;

namespace _01._1.CountWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "One advanced now diverted domestic sex repeated now bringing you old. Possible procured her trifling now laughter thoughts property she met way.";
            string[] words = text.Split();

            var output = new SortedDictionary<string, int>();

            // Прочитаме
            foreach (string items in words)
            {
                if (output.ContainsKey(items))
                {
                    output[items]++;
                }
                else
                {
                    output.Add(items, 1);
                }
            }

            // Отпечатваме
            foreach (var word in output)
            {
                Console.WriteLine(word.Key + " - " + word.Value);
            }
        }
    }
}
