using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.DemoToDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> words = new List<string>() { "pesho", "abc", "gosh" };

            // Искаме да направим стринг, който да бъде с ключ съответния стринг / дума, и с големина колкото е дължината на думите (pesho ->5, abc -> 3, gosh -> 4)

            // Създаваме си речник, в който поставяме стринговете, като ключа е  а => a, а стойността е дълвината на велюто
            Dictionary<string, int> wordsAsDict = words.ToDictionary(a => a, b => b.Length);

            // a и b са целия стринг, те са текущи стойности. В случая а => a e целич ключ, а валюто ще бъде големината на текущия стринг b => b.Length.

            foreach (var item in wordsAsDict)
            {
                //Console.WriteLine($"{item.Key} : {String.Join(" ", item.Value)}");
                Console.WriteLine($"{item.Key} : {item.Value}");
            }

        }
    }
}
