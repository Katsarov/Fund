using System;

namespace E02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // Правим си един рандомайзер, който ще приема стрингове и ще ги рандомизира
            StringRandomizer randomizer = new StringRandomizer();
            
            // След това казваме, че четем думите от конзолата
            randomizer.Words = Console.ReadLine().Split();
            
            // След това разбъркваме думите на случаен принцип
            randomizer.Randomize();
            
            // Последно ги отпеѝатваме
            randomizer.PrintWords();
        }
    }

    public class StringRandomizer
    {
        public string[] Words;

        public void Randomize()
        {
            Random rand = new Random();
            for (int i = 0; i < Words.Length; i++)
            {
                int randomPosition = rand.Next(0, Words.Length);
                
                string temp = Words[i];
                Words[i] = Words[randomPosition];
                Words[randomPosition] = temp;
            }
        }

        public void PrintWords()
        {
            Console.WriteLine(string.Join(Environment.NewLine, Words));
        }
    }
}
