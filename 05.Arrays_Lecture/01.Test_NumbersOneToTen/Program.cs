using System;
using System.Linq;

namespace _01.Test_NumbersOneToTen
{
    class Program
    {
        static void Main(string[] args)
        {

            //Отпечатайте всички числа от 0 до 100 през 5
            //Console.Write("Enter array lenght: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] number = new int[n/5 + 1];  //100 / 5 + 1 = 21 клетки ще имаме в масива

            //for (int i = 0; i < number.Length; i++)
            //{
            //    number[i] = i * 5;  // 0*5 = 0; 1*5 = 5; 2*5 = 10; 3*5 = 15 и т.н.
            //}

            //for (int i = 0; i < number.Length; i++)
            //{
            //    Console.WriteLine($"Array [{i}] = {number[i]}");  // клетката в масива = стойността в клетката
            //}

            //Console.WriteLine($"The array lenght is: {number.Length}");

            string input = Console.ReadLine();

            int[] numbers = input.Split(new char[] {',', '.', ' '}).Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Array[{i}]= {numbers[i]}");
            }
        }
    }
}
