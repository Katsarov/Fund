using System;
using System.Text;

namespace _05.DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            //  Сега минаваме по всеки един елемент и проверяваме дали той е цифра, буква или символ
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))  // тук директно си използваме метода IsDigit()
                {
                    digits.Append(text[i]);
                }
                else if (char.IsLetter(text[i]))  // тук директно си използваме метода IsLetter()
                {
                    letters.Append(text[i]);
                }
                else      // тук са всички останали
                {
                    others.Append(text[i]);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }

    }
}
