using System;
using System.Text;

namespace E03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a method that receives two characters and prints on a single line all the characters in between them according to ASCII.

            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());

            CharactersInBetween(char1, char2);
        }

        static void CharactersInBetween(char a, char b)
        {
            if (a < b)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = a + 1; i < b; i++)
                {
                    sb.Append((char)i + " ");
                }

                string newSb = sb.ToString().Trim();
                Console.WriteLine(string.Join(" ", newSb));
            }
            else
            {
                char temp = a;
                a = b;
                b = temp;

                StringBuilder sb = new StringBuilder();
                for (int i = a + 1; i < b; i++)
                {
                    sb.Append((char)i + " ");
                }

                string newSb = sb.ToString().Trim();
                Console.WriteLine(string.Join(" ", newSb));
            }   

        }
    }
}
