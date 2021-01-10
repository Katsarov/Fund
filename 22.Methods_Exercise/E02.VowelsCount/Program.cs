using System;
using System.Linq;

namespace E02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that receives a single string and prints the count of the vowels. Use appropriate name for the method.

            string input = Console.ReadLine().ToLower();
            CountVowels(input);
        }

        static void CountVowels(string text)
        {
            int vowelsCounter = 0;
            char[] vowels = new char[] { 'a', 'o', 'u', 'e', 'i' };

            for (int i = 0; i < text.Length; i++)
            {

                if (vowels.Contains(text[i]))
                {
                    vowelsCounter++;
                }
            }
            Console.WriteLine(vowelsCounter);
        }
    }
}
