using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> namesAndKms = new Dictionary<string, int>();

            // Прочитаме кои са участниците
            string[] contestants = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Прочитаме си входа
            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string namePattern = @"[A-Za-z]";
                string digitsPattern = @"[0-9]";

                var nameMatch = Regex.Matches(input, namePattern);
                var kmMatch = Regex.Matches(input, digitsPattern);

                var name = String.Concat(nameMatch);
                var sumOfKm = kmMatch.Select(x => int.Parse(x.Value)).Sum();

                // След като имаме вече името на участника и километрите му, трябва да проверим дали го има сред участниците
                if (contestants.Contains(name))
                {
                    // Ако го има
                    if (namesAndKms.ContainsKey(name))
                    {
                        // Прибавяме само километрите
                        namesAndKms[name] += sumOfKm;
                    }
                    else
                    {
                        // Прибавяме името и километрите 
                        namesAndKms.Add(name, sumOfKm);

                    }
                }

                input = Console.ReadLine();
            }


            // Накрая трябва да сортираме речника, като отпечатаме в низходящ ред по километри само първите 3 участника
            var sorted = namesAndKms.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();

            Console.WriteLine("1st place: " + sorted[0]);
            Console.WriteLine("2nd place: " + sorted[1]);
            Console.WriteLine("3rd place: " + sorted[2]);



        }
    }
}
