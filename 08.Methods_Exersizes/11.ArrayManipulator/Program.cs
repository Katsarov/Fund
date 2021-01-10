using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split();  // ["exchange", "1"]
               
                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);

                    if (index < 0 || index > arr.Length - 1)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    Exchange(arr, index);
                }
                else if(command[0] == "max")
                {
                    if (command[1] == "even")
                    {
                        if (MaxEven(arr) == -1)
                        {
                            Console.WriteLine("No matches");
                            continue;
                        }
                        Console.WriteLine(MaxEven(arr));
                    }
                }
                else
                {
                    if (MaxEven(arr) == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                    Console.WriteLine(MaxOdd(arr));
                }
            }

        }

        static void Exchange(int[] array, int index)
        {
            // array = 1 3 5 7 9
            // exchange 1
            // firstArray = 5 7 9
            // secondArray = 1 3

            int[] firstArray = new int[array.Length - index - 1];
            int[] secondArray = new int[index + 1];

            int firstArrCounter = 0;
            for (int i = index + 1; i < array.Length; i++)
            {
                firstArray[firstArrCounter] = array[i];
                firstArrCounter++;
            }

            for (int i = 0; i < index + 1; i++)
            {
                secondArray[i] = array[i];
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                array[i] = firstArray[i];
            }

            for (int i = 0; i < secondArray.Length; i++)
            {
                array[firstArray.Length + i] = secondArray[i];
            }
        }

        static int MaxEven(int[] array)
        {
            int maxEven = int.MinValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    if (array[i] >= maxEven)
                    {
                        maxEven = array[i];
                        index = i;
                     }
                }
            }

            return index;
        }

        static int MaxOdd(int[] array)
        {
            int maxOdd = int.MinValue;
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    if (array[i] >= maxOdd)
                    {
                        maxOdd = array[i];
                        index = i;
                    }
                }
            }

            return index;
        }
    }
}
