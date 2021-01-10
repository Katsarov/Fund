using System;

namespace _02._1.VowelsCountOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            PrintVowel(text);
        }

        static bool isVowel(char letter)
        {
            return letter == 'a' || letter == 'o' || letter == 'u'
                || letter == 'e' || letter == 'i' || letter == 'y';
        }

        static void PrintVowel(string text)
        {
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
    }
}
