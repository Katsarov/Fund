using System;

namespace _1.DemoSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. SUBSTRING
            string text = "abcda";
            string newText = text.Substring(0, 3);
            Console.WriteLine(newText);

            // Връща като резултат abc -> взима елемента на нулева позицич и размера на новия стринг е с дълвина 3 елемента

        }
    }
}
