using System;
using System.Collections.Generic;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Създаваме си направо сортиран речник, тъй като в условието се иска компаниите да бъдат сортирани по име

            var companies = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }

                // Сплитваме входа по "->" на име на служителя и номер на служителя 
                string name = input.Split(" -> ")[0];
                string id = input.Split(" -> ")[1];

                // Правим проверка дали този служител го имаме вече или не
                if (!companies.ContainsKey(name))
                {
                    companies.Add(name, new List<string>());
                    companies[name].Add(id);
                }

                else
                {
                    // добавяме номера само акo го няма в листа

                    List<string> ids = companies[name];
                    if (!ids.Contains(id))
                    {
                        companies[name].Add(id);
                    }
                }
            }

            // Накрая принтираме
            foreach (var item in companies)
            {
                // Принтираме си първо името на компанията
                Console.WriteLine(item.Key);

                // След това трябва да принтираме списъка с номера, който си го държим в item.Value
                foreach  (string id in item.Value)
                {
                    Console.WriteLine("-- " + id);
                }
            }
        }
    }
}
