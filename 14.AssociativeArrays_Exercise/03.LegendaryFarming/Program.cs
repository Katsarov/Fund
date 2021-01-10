using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Създаваме си по един речник за материалите и за боклуците
            Dictionary<string, int> items = new Dictionary<string, int>();
            Dictionary<string, int> junk = new Dictionary<string, int>();

            bool isFound = false;
            items.Add("shards", 0);
            items.Add("fragments", 0);
            items.Add("motes", 0);

            while (!isFound)
            {
                // прочитаме си входа и го сплитваме
                string[] input = Console.ReadLine().Split().ToArray();

                // въртим цикъл по цялата дълвина на масива, като проверяваме елементите през 1, тъй като имаме число и след това стринг
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string name = input[i + 1].ToLower();

                    // Проверяваме дали материала е в речника с материалите
                    if (items.ContainsKey(name))
                    {
                        items[name] += quantity;
                        if (items[name] >= 250)
                        {
                            isFound = true;
                            string legendaryItem = FindLegendaryItem(name);
                            Console.WriteLine($"{legendaryItem} obtained!");
                            items[name] -= 250;
                            break;
                        }
                    }

                    else
                    {
                        if (!junk.ContainsKey(name))
                        {
                            junk[name] = 0;
                        }

                        junk[name] += quantity;
                    }
                }
            }

            items = items.OrderByDescending(v => v.Value).ThenBy(k => k.Key).ToDictionary(a => a.Key.ToLower(), b => b.Value);
            junk = junk.OrderBy(k => k.Key.ToLower()).ToDictionary(a => a.Key.ToLower(), b => b.Value);

            foreach (var pair in items)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            foreach (var pair in junk)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

        private static string FindLegendaryItem(string name)
        {
            string legendaryItem = string.Empty;
            switch (name)
            {
                case "shards":
                    legendaryItem = "Shadowmourne";
                    break;

                case "fragments":
                    legendaryItem = "Valanyr";
                    break;

                case "motes":
                    legendaryItem = "Dragonwrath";
                    break;
            }

            return legendaryItem;
        }
    }
}
