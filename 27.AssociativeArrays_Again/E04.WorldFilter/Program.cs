using System;
using System.Linq;

namespace E04.WorldFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Имаме текст с думи. трябва да отпечатаме само тези думи, които са с четен брой букви (примерно kiwi)

            string[] words = Console.ReadLine().Split();

            string[] wordsWithoutOdd = words.Where(x => x.Length % 2 == 0).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, wordsWithoutOdd));
        }
    }
}
