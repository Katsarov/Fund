using System;

namespace D05.Demo_Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Kolko hubavo e na moreto! Peche slunce.";

            string[] words = text.Split();

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
