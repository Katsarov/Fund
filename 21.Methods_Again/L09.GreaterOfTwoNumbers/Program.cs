using System;

namespace L09.GreaterOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a method GetMax() that returns the greater of two values (the values can be of type int, char or string)

            string commandType = Console.ReadLine();

            if (commandType.Contains("int"))
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(num1, num2));
            }
            if (commandType.Contains("char"))
            {
                char chA = char.Parse(Console.ReadLine());
                char chB = char.Parse(Console.ReadLine());

                Console.WriteLine(GetMax(chA, chB));
            }
            if (commandType.Contains("string"))
            {
                string stringFirst = Console.ReadLine();
                string stringSecond = Console.ReadLine();

                Console.WriteLine(GetMax(stringFirst, stringSecond));
            }
        }

        static int GetMax(int a, int b)
        {
            int result = a.CompareTo(b);
            if (result > 0)
            {
                return a;
            }
            
            else
            {
                return b;
            }
        }

        static char GetMax(char a, char b)
        {
            int result = a.CompareTo(b);
            if (result > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static string GetMax(string strA, string strB)
        {
            int result = strA.CompareTo(strB);
            
            if (result > 0)
            {
                return strA;
            }
            else
            {
                return strB;
            }
        }
    }
}
