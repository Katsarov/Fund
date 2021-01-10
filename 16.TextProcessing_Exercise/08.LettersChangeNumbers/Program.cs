using System;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double resultBefore = 0;
            double resultAfter = 0;
            double sum = 0;

            for (int i = 0; i < input.Length; i++)
            {

                string text = input[i];

                char letterBefore = text[0];
                char letterAfter = text[text.Length - 1];
                int number = int.Parse(text.Substring(1, text.Length - 2));

                // Да си намерим позицията на буквата в ASCII table

                // правим letterBeforePosition на стринг, за да мовем да използваме метова .ToUpper(), правим го след това на чар с char.Parse() ==> това ни връща чара 'А'. От това А вадим 64, и понеже в ASCII table позицията на А е 65, то като извадим 65-64 ни дава 1 ==> т.е. А е на първа позиция.

                int letterBeforePosition = char.Parse(letterBefore.ToString().ToUpper()) - 64;
                int letterAfterPosition = char.Parse(letterAfter.ToString().ToUpper()) - 64;

                // Нека си направим сега проверки за тези стрингове
                // Ако първата буква е главна, трябва да разделим числото след буквата на позицията на буквата (B16с -> 16 / 2 )

                // Да проверим дали буквата е главна -> по кода в ASCII table
                if (letterBefore >= 65 && letterBefore <= 90)
                {
                    int divideItem = number / letterBeforePosition;
                    resultBefore = divideItem;

                }

                // В противен случай е малка буквата, тогава трябва да умновим числото след буквата на позицията на буквата (d16A -> 16 * 4 )
                else
                {
                    int multiplyItem = number * letterBeforePosition;
                    resultBefore = multiplyItem;
                }

                // Сега проверяваме за letterAfter - по абсолютно същия начин
                if (letterAfter >= 65 && letterAfter <= 90)
                {
                    int substractItem = number - letterAfterPosition;
                    resultAfter = substractItem;
                }
                else
                {
                    int addItem = number + letterAfterPosition;
                    resultAfter = addItem;
                }


            }
        }
    }
}
