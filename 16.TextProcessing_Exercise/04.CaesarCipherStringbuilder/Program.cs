using System;
using System.Text;

namespace _04.CaesarCipherStringbuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder encripted = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                encripted.Append((char)(text[i] + 3));
            }
            Console.WriteLine(encripted);
        }
    }
}
