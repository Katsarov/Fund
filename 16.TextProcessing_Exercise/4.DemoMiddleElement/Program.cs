using System;
using System.Text;

namespace _4.DemoMiddleElement
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string result = "";
            if (text.Length % 2 == 0)
            {
                result = text.Substring((text.Length / 2) - 1, 2);
            }
            else
            {
                result = text[text.Length / 2].ToString();
            }
            
            Console.WriteLine(result);
        }
    }
}
