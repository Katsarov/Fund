using System;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            // Трябва да минем по всяка една дума
            for (int i = 0; i < words.Length; i++)
            {
                // Искаме да променим текущата дума words[i] с толкова звездички *, колкото е големината на тази дума words[i].Length
                text = text.Replace(words[i], new string('*', words[i].Length));
            }

            Console.WriteLine(text);
        }
    }
}
