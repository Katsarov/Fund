using System;
using System.Collections.Generic;

namespace _01.CountChars_Desi
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Dictionary<char, int> charsCount = new Dictionary<char, int>();

            // За да преминем през всички символи, ги обхождаме с един цикъл
            for (int i = 0; i < text.Length; i++)
            {
                // достъпваме всеки един символ спрямо неговата позиция
                char symbol = text[i];

                // Проверка дали нашия символ е интервал. Ако е така, пропускаме го и минаваме нататък.
                if (symbol == ' ')
                {
                    continue;
                }

                // Проверяваме дали символа го има в речника. Ако да - само го преброяваме
                if (charsCount.ContainsKey(symbol))
                {
                    // достъпваме си стойността по нейния ключ [symbol]
                    charsCount[symbol]++;
                }

                // Проверяваме дали символа го няма в речника. Ако го няма - го добавяме.
                else
                {
                    charsCount.Add(symbol, 1);
                }
            }

            foreach (var pair in charsCount)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}
