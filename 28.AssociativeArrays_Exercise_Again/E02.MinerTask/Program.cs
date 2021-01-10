using System;
using System.Collections.Generic;

namespace E02.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(resource))
                {
                    dict.Add(resource, quantity);
                }

                else
                {
                    dict[resource] += quantity;
                }
                
            }

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
