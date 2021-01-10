using System;

namespace _1.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "textbambo";
            string result = text.Substring(text.Length - 2); // bo

            Console.WriteLine(result);

            string output = text.Substring(2, 2);  //xt

            Console.WriteLine(output);
        }
    }
}
