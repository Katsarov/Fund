using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            RepeatString(input, n);
        }

        static void RepeatString(string name, int num)
        {
            string newString = string.Empty;

            for (int i = 0; i < num; i++)
            {
                newString += name;
            }
            Console.WriteLine(newString);
        }
    }
}
