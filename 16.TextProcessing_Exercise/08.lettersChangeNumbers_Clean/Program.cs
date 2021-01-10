using System;

namespace _08.lettersChangeNumbers_Clean
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            //double resultBefore = 0;
           // double resultAfter = 0;
            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                double resultBefore = 0;
                double resultAfter = 0;

                string text = input[i];

                char letterBefore = text[0];
                char letterAfter = text[text.Length - 1];
                int number = int.Parse(text.Substring(1, text.Length - 2));

                int letterBeforePosition = char.Parse(letterBefore.ToString().ToUpper()) - 64;
                int letterAfterPosition = char.Parse(letterAfter.ToString().ToUpper()) - 64;

                // Нека си направим сега проверки за тези стрингове
                // Ако първата буква е главна, трябва да разделим числото след буквата на позицията на буквата (B16с -> 16 / 2 )

                // Да проверим дали буквата е главна -> по кода в ASCII table
                if (letterBefore >= 65 && letterBefore <= 90)
                {
                    int divideItem = number / letterBeforePosition;
                    resultBefore = divideItem;
                    sum += resultBefore;

                }

                // В противен случай е малка буквата, тогава трябва да умновим числото след буквата на позицията на буквата (d16A -> 16 * 4 )
                else
                {
                    int multiplyItem = number * letterBeforePosition;
                    resultBefore = multiplyItem;
                    sum += resultBefore;
                }

                // Сега проверяваме за letterAfter - по абсолютно същия начин
                if (letterAfter >= 65 && letterAfter <= 90)
                {
                    int substractItem = number - letterAfterPosition;
                    resultAfter = substractItem;
                    sum += resultAfter;
                }
                else
                {
                    int addItem = number + letterAfterPosition;
                    resultAfter = addItem;
                    sum += resultAfter;
                }
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}
