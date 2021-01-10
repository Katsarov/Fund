using System;
using System.Collections.Generic;
using System.Linq;

namespace E05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            int[] bombData = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int specialBombNumber = bombData[0];
            int power = bombData[1];

            // Вземаме си индекса на бомбата
            int bombIndex = list.IndexOf(specialBombNumber);

            // Ако имаме повече от 1 бомба трябва да въртим цикъл. А цикъла го слагаме до -1, защото ако 
            // има повече от 1 бомба цикъла се върти, а ако няма, метода IndexOf() връща като резултат -1
            while (bombIndex != -1)
            {
                // Определяме броя на елементите ш ляво и в дясно от бомбата, които ще махнем
                int leftNumbers = bombIndex - power;
                int rightNumbers = bombIndex + power;

                if (leftNumbers < 0)
                {
                    leftNumbers = 0;
                }

                if (rightNumbers > list.Count - 1)
                {
                    rightNumbers = list.Count - 1;
                }

                // Определяме целия рейнд, който заедно с бомбата ще махнем
                list.RemoveRange(leftNumbers, rightNumbers - leftNumbers + 1);

                bombIndex = list.IndexOf(specialBombNumber);
            }

            int sum = list.Sum();

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
