using System;

namespace _3.DemoReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.1. REPLACE

            string text = "SoftUni is the best";
            string newText = text.Replace("SoftUni", "BSU");  // Заменя SoftUni с BSU
            Console.WriteLine(newText);



            // 2.2. REPLACE
            string words = "BMW is the great company in the world!";
            words = words.Replace("BMW", "Heineken");   // Заменя BMW с Heineken
            Console.WriteLine(words);
        }
    }
}
