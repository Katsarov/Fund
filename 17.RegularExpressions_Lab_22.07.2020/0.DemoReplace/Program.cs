using System;
using System.Text.RegularExpressions;

namespace _0.DemoReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Kalin: 342, Peter: 221";
            string pattern = @"\d{3}";
            string replacement = "666999";

            Regex regex = new Regex(pattern);
            string result = regex.Replace(text, replacement);

            Console.WriteLine(result);
        }
    }
}
