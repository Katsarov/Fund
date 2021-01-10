using System;
using System.Text.RegularExpressions;

namespace _0.DemoSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "1  2 3                 4                                         5";
            string pattern = @"\s+";

            string[] results = Regex.Split(text, pattern);
            Console.WriteLine(string.Join(", ", results));
        }
    }
}
