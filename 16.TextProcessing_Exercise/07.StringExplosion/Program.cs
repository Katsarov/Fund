using System;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();   // abv>1>1>2>2asdasd - това ни е входа

            // Поневе ще манипулираме стринг, правим си един StringBuilder. Към него ще долепяме тези символи, които трябва да долепяме, а останалите - ще ги пропускаме
            StringBuilder sb = new StringBuilder();

            // Тук си правим една променлива power
            int power = 0;


            // Програмата ни трябва да обховда този стринг
            for (int i = 0; i < input.Length; i++)
            {
                // Това ни е настоящият символ, с който ще работим
                char current = input[i];

                // Ако имаме експлозия, ние знаем, че силата на експлозията е числото след нея, т.е. толкова символа трябва да премахнем (ако е >2, трябва да махнем 2 символа)
                if (current == '>')
                {
                    // Отново в дясно имаме чар, който трябва да преобразуваме в стринг, който да парснем към инт
                    power = int.Parse(input[i + 1].ToString());
                    sb.Append(current);
                }
                else if (power == 0)
                {
                    sb.Append(current);
                }

                // Ако не е никое от горните, отнемаме по една единица от силата на експлозияте
                else
                {
                    power--;
                }
            }

            Console.WriteLine(sb);
        }
    }
}
