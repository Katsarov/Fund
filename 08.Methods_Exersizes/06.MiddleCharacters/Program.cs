using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintMiddleCharacter(text);
        }

        static void PrintMiddleCharacter(string text)
        {
            if (text.Length % 2 == 0)  // Ако дължината на стринга е четна, трябва да принтираме 2 символа
            {
                char firstSymbol = text[text.Length / 2 - 1];  // това ще ни върне първият (левият) символ
                char secondSymbol = text[text.Length / 2];

                Console.WriteLine(firstSymbol + "" + secondSymbol);
            }

            else  // Ако дължината на стринга е нечетна, трябва да принтираме 1 символ, този в средата
            {
                char symbol = text[text.Length / 2];

                Console.WriteLine(symbol);
            }
        }
    }
}
