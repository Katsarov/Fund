using System;
using System.Text;

namespace _07._1.RepeatStringDakov
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(input, n));
        }

        static string RepeatString(string word, int num)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                result.Append(word);  // това долепя стринговете един до друг
            }
            return result.ToString();
        }
    }
}
