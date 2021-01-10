using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            int vowelsCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (isVowel(symbol))
                {
                    vowelsCount++;
                }
            }

            Console.WriteLine(vowelsCount);

        }

        static bool isVowel(char letter)
        {
            return letter == 'a' || letter == 'o' || letter == 'u'
                || letter == 'e' || letter == 'i' || letter == 'y';
        }
    }
}
