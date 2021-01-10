using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char startSymbol = char.Parse(Console.ReadLine());
            char endSymbol = char.Parse(Console.ReadLine());

            PrintCharactersInRange(startSymbol, endSymbol);
        }

        static void PrintCharactersInRange(char startSymbol, char endSymbol)
        {
            int asciiStart = Math.Min(startSymbol, endSymbol);   //по този начин вземаме аски кода на стартовия индекс
            int asciiEnd = Math.Max(startSymbol, endSymbol);   //по този начин вземаме аски кода на крайния индекс

            for (int asciiCode = asciiStart + 1; asciiCode < asciiEnd; asciiCode++)
            {
                char symbol = (char)asciiCode;   // кастваме аски кода към чар
                Console.Write(symbol + " ");
            }
            Console.WriteLine();
        }
    }
}
