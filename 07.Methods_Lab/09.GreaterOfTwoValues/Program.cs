using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetBigger(first, second));
            }

            if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetBigger(first, second));
            }

            if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetBigger(first, second));
            }
        }

        static char GetBigger(char first, char second)
        {
            int compare = first.CompareTo(second);
            //сравнява две числа. Ако първото е по-голямо - връща 1, ако са равни - връща 0 и ако второто е по-голямо от първото - връща -1.
            // Това е много удобно тъй като сравняваме различни типове данни - числа, стрингове и чарактъри!!!

            if (compare > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static string GetBigger(string first, string second)
        {
            int compare = first.CompareTo(second);

            // Това е много удобно тъй като сравняваме различни типове данни - числа, стрингове и чарактъри!!!

            if (compare > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        static int GetBigger(int first, int second)
        {
            int compare = first.CompareTo(second);

            // Това е много удобно тъй като сравняваме различни типове данни - числа, стрингове и чарактъри!!!

            if (compare > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
