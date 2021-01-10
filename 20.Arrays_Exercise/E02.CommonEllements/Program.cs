using System;
using System.Linq;

namespace E02.CommonEllements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program, which prints common elements in two arrays. You have to compare the elements of the second array to the elements of the first.

            string[] arrOne = Console.ReadLine().Split().ToArray();
            string[] arrTwo = Console.ReadLine().Split().ToArray();

            // Вариант 1 - с for loop
            //for (int i = 0; i < arrTwo.Length; i++)
            //{
            //    for (int j = 0; j < arrOne.Length; j++)
            //    {
            //        if (arrOne[j] == arrTwo[i])
            //        {
            //            Console.Write(arrTwo[i] + " ");
            //        }
            //    }
            //}
            //Console.WriteLine();

            // Вариант 2 - с foreach loop
            foreach (var arrTwoItem in arrTwo)
            {
                foreach (var arrOneItem in arrOne)
                {
                    if (arrTwoItem == arrOneItem)
                    {
                        Console.Write(arrOneItem + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
