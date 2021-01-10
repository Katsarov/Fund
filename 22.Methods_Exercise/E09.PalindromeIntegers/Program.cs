using System;
using System.Linq;

namespace E09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {

                Console.WriteLine(IsPalindrome(input).ToString().ToLower());

                input = Console.ReadLine();
            }
        }

        static bool IsPalindrome(string text)
        {
            // Примерно сме въвели 123
            var reversed = text.Reverse().ToArray(); // обръща стринга, праши го 321
            for (int i = 0; i < text.Length; i++)
            {
                // Проверяваме дали първия елемент от text[i], който е 1 е еднакъв с първия елемент от reversed[i], kojto e 3.
                if (!(text[i] == reversed[i]))
                {
                    return false;
                }
            }

            return true;

        }
    }
}
