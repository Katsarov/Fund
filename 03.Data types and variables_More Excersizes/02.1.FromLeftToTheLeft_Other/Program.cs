using System;

namespace _02._1.FromLeftToTheLeft_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineNumber = int.Parse(Console.ReadLine());

            for (int line = 0; line < lineNumber; line++)
            {
                string s = Console.ReadLine();
                string firstNumber = "";
                string secondNumber = "";

                for (int i = 0; i < s.Length; i++)
                {
                    char c = s[i];
                    firstNumber += (char)c;

                    if (c == ' ')
                    {
                        for (int y = i + 1; y < s.Length; y++)
                        {
                            char c2 = s[y];
                            secondNumber += (char)c2;
                        }
                        break;
                    }
                }
                long sumMaxNumber = 0;
                long leftNumber = long.Parse(firstNumber);
                long rightNumber = long.Parse(secondNumber);

                long maxNumber = Math.Abs(Math.Max(leftNumber, rightNumber));

                while (maxNumber > 0)
                {
                    long currDigit = maxNumber % 10;
                    maxNumber /= 10;
                    sumMaxNumber += currDigit;
                }
                Console.WriteLine(sumMaxNumber);
            }
        }
    }
}
