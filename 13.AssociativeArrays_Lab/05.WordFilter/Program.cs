using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            // Създаваме си един лист от стрингове, в който ще събираме само думите с четен брой букви.
            List<string> evenLength = words.Where(word => word.Length % 2 == 0).ToList();

            // Вариант 1 за отпечатване
            //Console.WriteLine(string.Join(Environment.NewLine, evenLength));

            // Вариант 2 за отпечатване
            foreach (string word in evenLength)
            {
                Console.WriteLine(word);
            }
        }
    }
}
