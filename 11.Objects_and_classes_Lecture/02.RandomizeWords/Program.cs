using System;

namespace _02.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            StringRandomizer randomizer = new StringRandomizer(); // правим си един стринг, който ще рандомизира думите
            randomizer.Words = Console.ReadLine().Split();  // прочитаме си входа от козолата и го сплитваме
            randomizer.Randomise();  //това е метода за рандомизиране на думите
            randomizer.PrintWords();  // това е метода за отпечатване на думите
        }
    }

    public class StringRandomizer
    {
        public string[] Words; // правим си един стринг масив за думите

        public void Randomise()  //правим си един метод, в който ще си направим логиката за разбъркване на думите
        {
            Random rand = new Random();
            for (int i = 0; i < this.Words.Length; i++)  // обхождаме всяка една дума от масива
            {
                int randomPosition = rand.Next(0, this.Words.Length);  // това ще е случайна позиция в масива, започва от 0 до дължината на масива

                //сега ги суапваме
                string temp = this.Words[i];
                this.Words[i] = this.Words[randomPosition];
                this.Words[randomPosition] = temp;
            }
        }

        public void PrintWords()  // правим си метод за отпечатване на думите
        {
            Console.WriteLine(string.Join(Environment.NewLine, this.Words));
        }
    }
}
