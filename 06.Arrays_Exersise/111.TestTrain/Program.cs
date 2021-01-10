using System;
using System.Linq;

namespace _09.CaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  // примерен вход: 1!0!1!1!0

            string input = Console.ReadLine();

            int bestLength = 1;
            int bestStartIndex = 0;
            int bestSequenceSum = 0;
            int bestSequenceIndex = 0;
            int[] bestSequence = new int[n];

            int sequenceCounter = 0;  //  брояч за да си броим редиците и коя е най-добрата редица 

            while (input != "Clone them!")
            {
                int[] currentSequence = input.
                    Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                // изхода е: 1 0 1 1 0

                sequenceCounter++;

                //1. Да намерим най-дългата подредица от единици

                int length = 1;                     //първоначалната стойност е 1, тъй като една редица мове да има най-малко 1 елемент
                int bestCurrentLength = 1;                 // тук ще пацим най-дългата поредица от единици
                int startIndex = 0;                 // началния индекс на най-дългата поредица
                int currentSequenceSum = 0;        // сумата на сегашната поредица
               

                for (int i = 0; i < currentSequence.Length - 1; i++)        // за да не излезем от масива, го проверяваме до ....Length - 1
                {
                    if (currentSequence[i] == currentSequence[i + 1])       //ако сегашния елемент е еднакъв със следващия
                    {
                        length++;           // увеличаваме дължината на редицата
                    }
                    else
                    {
                        length = 1;         // за да мове ако не са равни, при следващото завъртане дължината отново да започва от 1
                    }

                    if (length > bestCurrentLength)
                    {
                        bestCurrentLength = length;
                        startIndex = i;
                    }
                    currentSequenceSum += currentSequence[i];
                }

                currentSequenceSum += currentSequence[n - 1];  //  за да хванем и последния елемент и да го прибавим към сумата

                // до тук сме готови с нашата сегашна редица. Сега трябва да я сравняваме с други редици.
                //ако има 2 редици с еднакви дължини на подредиците им, трябва да вземем тази, която е с по-ляв стартиращ индекс

                //  намираме най-добрата дължина, индекс и сума
                if (bestCurrentLength > bestLength)
                {
                    bestLength = bestCurrentLength;
                    bestStartIndex = startIndex;
                    bestSequenceSum = currentSequenceSum;
                    bestSequenceIndex = sequenceCounter;
                    bestSequence = currentSequence.ToArray();  //  когато казваме,че масив 1 = масив 2, използваме .ToArray()
                }

                //  в другия случай, когато са равни
                else if (bestCurrentLength == bestLength)
                {
                    if (startIndex < bestStartIndex)                        // отново презаписваме същите неща
                    {
                        bestLength = bestCurrentLength;
                        bestStartIndex = startIndex;
                        bestSequenceSum = currentSequenceSum;
                        bestSequenceIndex = sequenceCounter;
                        bestSequence = currentSequence.ToArray();  //  когато казваме,че масив 1 = масив 2, използваме .ToArray()
                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (currentSequenceSum > bestSequenceSum)           // отново презаписваме същите неща
                        {
                            bestLength = bestCurrentLength;
                            bestStartIndex = startIndex;
                            bestSequenceSum = currentSequenceSum;
                            bestSequenceIndex = sequenceCounter;
                            bestSequence = currentSequence.ToArray();  //  когато казваме,че масив 1 = масив 2, използваме .ToArray()
                        }
                    }
                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}
