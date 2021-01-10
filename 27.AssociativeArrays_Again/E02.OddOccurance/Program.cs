using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.OddOccurance
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> count = new Dictionary<string, int>();

            foreach (var word in words)
            {
              
                string wordToLower = word.ToLower();

                if (!count.ContainsKey(wordToLower))
                {
                    count.Add(wordToLower, 1);
                }
                else
                {
                    count[wordToLower]++;
                }
            }

            foreach (var item in count)
            {
                if (item.Value % 2 == 1)
                {
                    Console.Write(item.Key + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
