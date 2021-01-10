using System;
using System.Collections.Generic;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var companies = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                string name = input.Split(" -> ")[0];
                string id = input.Split(" -> ")[1];

                if (!companies.ContainsKey(name))
                {
                    companies.Add(name, new List<string>());
                    companies[name].Add(id);
                }

                else
                {
                    List<string> ids = companies[name];
                    if (!ids.Contains(id))
                    {
                        companies[name].Add(id);
                    }
                }
            }

            foreach (var item in companies)
            {
                Console.WriteLine(item.Key);

                foreach (string id in item.Value)
                {
                    Console.WriteLine("-- " + id);
                }
            }
        }
    }
}
