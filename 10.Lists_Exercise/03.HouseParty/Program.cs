using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = new List<string>();

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                List<string> text = Console.ReadLine().Split().ToList();
                string name = text[0];

                if (text.Count == 3)
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, guests));

            //Друг вариант за отпечатване на имената на отделни редове

            //foreach (var item in guests)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
