using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string correctPassword = string.Empty;  //тук ще си пазим коректната парола

            for (int i = username.Length - 1; i >= 0; i--)  // прочитаме паролата наобратно
            {
                correctPassword += username[i]; // ще ни залепя всяка една буквичка наобратно към празния стринг
            }

            for (int i = 1; i <= 4; i++)
            {
                string password = Console.ReadLine();

                if (correctPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                if (i <= 3)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {username} blocked!");
                }
            }
        }
    }
}
