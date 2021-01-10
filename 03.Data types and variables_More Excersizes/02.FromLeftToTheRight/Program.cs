using System;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < lineCount; i++)
            {
                string number = Console.ReadLine();

                int sumNumberOne = 0;
                int sumNumberTwo = 0;

                int counterLeft = 0;
                int counterRight = 0;

                for (int j = 0; j < number.Length - 1; j++)
                {
                    char symbol = number[j];

                    if (symbol == ' ')
                    {
                        break;
                    }

                    if (symbol == '-')
                    {
                        counterLeft++;
                        continue;
                    }
                    byte digit = byte.Parse(symbol.ToString());
                    sumNumberOne += digit;
                }

                for (int k = number.Length - 1; k >= 0; k--)
                {
                    char symbol = number[k];

                    if (symbol == ' ')
                    {
                        break;
                    }
                    if (symbol == '-')
                    {
                        counterRight++;
                        continue;
                    }
                    byte digit = byte.Parse(symbol.ToString());
                    sumNumberTwo += digit;
                }

                if (counterLeft > 0 )
                {
                    sumNumberOne = sumNumberOne * (-1);
                }
                else
                {
                    sumNumberOne = sumNumberOne * 1;
                }
                if (counterRight > 0)
                {
                    sumNumberTwo *= (-1);
                }
                else
                {
                    sumNumberTwo = sumNumberTwo * 1;
                }
                if (sumNumberOne > sumNumberTwo)
                {
                    Console.WriteLine(sumNumberOne);
                }
                else
                {
                    Console.WriteLine(sumNumberTwo);
                }
            }
        }
    }
}
