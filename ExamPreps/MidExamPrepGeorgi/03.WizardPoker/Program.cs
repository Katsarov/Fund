using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.WizardPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> deck = Console.ReadLine().Split(":").ToList();

            string command = Console.ReadLine();

            List<string> newDeck = new List<string>();

            while (command != "Ready")
            {
                string[] curTokens = command.Split().ToArray();

                if (curTokens[0] == "Add")
                {
                    string cardName = curTokens[1];

                    if (deck.Contains(cardName))
                    {
                        newDeck.Add(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }

                }

                else if (curTokens[0] == "Insert")
                {
                    string cardName = curTokens[1];
                    int index = int.Parse(curTokens[2]);

                    if (deck.Contains(cardName) && index >= 0 && index < deck.Count)
                    {
                        newDeck.Insert(index, cardName);
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }

                }

                else if (curTokens[0] == "Remove")
                {
                    string cardName = curTokens[1];
                    if (newDeck.Contains(cardName))
                    {
                        newDeck.Remove(cardName);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }

                else if (curTokens[0] == "Swap")
                {
                    string cardNameOne = curTokens[1];
                    string cardNameTwo = curTokens[2];

                    int firstIndex = newDeck.IndexOf(cardNameOne);
                    int secondIndex = newDeck.IndexOf(cardNameTwo);

                    string temp = newDeck[firstIndex];
                    newDeck[firstIndex] = newDeck[secondIndex];
                    newDeck[secondIndex] = temp;

                }

                if (curTokens[0] == "Shuffle")
                {
                    newDeck.Reverse();
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", newDeck));
        }
    }
}
