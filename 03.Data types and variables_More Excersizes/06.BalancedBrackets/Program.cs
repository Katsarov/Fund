using System;

namespace _06.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int countOpenBracket = 0;
            int countClosedBracket = 0;
            int countStrings = 0;

            for (int i = 0; i < lines; i++)
            {
                string current = Console.ReadLine();

                if (current == "(")
                {
                    countOpenBracket++;
                }
                if (current == ")")
                {
                    countClosedBracket++; 
                }
                if(current != "(" || current != ")")
                {
                    countStrings++;
                }

            }
            if (countOpenBracket == countClosedBracket)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
