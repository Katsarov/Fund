using System;
using System.Linq;

namespace _09._1.CaminoFactoryAlen
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());  //прочитаме колко символа ще бъде дължината на редицата
            
            int[] maxArray = new int[n];
            int bestCurrSum = 0;
            int maxCount = 0;
            int maxIndex = 0;
            int maxSample = 1;
            int currSample = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Clone them!")
                {
                    break;
                }

                int[] currArr = line.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();  //прочитаме масива с числа

                currSample++;
                int bestCurrCount = 0;  //тук ще си пазим най-дългата редица с единици
                int bestCurrIndex = 0;



                for (int currIndex = 0; currIndex < currArr.Length; currIndex++)
                {
                    int currElement = currArr[currIndex];  //  правим си една променлива за настоящия елемент
                    int currCounter = 1;  // правим си брояч за единиците в долния цикъл
                    if (currElement == 0)
                    {
                        continue;  //ако е 0, продължаваме
                    }

                    for (int index = currIndex + 1; index < currArr.Length; index++)  // още един цикъл, от следващия елемент до края на масива
                    {
                        if (currArr[index] == 1)
                        {
                            currCounter++;
                        }
                        else
                        {
                            break;  // излизаме от цикъла
                        }
                    }

                    // с горния цикъл сме обходили всички елементи от масива и сме открили примерно, че имаме дължина 2 с единици

                    if (bestCurrCount > maxCount)
                    {
                        bestCurrCount = currCounter;  // запазва най-голямата дълвина на поредица с единици
                        bestCurrIndex = currIndex;  // запазва индекса на елемента
                        bestCurrSum = currArr.Sum();  // сумира елементите в тази най-дълга поредица
                        //bestArr = arr.ToArray();  // 
                    }

                }

                    if (bestCurrCount > maxCount || (bestCurrCount == maxCount && maxIndex > bestCurrIndex) || (maxArray.Sum() < bestCurrSum ))
                    {
                        maxIndex = bestCurrIndex;
                        maxCount = bestCurrCount;
                        maxArray = currArr;
                        maxSample = currSample;
                    }

                }
                Console.WriteLine($"Best DNA sample {maxSample} with sum: {maxArray.Sum()}.");
                Console.WriteLine(string.Join(" ", maxArray));
            
        }
    }
}
