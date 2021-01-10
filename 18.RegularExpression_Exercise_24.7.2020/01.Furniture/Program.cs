using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            // Прашим си един лист, в който ще съхраняваме мебелите
            List<string> furniture = new List<string>();
            double totalPrice = 0;

            string input = Console.ReadLine();
            string pattern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)";

            while (input != "Purchase")
            {
                // Трябва да проверим дали инпута е в правилния формат (на патерна)
                // Правим си един регекс
                Regex regex = new Regex(pattern);

                // Този регекс сега искаме да го мачнем към инпута от конзолата
                Match match = regex.Match(input);

                // Ако съвпадението е успешно, ще запаметим тази мебел в един лист
                if (match.Success)
                {
                    furniture.Add(match.Groups[1].Value);

                    // Вземаме цената и я умножаваме по количестшото  (преди това ги парсваме към double (заради десетичната запетая), за да получим общата цена за това количестшо, след което я добавяме към totalprice
                    totalPrice += double.Parse(match.Groups["price"].Value) * double.Parse(match.Groups["quantity"].Value);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            if (furniture.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, furniture));
            }
           
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
