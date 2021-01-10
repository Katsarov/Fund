using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bestCount = 0;  // тук ще държим най-дългата поредица от числа
            int bestIndex = 0;  // тук ще държим най-големия индекс

            for (int i = 0; i < arr.Length; i++)
            {
                int currElement = arr[i];  // присвояваме текущата стойност на масива в една променлива (сегашния елемент е равен на елемента с индекс 0)
                int currCount = 1;  // започваме от 1, защото вече имаме 1 елемент, който ще сравняваме

                for (int currI = i + 1; currI < arr.Length; currI++)  // за следващия елемент въртим цикъл за да проверим дали са същите като него
                {
                    if (currElement == arr[currI])  // ако сегашния елемент е равен на следващия елемент
                    {
                        currCount++; // увеличавай бройката, защото си намерил съседен елемент, който е същият като този
                    }
                    else
                    {
                        break;
                    }
                }

                if (currCount > bestCount)  // като извъртим веднъж цикъла проверяваме текущия каунт, който сме намерили дали е по-добър от предния
                {
                    bestCount = currCount;
                    bestIndex = i;
                }
            }
            string result = string.Empty;  // в един стринг добавяме стойността на елемента от най-дългата поредица
            for (int i = 0; i < bestCount; i++)
            {
                result += arr[bestIndex] + " ";
            }
            Console.WriteLine(result);  // отпечатваме стринга
        }
    }
}
