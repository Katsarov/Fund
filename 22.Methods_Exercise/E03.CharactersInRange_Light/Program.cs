using System;

namespace E03.CharactersInRange_Light
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            PrintCharsInBetween(start, end);
            Console.WriteLine();

        }

        static void PrintCharsInBetween(char a, char b)
        {
            if (a < b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = b + 1; i < a; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
        }
    }
}
