using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHand = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondtHand = Console.ReadLine().Split().Select(int.Parse).ToList();

            Compare(firstHand, secondtHand);

            if (firstHand.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {Sum(secondtHand)}");
            }
            else if (secondtHand.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {Sum(firstHand)}");
            }
        }

        static void Compare(List<int> firstHand, List<int> secondHand)
        {
            bool winnerFound = false;

            while (!winnerFound)
            {
                if (firstHand.Count == 0 || secondHand.Count == 0)
                {
                    winnerFound = true;
                    continue;
                }

                if (firstHand[0] > secondHand[0])
                {
                    firstHand.Add(firstHand[0]);
                    firstHand.Add(secondHand[0]);
                    firstHand.Remove(firstHand[0]);
                    secondHand.Remove(secondHand[0]);

                }

                else if (secondHand[0] > firstHand[0])
                {
                    secondHand.Add(secondHand[0]);
                    secondHand.Add(firstHand[0]);
                    secondHand.Remove(secondHand[0]);
                    firstHand.Remove(firstHand[0]);
                }

                else if (firstHand[0] == secondHand[0])
                {
                    firstHand.Remove(firstHand[0]);
                    secondHand.Remove(secondHand[0]);
                }
            }
        }

        static int Sum(List<int> hand)
        {
            int sum = 0;

            foreach (var card in hand)
            {
                sum += card;
            }

            return sum;
        }
    }
}
