using System;
using System.Linq;
using System.Text;

namespace _02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            StringBuilder result = new StringBuilder();

            // За всяка отделна дума
            foreach  (string word in words)
            {
                // Правим цикъл, който се върти до дължината на настоящата думата, ако думата е с 3 букви, цикъла се завърта 3 пъти 
                for (int i = 0; i < word.Length; i++)
                {
                    result.Append(word);
                    // Резултат: (bla op-> bla+bla+bla+op+op -> blablablaopop)
                }
            }

            Console.WriteLine(result);
        }
    }
}
