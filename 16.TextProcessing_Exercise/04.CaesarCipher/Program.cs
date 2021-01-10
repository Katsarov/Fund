using System;
using System.Text;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            // Създаваме си един празен стринг, в който ще си цъхраняваме променените елементи
            string encrypted = String.Empty;

            // За да криптираме този текст, трябва по някакъв начин да го обходим.
            for (int i = 0; i < text.Length; i++)
            {
                
                encrypted += (char)(text[i] + 3);
                // text[i] + 3 ни връща числото на елемента + 3. В случая: първата буква е Р и ще ни върне S. Но няма да ни го върне като буква, а като ASCII код, т.е. кода на Р е 80, и ще ни върне кода на S, който 83. За да ни върне буква, трябва кода от дясно да ко кастнем към char. 
            }
            Console.WriteLine(encrypted);
        }
    }
}
