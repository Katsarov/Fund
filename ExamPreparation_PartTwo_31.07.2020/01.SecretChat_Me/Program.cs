using System;
using System.Linq;

namespace _01.SecretChat_Me
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Reveal")
            {
                string[] curMessage = input.Split(":|:");

                if (curMessage.Contains("InsertSpace"))
                {
                    int index = int.Parse(curMessage[1]);
                    message = message.Insert(index, " ");
                }

                if (curMessage.Contains("Reverse"))
                {
                    string substring = curMessage[1];
                    if (message.Contains(substring))
                    {
                        // За да премахнем точно толкова символи, колкото са в субстринга, трябва да намерим стартовия индекс и след това да ги махнем от стартовия стринг
                        message = message.Remove(message.IndexOf(substring), substring.Length);

                        // Сега трябва да обърнем кътнатия субстринг
                        var reversed = new string(substring.Reverse().ToArray());
                        // alternative -> var reversed = String.Concat(substring.Reverse());

                        // След като е ривърснат, искаме да го добавим към края на съобщението
                        message += reversed;

                    }
                    else
                    {
                        Console.WriteLine("error");
                        input = Console.ReadLine();
                        continue;
                    }
                    
                }

                if (curMessage.Contains("ChangeAll"))
                {
                    string substring = curMessage[1];
                    string replacement = curMessage[2];
                    message = message.Replace(substring, replacement);

                }

                Console.WriteLine(message);
                input = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
