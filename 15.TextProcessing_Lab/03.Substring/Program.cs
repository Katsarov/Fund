using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            // Намираве веднъж думата дали я има в текста
            int index = text.IndexOf(word);

            while (index >= 0)
            {
                // премахни от текста дума, като започнеш от стартовия индекс и махнеш толкова елемента, колкото е дължината на думата
                text = text.Remove(index, word.Length);

                //Това го прави докато можеш да намериш такава дума
                index = text.IndexOf(word);
            }

            Console.WriteLine(text);
        }
    }
}
